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
    public partial class frmMonHoc : Form
    {
        int vitri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;


            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = btnReLoadMH.Enabled = txtMaMH.Enabled = txtTenMH.Enabled = false;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            gbMonHoc.Enabled = true;
            bdsMonHoc.AddNew();
            


            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReLoadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = true;
            txtMaMH.Enabled = txtTenMH.Enabled = true;
            gcMonHoc.Enabled = false;
            
        }

        private void btnHieuChinhMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            gbMonHoc.Enabled = true;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReLoadMH.Enabled = btnThoatMH.Enabled = false;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = true;
            txtMaMH.Enabled = txtTenMH.Enabled = true;
            gcMonHoc.Enabled = false;

        }

        private void btnGhiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReLoadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;

            gbMonHoc.Enabled = false;
        }

        private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 mamh = 0;

            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }

            if (bdsMonHoc.Count == 0) btnXoaMH.Enabled = false;
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThemMH.Enabled == false) 
            gcMonHoc.Enabled = true;
            gbMonHoc.Enabled = false;
            btnThemMH.Enabled = btnHieuChinhMH.Enabled = btnXoaMH.Enabled = btnReLoadMH.Enabled = btnThoatMH.Enabled = true;
            btnGhiMH.Enabled = btnPhucHoiMH.Enabled = false;
        }

        private void btnReLoadMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
