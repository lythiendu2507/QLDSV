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
    public partial class frm_rp_BangDiemTongKet : Form
    {
        public frm_rp_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void frm_rp_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rp_BDTK report = new rp_BDTK(this.cmbMaLop.SelectedValue.ToString());
            report.lbTenLop.Text = txtTenLop.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}
