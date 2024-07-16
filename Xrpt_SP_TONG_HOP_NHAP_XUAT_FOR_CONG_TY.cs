using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY(DateTime sdate, DateTime edate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = sdate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = edate;
            this.sqlDataSource1.Fill();
        }

    }
}
