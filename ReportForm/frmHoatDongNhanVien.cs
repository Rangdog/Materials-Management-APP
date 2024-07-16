using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT.ReportForm
{
    public partial class frmHoatDongNhanVien : Form
    {
        String maChiNhanh = "";
        String maNV = "";
        public frmHoatDongNhanVien()
        {
            InitializeComponent();
        }

        

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
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
            }
            else
            {
                this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);
                maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            }
        }

        private void frmHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
            dteNgayLap.EditValue = DateTime.Now;

        }

      

        
        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            if (dteTuNgay.Text == "")
            {
                MessageBox.Show("Từ ngày không được để trống", "Thông báo", MessageBoxButtons.OK);
                dteTuNgay.Focus();
                return;
            }
            if (dteDenNgay.Text == "")
            {
                MessageBox.Show("Đến ngày không được để trống", "Thông báo", MessageBoxButtons.OK);
                dteTuNgay.Focus();
                return;
            }
            String maNV = cmbHoTen.SelectedValue.ToString();
            DateTime datefrom = dteTuNgay.DateTime;
            DateTime dateto = dteDenNgay.DateTime;
            
            xrpt_HoatDongNhanVien report = new xrpt_HoatDongNhanVien(maNV, datefrom, dateto);
            report.lblHoTen.Text = cmbHoTen.Text;
            report.lblTuNgay.Text = dteTuNgay.EditValue.ToString(); 
            report.lblDenNgay.Text = dteDenNgay.EditValue.ToString();
            report.lblNgayLap.Text = dteNgayLap.EditValue.ToString();
            
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String maNV = cmbHoTen.SelectedValue.ToString();
            DateTime datefrom = dteTuNgay.DateTime;
            DateTime dateto = dteDenNgay.DateTime;

            xrpt_HoatDongNhanVien report = new xrpt_HoatDongNhanVien(maNV, datefrom, dateto);
            report.lblHoTen.Text = cmbHoTen.Text;
            report.lblTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.lblDenNgay.Text = dteDenNgay.EditValue.ToString();
            report.lblNgayLap.Text = dteNgayLap.EditValue.ToString();

            try
            {
                if (File.Exists(@"D:\QLVTProject\Report\xrptHoatDongNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File xrptHoatDongNhanVien.pdf tại thư mục đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\QLVTProject\Report\xrptHoatDongNhanVien.pdf");
                        MessageBox.Show("File xrptHoatDongNhanVien.pdf đã được ghi thành công tại ổ thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    report.ExportToPdf(@"D:\QLVTProject\Report\xrptHoatDongNhanVien.pdf");
                    MessageBox.Show("File xrptDanhSachNhanVien.pdf đã được ghi thành công tại thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file xrptHoatDongNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }

}

