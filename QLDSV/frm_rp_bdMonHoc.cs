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
    public partial class frm_rp_bdMonHoc : Form
    {
        public frm_rp_bdMonHoc()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_rp_bdMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;


        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rp_BangDiemMonHoc report = new rp_BangDiemMonHoc(this.cmbMaLop.SelectedValue.ToString(),this.cmbMaMH.SelectedValue.ToString(), float.Parse(this.txtLanThi.Text.ToString()));
            report.lbTenLop.Text = txtTenLop.Text;
            report.lbMonHoc.Text = txtTenMH.Text;
            report.lbLanThi.Text = txtLanThi.Text;
           
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
