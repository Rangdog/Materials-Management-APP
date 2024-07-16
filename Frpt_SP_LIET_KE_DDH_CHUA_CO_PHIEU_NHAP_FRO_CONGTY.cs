using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY : Form
    {
        public Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY()
        {
            InitializeComponent();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (ckTatCa.Checked)
            {
                String con = "";
                if(Program.mChiNhanh == 0)
                {
                    con = Program.connstr_window_mode1;
                }
                else
                {
                    con = Program.connstr_window_mode2;
                }
                String cmd = "EXEC sp_addsrvrolemember " + "'" + Program.mlogin + "'" + ", 'sysadmin'";
                Program.ExecSqlNonQueryadd(cmd,con);
                Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY rpt = new Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY();
                rpt.lblSubTieuDe.Text = "Tất Cả Các Chi Nhanh";
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
                cmd = "EXEC sp_dropsrvrolemember " + "'" + Program.mlogin + "'" + ", 'sysadmin'";
                Program.ExecSqlNonQueryadd(cmd,con);
            }
            else
            {
                Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FOR_CHINHANH rpt = new Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FOR_CHINHANH();
                rpt.lblSubTieuDe.Text = "Chi Nhánh" + (Program.mChiNhanh + 1).ToString();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}
