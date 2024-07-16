using DevExpress.XtraBars;
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
using QLVT.ReportForm;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
 
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
     
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã NV : " + Program.username;
            HOTEN.Text = "Họ tên : " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
        }


        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmNhanVien f = new FrmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDonHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDonHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDonHang f = new frmDonHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.conn.Close();
                ribDanhMuc.Visible = false;
                ribBaoCao.Visible = false;
                ribNghiepVu.Visible = false;
                foreach (Form f in this.MdiChildren)
                    f.Close();
                Program.frmChinh.btnDangXuat.Enabled = Program.frmChinh.btnTaoTaiKhoan.Enabled = false;
                MANV.Text = "Mã NV : ";
                HOTEN.Text = "Họ tên : ";
                NHOM.Text = "Nhóm: ";
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChiTietSoLuongTriGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA));
            if (frm != null) frm.Activate();
            else
            {
                frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA f = new frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLietKeCaDDHChuaCoPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Program.mGroup  == "CONGTY")
            {
                Form frm = this.CheckExists(typeof(Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY));
                if (frm != null) frm.Activate();
                else
                {
                    Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY f = new Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FOR_CHINHANH rpt = new Xrpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FOR_CHINHANH();
                rpt.lblSubTieuDe.Text = "Chi Nhanh" + (Program.mChiNhanh+1).ToString();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                Form frm = this.CheckExists(typeof(Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH));
                if (frm != null) frm.Activate();
                else
                {
                    Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH f = new Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                Form frm = this.CheckExists(typeof(Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY));
                if (frm != null) frm.Activate();
                else
                {
                    Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY f = new Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            
        }

        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhieuXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPhieuXuat form = new frmPhieuXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPhieuNhap form = new frmPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDanhSachNhanVIen));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDanhSachNhanVIen form = new frmDanhSachNhanVIen();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDanhSachVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDanhSachVatTu form = new frmDanhSachVatTu();
                form.Show();
            }
        }

        private void btnBaoCaoHoatDongNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmHoatDongNhanVien form = new frmHoatDongNhanVien();
                form.Show();
            }
        }
    }
}