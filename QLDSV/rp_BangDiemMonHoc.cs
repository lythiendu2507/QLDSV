using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class rp_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_BangDiemMonHoc(string malop,string mamh,float lanthi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lanthi;

            this.sqlDataSource1.Fill();
        }

    }
}
