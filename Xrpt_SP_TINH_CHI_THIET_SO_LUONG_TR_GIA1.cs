using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1(String role, String type, DateTime sdate, DateTime edate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = sdate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = edate;
            this.sqlDataSource1.Fill();
        }

    }
}
