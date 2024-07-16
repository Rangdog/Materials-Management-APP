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
    public partial class frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA : Form
    {
        public frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA()
        {
            InitializeComponent();
        }

        private void frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA_Load(object sender, EventArgs e)
        {
            cmbPhieu.SelectedIndex = 0;
            dptNgayBatDau.EditValue = "";
            dptNgayKetThuc.EditValue = "";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String ngayBatDau = dptNgayBatDau.EditValue.ToString();
            String ngayKetThuc = dptNgayKetThuc.EditValue.ToString();
            if (ngayBatDau.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được thiếu","",MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
                return;
            }
            if(DateTime.Compare(Convert.ToDateTime(ngayBatDau), DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn hiện tại", "", MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
                return;
            }
            if(ngayKetThuc.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không được thiếu", "", MessageBoxButtons.OK);
                dptNgayKetThuc.Focus();
                return;
            }
            if(DateTime.Compare(Convert.ToDateTime(ngayKetThuc), DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày kết thúc không được lớn hơn hiện tại", "", MessageBoxButtons.OK);
                dptNgayKetThuc.Focus();
                return;
            }
            if(DateTime.Compare(Convert.ToDateTime(ngayBatDau), Convert.ToDateTime(ngayKetThuc)) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "", MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
            }
            String type = "";
            if (cmbPhieu.SelectedIndex == 0) 
            {
                type = "N";
            }
            else
            {
                type = "X";
            }
            if (Program.mGroup == "CONGTY")
            {
                String con = "";
                if (Program.mChiNhanh == 0)
                {
                    con = Program.connstr_window_mode1;
                }
                else
                {
                    con = Program.connstr_window_mode2;
                }
                String cmd = "EXEC sp_addsrvrolemember " + "'" + Program.mlogin + "'" + ", 'sysadmin'";
                Program.ExecSqlNonQueryadd(cmd, con);
                Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1 rpt = new Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1(Program.mGroup, type, Convert.ToDateTime(dptNgayBatDau.EditValue), Convert.ToDateTime(dptNgayKetThuc.EditValue));
                rpt.labelTieuDe.Text = "CHI TIẾT SỐ LƯỢNG TRỊ GIÁ " + cmbPhieu.SelectedItem.ToString().ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
                cmd = "EXEC sp_dropsrvrolemember " + "'" + Program.mlogin + "'" + ", 'sysadmin'";
                Program.ExecSqlNonQueryadd(cmd, con);
            }
            else
            {
                Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1 rpt = new Xrpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA1(Program.mGroup, type, Convert.ToDateTime(dptNgayBatDau.EditValue), Convert.ToDateTime(dptNgayKetThuc.EditValue));
                rpt.labelTieuDe.Text = "CHI TIẾT SỐ LƯỢNG TRỊ GIÁ " + cmbPhieu.SelectedItem.ToString().ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }           
        }
    }
}
