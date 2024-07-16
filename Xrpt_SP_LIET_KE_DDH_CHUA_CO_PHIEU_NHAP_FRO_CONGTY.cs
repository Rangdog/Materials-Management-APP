using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
