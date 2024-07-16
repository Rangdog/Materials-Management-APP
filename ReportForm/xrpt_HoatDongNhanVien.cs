using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class xrpt_HoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_HoatDongNhanVien(String manv, DateTime datefrom, DateTime dateto)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = datefrom;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = dateto;
            this.sqlDataSource1.Fill();
        }

    }
}
