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
    public partial class frm_rp_HocPhi : Form
    {
        public frm_rp_HocPhi()
        {
            InitializeComponent();
        }

        private void frm_rp_HocPhi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            rp_DongHocPhi report = new rp_DongHocPhi(this.cmbMaLop.SelectedValue.ToString(),
            this.txtNienKhoa.Text.ToString(), Int32.Parse(this.txtHocKy.Text.ToString()));

            report.lbTenLop.Text = cmbMaLop.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            this.Close();
        }
    }
}
