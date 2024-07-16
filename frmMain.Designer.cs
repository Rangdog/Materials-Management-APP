
namespace QLVT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietSoLuongTriGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnLietKeCaDDHChuaCoPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoHoatDongNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLapPhieu = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnNhanVien,
            this.btnVatTu,
            this.btnKho,
            this.btnDonHang,
            this.btnChiTietSoLuongTriGia,
            this.btnLietKeCaDDHChuaCoPhieuNhap,
            this.btnTongHopNhapXuat,
            this.barSubItem2,
            this.btnPhieuNhap,
            this.btnPhieuXuat,
            this.btnDanhSachNhanVien,
            this.btnDanhSachVatTu,
            this.btnBaoCaoHoatDongNhanVien});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHeThong,
            this.ribDanhMuc,
            this.ribBaoCao,
            this.ribNghiepVu});
            this.ribbon.Size = new System.Drawing.Size(1179, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 3;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 4;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 6;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật Tư";
            this.btnVatTu.Id = 7;
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 8;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Caption = "Đơn Hàng";
            this.btnDonHang.Id = 9;
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonHang_ItemClick);
            // 
            // btnChiTietSoLuongTriGia
            // 
            this.btnChiTietSoLuongTriGia.Caption = "Chi Tiết Số Lượng Trị Giá";
            this.btnChiTietSoLuongTriGia.Id = 11;
            this.btnChiTietSoLuongTriGia.Name = "btnChiTietSoLuongTriGia";
            this.btnChiTietSoLuongTriGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietSoLuongTriGia_ItemClick);
            // 
            // btnLietKeCaDDHChuaCoPhieuNhap
            // 
            this.btnLietKeCaDDHChuaCoPhieuNhap.Caption = "Liệt Kê Các Đơn Đặt Hàng Có Phiếu Nhập";
            this.btnLietKeCaDDHChuaCoPhieuNhap.Id = 12;
            this.btnLietKeCaDDHChuaCoPhieuNhap.Name = "btnLietKeCaDDHChuaCoPhieuNhap";
            this.btnLietKeCaDDHChuaCoPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLietKeCaDDHChuaCoPhieuNhap_ItemClick);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "Tổng Hợp Nhập Xuất";
            this.btnTongHopNhapXuat.Id = 13;
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongHopNhapXuat_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Lập Phiếu";
            this.barSubItem2.Id = 18;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuXuat)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu Nhập";
            this.btnPhieuNhap.Id = 19;
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu Xuất";
            this.btnPhieuXuat.Id = 20;
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Caption = "Danh Sách Nhân Viên";
            this.btnDanhSachNhanVien.Id = 21;
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachNhanVien_ItemClick);
            // 
            // btnDanhSachVatTu
            // 
            this.btnDanhSachVatTu.Caption = "Danh Sách Vật Tư";
            this.btnDanhSachVatTu.Id = 22;
            this.btnDanhSachVatTu.Name = "btnDanhSachVatTu";
            this.btnDanhSachVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachVatTu_ItemClick);
            // 
            // btnBaoCaoHoatDongNhanVien
            // 
            this.btnBaoCaoHoatDongNhanVien.Caption = "Báo Cáo Hoạt Động Nhân Viên";
            this.btnBaoCaoHoatDongNhanVien.Id = 23;
            this.btnBaoCaoHoatDongNhanVien.Name = "btnBaoCaoHoatDongNhanVien";
            this.btnBaoCaoHoatDongNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoHoatDongNhanVien_ItemClick);
            // 
            // ribHeThong
            // 
            this.ribHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribHeThong.Name = "ribHeThong";
            this.ribHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "Danh Mục";
            this.ribDanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDonHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribBaoCao
            // 
            this.ribBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.ribBaoCao.Name = "ribBaoCao";
            this.ribBaoCao.Text = "Báo Cáo";
            this.ribBaoCao.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnChiTietSoLuongTriGia);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnLietKeCaDDHChuaCoPhieuNhap);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTongHopNhapXuat);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDanhSachNhanVien);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnDanhSachVatTu);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.btnBaoCaoHoatDongNhanVien);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.Text = "ribbonPageGroup13";
            // 
            // ribNghiepVu
            // 
            this.ribNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribNghiepVu.Name = "ribNghiepVu";
            this.ribNghiepVu.Text = "Nghiệp Vụ";
            this.ribNghiepVu.Visible = false;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barSubItem2);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 452);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1179, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1179, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(52, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Caption = "Lập Phiếu";
            this.btnLapPhieu.Id = 7;
            this.btnLapPhieu.Name = "btnLapPhieu";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnLapPhieu);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup5";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Lập Phiếu";
            this.barSubItem1.Id = 7;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDonHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnChiTietSoLuongTriGia;
        private DevExpress.XtraBars.BarButtonItem btnLietKeCaDDHChuaCoPhieuNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarSubItem btnLapPhieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachVatTu;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoHoatDongNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribNghiepVu;
    }
}