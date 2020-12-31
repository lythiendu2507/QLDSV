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
    public partial class frmHocPhi : Form
    {
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_SELECT_SOTIENDONG_THEO_MASVTableAdapter.Fill(this.dS.SP_SELECT_SOTIENDONG_THEO_MASV, txtMaSVHP.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            dS.EnforceConstraints = false;
            
            btnCancerHP.Enabled = false;
            btnGhiHP.Enabled = false;
            txtNienKhoa.Enabled = false;
            txtSTD.Enabled = false;
            seHocPhi.Enabled = false;
            seHocKy.Enabled = false;

        }
        private void Load_bang()
        {
            
            String str = "SP_SELECT_SOTIENDONG_THEO_MASV '" + txtMaSVHP.Text + "'";
            bdsHocPhi.DataSource = Program.ExecSqlDataTable(str);
            grHocPhi.DataSource = bdsHocPhi;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (txtMaSVHP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên!", "", MessageBoxButtons.OK);
                txtMaSVHP.Focus();
                return;
            }

            try
            {
                MessageBox.Show(txtMaSVHP.Text, "" + MessageBoxButtons.OK);
                Load_bang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập mã sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnGhiHP.Enabled = true;
            btnCancerHP.Enabled = false;
            txtMaSVHP.Enabled = false;          
            txtSTD.Enabled = true;

        }

        private void btnGhiHP_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            bool kiemTra = false;

            if (txtSTD.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtSTD.Focus();
                return;
            }


            try
            {
                string str = "SP_INSERT_HOCPHI '" + txtMaSVHP.Text + "','" + txtNienKhoa.Text + "','" + seHocKy.Text + "','" + seHocPhi.Text + "','" + txtSTD.Text + "'";
                kiemTra = Program.ExecSqlNonQuery(str);
                if (!kiemTra)
                {
                    return;
                }
            
                if (kiemTra)
            {
                Load_bang();
                btnGhiHP.Enabled = false;
                btnCancerHP.Enabled = false;
                txtMaSVHP.Enabled = true;
                MessageBox.Show("Bạn đã lưu dữ liệu thành công!!!", "" + MessageBoxButtons.OK);
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi học phí.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void btnCancerHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Những dữ liệu bạn thay đổi sẽ bị mất nếu bạn chưa lưu! Bạn thực sự muốn dừng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            Load_bang();
            btnGhiHP.Enabled = false;
            btnCancerHP.Enabled = false;
            txtMaSVHP.Enabled = true;
        }

        
          

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
