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
    public partial class frmNhapDiem : Form
    {
        string macn = "";
       
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void dIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dIEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
             this.lOPTableAdapter.Fill(this.dS.LOP);
             this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
      


           
            macn = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            
            cmbKhoaND.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoaND.DisplayMember = "TENCN";
            cmbKhoaND.ValueMember = "TENSERVER";
            cmbKhoaND.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cmbKhoaND.Enabled = true;  // bật tắt theo phân quyền
            else cmbKhoaND.Enabled = false;

            btnCancer.Enabled = false;
            btnCapNhat.Enabled = false;
            cmbKhoaND.Enabled = false;


        }
        private void Load_diem()
        {
            String str = "SP_SELECT_DIEM_THEO_MALOP_MAMH_LAN '" + cmbMaLop.Text + "','" + cmbMaMH.Text + "','" + lANSpinEdit.Value.ToString() + "'";
            bdsNhapDiem.DataSource = Program.ExecSqlDataTable(str);
            gridControl1.DataSource = bdsNhapDiem;
        }
        
        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void mALOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter.Fill(this.dS.SP_SELECT_DIEM_THEO_MALOP_MAMH_LAN, mALOPToolStripTextBox.Text, mAMHToolStripTextBox.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(lANToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            Load_diem();
            txtTL.Enabled = false;
            txtTMH.Enabled = false;
            lANSpinEdit.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbMaMH.Enabled = false;
            btnCancer.Enabled = true;
            btnCapNhat.Enabled = true;
            btnBD.Enabled = false;
            cmbKhoaND.Enabled = false;

        }

        private void gbNhapDiem_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
                
                
           if( MessageBox.Show("Những dữ liệu bạn thay đổi sẽ bị mất nếu bạn chưa lưu! Bạn thực sự muốn dừng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            Load_diem();
            txtTL.Enabled = true;
            txtTMH.Enabled = true;
            lANSpinEdit.Enabled = true;
            cmbMaLop.Enabled = true;
            cmbMaMH.Enabled = true;
            btnCancer.Enabled = false;
            btnCapNhat.Enabled = false;
            btnBD.Enabled = true;
            cmbKhoaND.Enabled = true;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool kiemTra = false;
            for (int i = 0; i < bdsNhapDiem.Count; i++)
            {
                string masv = ((DataRowView)bdsNhapDiem[i])["MASV"].ToString();
                float diem = float.Parse(((DataRowView)bdsNhapDiem[i])["DIEM"].ToString());
                string str = "SP_INSERT_DIEM '" + masv + "','" + cmbMaLop.Text + "','" + lANSpinEdit.Value.ToString() + "','" + diem + "'";
                kiemTra = Program.ExecSqlNonQuery(str);
                if (!kiemTra) break;
            }
            if (kiemTra)
            {
                Load_diem();
                btnCapNhat.Enabled = false;
                txtTL.Enabled = true;
                txtTMH.Enabled = true;
                lANSpinEdit.Enabled = true;
                cmbMaLop.Enabled = true;
                cmbMaMH.Enabled = true;
                btnCancer.Enabled = false;
                btnBD.Enabled = true;
                cmbKhoaND.Enabled = true;
                MessageBox.Show("Bạn đã lưu dữ liệu thành công!!!", "" + MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
