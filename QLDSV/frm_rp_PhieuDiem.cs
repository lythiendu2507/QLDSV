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
    public partial class frm_rp_PhieuDiem : Form
    {
        public frm_rp_PhieuDiem()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           
            rp_PhieuDiem report = new rp_PhieuDiem(this.txtMaSV.Text.ToString());
            report.lbMaSV.Text = txtMaSV.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_rp_PhieuDiem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
