using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class frm_rp_dssv : Form
    {
        public frm_rp_dssv()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_rp_dssv_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else cmbKhoa.Enabled = false;
        }

       

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Lỗi kết nối chi nhánh mới.", "", MessageBoxButtons.OK);
                else
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                }
            }
            catch (NullReferenceException ex) { }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {

            rp_dssv report = new rp_dssv(this.cmbMaLop.SelectedValue.ToString());
            report.lbTenLop.Text = txtTenLop.Text;
            MessageBox.Show(cmbMaLop.SelectedValue.ToString());
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            this.Close();
        }
    }
}
