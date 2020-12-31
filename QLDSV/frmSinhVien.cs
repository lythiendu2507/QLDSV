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
    public partial class frmSinhVien : Form
    {
        string macn = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;


            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;           
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            

            macn = ((DataRowView)bdsLOP[0])["MAKH"].ToString();
            cmbKhoaSV.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoaSV.DisplayMember = "TENCN";
            cmbKhoaSV.ValueMember = "TENSERVER";
            cmbKhoaSV.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cmbKhoaSV.Enabled = true;  // bật tắt theo phân quyền
            else cmbKhoaSV.Enabled = false;

            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnReLoadSV.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoaSV.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoaSV.SelectedValue.ToString();

            if (cmbKhoaSV.SelectedIndex != Program.mChinhanh)
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

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                macn = ((DataRowView)bdsLOP[0])["MAKH"].ToString();
            }
        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sINHVIENBindingSource.AddNew();
            btnGhiSV.Enabled = true;
        }

        private void btnGhiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView current = (DataRowView)(sINHVIENBindingSource[sINHVIENBindingSource.Position]);
            if(current["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Ma sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (current["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Ho sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (current["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("TEN sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (current["NGAYSINH"].ToString().Trim() == "")
            {
                MessageBox.Show("Ngay sinh cua sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (current["NOISINH"].ToString().Trim() == "")
            {
                MessageBox.Show("Noi sinh cua sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (current["DIACHI"].ToString().Trim() == "")
            {
                MessageBox.Show("Dia chi cua sinh vien khong duoc de trong!!!", "", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Nhap sinh vien thanh cong!!!","",MessageBoxButtons.OK);
            sINHVIENBindingSource.EndEdit();
            sINHVIENBindingSource.ResetCurrentItem();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
        }

        private void btnReLoadSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String masv = "";
            DataRowView current = (DataRowView)(sINHVIENBindingSource[sINHVIENBindingSource.Position]);
            
                if (MessageBox.Show("Ban co thuc su muon xoa sinh vien nay?","Xac nhan",
                MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                try
                {
                    masv = current["MASV"].ToString().Trim();
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Loi xoa sinh vien, hay thu lai", "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    sINHVIENBindingSource.Position = sINHVIENBindingSource.Find("MASV", masv);
                    return;
                }  
            }
            if (sINHVIENBindingSource.Count == 0) btnXoaSV.Enabled = false;
        }

        private void btnPhucHoiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnReLoadSV.Enabled = false;

        }
    }
}
