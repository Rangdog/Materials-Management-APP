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
    public partial class Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH : Form
    {
        public Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH()
        {
            InitializeComponent();
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
            Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH rpt = new Xrpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH(Convert.ToDateTime(dptNgayBatDau.EditValue),Convert.ToDateTime(dptNgayKetThuc.EditValue));
            rpt.lblSubTieuDe.Text = "TỪ NGÀY " + dptNgayBatDau.EditValue.ToString() + " ĐẾN NGÀY " + dptNgayKetThuc.EditValue.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
