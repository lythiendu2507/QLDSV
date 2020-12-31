using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class rp_DanhSachThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_DanhSachThiHetMon(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;

            this.sqlDataSource1.Fill();
        }

    }
}
