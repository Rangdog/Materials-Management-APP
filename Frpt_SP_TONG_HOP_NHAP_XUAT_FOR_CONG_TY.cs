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
    public partial class Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY : Form
    {
        public Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY()
        {
            InitializeComponent();
        }

        private void Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String ngayBatDau = dptNgayBatDau.EditValue.ToString();
            String ngayKetThuc = dptNgayKetThuc.EditValue.ToString();
            if (ngayBatDau.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được thiếu", "", MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(ngayBatDau), DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn hiện tại", "", MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
                return;
            }
            if (ngayKetThuc.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không được thiếu", "", MessageBoxButtons.OK);
                dptNgayKetThuc.Focus();
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(ngayKetThuc), DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày kết thúc không được lớn hơn hiện tại", "", MessageBoxButtons.OK);
                dptNgayKetThuc.Focus();
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(ngayBatDau), Convert.ToDateTime(ngayKetThuc)) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "", MessageBoxButtons.OK);
                dptNgayBatDau.Focus();
            }
            if (ckTatCa.Checked)
            {
                Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY rpt = new Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY(Convert.ToDateTime(dptNgayBatDau.EditValue), Convert.ToDateTime(dptNgayKetThuc.EditValue));
                rpt.lblSubTieuDe.Text = "TỪ NGÀY " + dptNgayBatDau.EditValue.ToString() + " ĐẾN NGÀY " + dptNgayKetThuc.EditValue.ToString();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else
            {
                Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH rpt = new Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH(Convert.ToDateTime(dptNgayBatDau.EditValue), Convert.ToDateTime(dptNgayKetThuc.EditValue));
                rpt.lblSubTieuDe.Text = "TỪ NGÀY " + dptNgayBatDau.EditValue.ToString() + " ĐẾN NGÀY " + dptNgayKetThuc.EditValue.ToString();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }

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
    }
}
