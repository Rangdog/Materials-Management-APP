using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.ReportForm
{
    public partial class xrptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptDanhSachNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Fill();
        }

    }
}
