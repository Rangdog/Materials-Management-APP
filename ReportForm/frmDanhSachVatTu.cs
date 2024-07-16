using DevExpress.XtraReports.UI;
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


namespace QLVT.ReportForm
{
    public partial class frmDanhSachVatTu : Form
    {
        String maChiNhanh = "";
        public frmDanhSachVatTu()
        {
            InitializeComponent();
        }


        private void frmDanhSachVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);
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
                this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
                maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            xrptDanhSachVatTu report = new xrptDanhSachVatTu();
            report.txtMaCN.Text = maChiNhanh;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                xrptDanhSachVatTu report = new xrptDanhSachVatTu();
                report.txtMaCN.Text = maChiNhanh;
                if (File.Exists(@"D:\QLVTProject\Report\xrptDanhSachVatTu.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File xrptDanhSachVatTu.pdf tại thư mục đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\QLVTProject\Report\xrptDanhSachVatTu.pdf");
                        MessageBox.Show("File xrptDanhSachVatTu.pdf đã được ghi thành công tại ổ thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    report.ExportToPdf(@"D:\QLVTProject\Report\xrptDanhSachVatTu.pdf");
                    MessageBox.Show("File xrptDanhSachVatTu.pdf đã được ghi thành công tại thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file xrptDanhSachVatTu.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

        }
    }
    
}
