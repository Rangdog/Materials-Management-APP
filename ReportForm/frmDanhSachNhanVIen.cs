using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using System.IO;

namespace QLVT.ReportForm
{
    public partial class frmDanhSachNhanVIen : Form
    {
        String maChiNhanh = "";
        public frmDanhSachNhanVIen()
        {
            InitializeComponent();
        }


        private void frmDanhSachNhanVIen_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NhanVienTableAdapter.Fill(this.DS.NhanVien);
            maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if(Program.mGroup == "CONGTY")
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
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.DS.NhanVien);          
                maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            xrptDanhSachNhanVien report = new xrptDanhSachNhanVien();
            report.txtMaCN.Text = maChiNhanh;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                xrptDanhSachNhanVien report = new xrptDanhSachNhanVien();
                report.txtMaCN.Text = maChiNhanh;
                if (File.Exists(@"D:\QLVTProject\Report\xrptDanhSachNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File xrptDanhSachNhanVien.pdf tại thư mục đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\QLVTProject\Report\xrptDanhSachNhanVien.pdf");
                        MessageBox.Show("File xrptDanhSachNhanVien.pdf đã được ghi thành công tại ổ thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    report.ExportToPdf(@"D:\QLVTProject\Report\xrptDanhSachNhanVien.pdf");
                    MessageBox.Show("File xrptDanhSachNhanVien.pdf đã được ghi thành công tại thư mục Report",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file xrptDanhSachNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
