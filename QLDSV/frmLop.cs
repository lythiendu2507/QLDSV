using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmLop : Form
    {
        int vitri = 0;
        string macn = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void frmLop_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DS.LOP);

            macn = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else cmbKhoa.Enabled = false;

            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = btnReLoadLop.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = false;
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.lOPTableAdapter.
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                
                macn = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            bdsLop.AddNew();
            txtMaKhoa.Text = macn;


            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReLoadLop.Enabled = btnThoatLop.Enabled = false;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 malop = 0;
           
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = int.Parse(((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString()); // giữ lại để khi xóa khi lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }

            if (bdsLop.Count == 0) btnXoaLop.Enabled = false;
        }

        private void btnPhucHoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThemLop.Enabled == false) bdsLop.Position = vitri;
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReLoadLop.Enabled = btnThoatLop.Enabled = true;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;
        }

        private void btnGhiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLop.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReLoadLop.Enabled = btnThoatLop.Enabled = true;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnSuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnReLoadLop.Enabled = btnThoatLop.Enabled = false;
            btnGhiLop.Enabled = btnPhucHoiLop.Enabled = true;
            gcLop.Enabled = false;
        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
