
namespace QLVT
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.pnlChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.PhieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.btnChonChiTietDonHang = new System.Windows.Forms.Button();
            this.txtDonGiaCTPN = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuongCTPN = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVTCTPN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            mAPNLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChiNhanh)).BeginInit();
            this.pnlChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVTCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(10, 60);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(103, 17);
            mAPNLabel.TabIndex = 46;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(295, 336);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(61, 17);
            dONGIALabel.TabIndex = 43;
            dONGIALabel.Text = "Đơn Giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(3, 336);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(73, 17);
            sOLUONGLabel.TabIndex = 42;
            sOLUONGLabel.Text = "Số Lượng:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(5, 286);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(75, 17);
            mAVTLabel.TabIndex = 41;
            mAVTLabel.Text = "Mã Vật Tư:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(5, 242);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(122, 17);
            masoDDHLabel.TabIndex = 40;
            masoDDHLabel.Text = "Mã Đơn Đặt Hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(10, 99);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(95, 17);
            mANVLabel.TabIndex = 36;
            mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(10, 145);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 35;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(295, 58);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 34;
            nGAYLabel.Text = "Ngày:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac,
            this.btnLamMoi,
            this.btnCHUYENCHINHANH,
            this.btnThoat,
            this.btnThemChiTietDonDatHang,
            this.btnMenu,
            this.btnCheDoPhieuNhap,
            this.btnCheDoChiTietPhieuNhap});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMenu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Chọn Chế Độ";
            this.btnMenu.Id = 8;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoPhieuNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietPhieuNhap)});
            this.btnMenu.Name = "btnMenu";
            // 
            // btnCheDoPhieuNhap
            // 
            this.btnCheDoPhieuNhap.Caption = "Phiếu Nhập";
            this.btnCheDoPhieuNhap.Id = 9;
            this.btnCheDoPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoPhieuNhap.ImageOptions.SvgImage")));
            this.btnCheDoPhieuNhap.Name = "btnCheDoPhieuNhap";
            this.btnCheDoPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoPhieuNhap_ItemClick);
            // 
            // btnCheDoChiTietPhieuNhap
            // 
            this.btnCheDoChiTietPhieuNhap.Caption = "Chi Tiết Phiếu Nhập";
            this.btnCheDoChiTietPhieuNhap.Id = 10;
            this.btnCheDoChiTietPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoChiTietPhieuNhap.ImageOptions.SvgImage")));
            this.btnCheDoChiTietPhieuNhap.Name = "btnCheDoChiTietPhieuNhap";
            this.btnCheDoChiTietPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoChiTietPhieuNhap_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 0);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 0);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(70, 0);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn Tác";
            this.btnHoanTac.Enabled = false;
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Enabled = false;
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1249, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 617);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1249, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1249, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // btnThemChiTietDonDatHang
            // 
            this.btnThemChiTietDonDatHang.Caption = "Thêm Chi Tiết Đơn Đặt Hàng";
            this.btnThemChiTietDonDatHang.Id = 7;
            this.btnThemChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnThemChiTietDonDatHang.Name = "btnThemChiTietDonDatHang";
            // 
            // pnlChiNhanh
            // 
            this.pnlChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pnlChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pnlChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChiNhanh.Location = new System.Drawing.Point(0, 30);
            this.pnlChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChiNhanh.Name = "pnlChiNhanh";
            this.pnlChiNhanh.Size = new System.Drawing.Size(1249, 56);
            this.pnlChiNhanh.TabIndex = 7;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(133, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(347, 28);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(31, 17);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(89, 21);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi Nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // PhieuNhapTableAdapter
            // 
            this.PhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.PhieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 86);
            this.gcPhieuNhap.MainView = this.gridView1;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1249, 220);
            this.gcPhieuNhap.TabIndex = 8;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPhieuNhap;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.Controls.Add(mAPNLabel);
            this.pnlNhapLieu.Controls.Add(this.txtMaPN);
            this.pnlNhapLieu.Controls.Add(this.btnChonChiTietDonHang);
            this.pnlNhapLieu.Controls.Add(dONGIALabel);
            this.pnlNhapLieu.Controls.Add(this.txtDonGiaCTPN);
            this.pnlNhapLieu.Controls.Add(sOLUONGLabel);
            this.pnlNhapLieu.Controls.Add(this.txtSoLuongCTPN);
            this.pnlNhapLieu.Controls.Add(mAVTLabel);
            this.pnlNhapLieu.Controls.Add(this.txtMaVTCTPN);
            this.pnlNhapLieu.Controls.Add(masoDDHLabel);
            this.pnlNhapLieu.Controls.Add(this.txtMaDDH);
            this.pnlNhapLieu.Controls.Add(this.btnChonDonHang);
            this.pnlNhapLieu.Controls.Add(this.label2);
            this.pnlNhapLieu.Controls.Add(this.separatorControl1);
            this.pnlNhapLieu.Controls.Add(mANVLabel);
            this.pnlNhapLieu.Controls.Add(this.txtMaNV);
            this.pnlNhapLieu.Controls.Add(mAKHOLabel);
            this.pnlNhapLieu.Controls.Add(this.txtMaKho);
            this.pnlNhapLieu.Controls.Add(nGAYLabel);
            this.pnlNhapLieu.Controls.Add(this.dteNgay);
            this.pnlNhapLieu.Controls.Add(this.label1);
            this.pnlNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNhapLieu.Location = new System.Drawing.Point(0, 306);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(542, 311);
            this.pnlNhapLieu.TabIndex = 9;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(131, 55);
            this.txtMaPN.MenuManager = this.barManager1;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaPN.TabIndex = 47;
            // 
            // btnChonChiTietDonHang
            // 
            this.btnChonChiTietDonHang.Enabled = false;
            this.btnChonChiTietDonHang.Location = new System.Drawing.Point(298, 242);
            this.btnChonChiTietDonHang.Name = "btnChonChiTietDonHang";
            this.btnChonChiTietDonHang.Size = new System.Drawing.Size(211, 48);
            this.btnChonChiTietDonHang.TabIndex = 46;
            this.btnChonChiTietDonHang.Text = "Chọn Chi Tiết Đơn Hàng";
            this.btnChonChiTietDonHang.UseVisualStyleBackColor = true;
            this.btnChonChiTietDonHang.Click += new System.EventHandler(this.btnChonChiTietDonHang_Click);
            // 
            // txtDonGiaCTPN
            // 
            this.txtDonGiaCTPN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGiaCTPN.Location = new System.Drawing.Point(362, 329);
            this.txtDonGiaCTPN.MenuManager = this.barManager1;
            this.txtDonGiaCTPN.Name = "txtDonGiaCTPN";
            this.txtDonGiaCTPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGiaCTPN.Size = new System.Drawing.Size(147, 24);
            this.txtDonGiaCTPN.TabIndex = 44;
            // 
            // txtSoLuongCTPN
            // 
            this.txtSoLuongCTPN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongCTPN.Location = new System.Drawing.Point(131, 332);
            this.txtSoLuongCTPN.MenuManager = this.barManager1;
            this.txtSoLuongCTPN.Name = "txtSoLuongCTPN";
            this.txtSoLuongCTPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongCTPN.Size = new System.Drawing.Size(125, 24);
            this.txtSoLuongCTPN.TabIndex = 43;
            // 
            // txtMaVTCTPN
            // 
            this.txtMaVTCTPN.Location = new System.Drawing.Point(131, 283);
            this.txtMaVTCTPN.MenuManager = this.barManager1;
            this.txtMaVTCTPN.Name = "txtMaVTCTPN";
            this.txtMaVTCTPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaVTCTPN.TabIndex = 42;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.Location = new System.Drawing.Point(133, 239);
            this.txtMaDDH.MenuManager = this.barManager1;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(125, 22);
            this.txtMaDDH.TabIndex = 41;
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Enabled = false;
            this.btnChonDonHang.Location = new System.Drawing.Point(298, 114);
            this.btnChonDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(211, 48);
            this.btnChonDonHang.TabIndex = 40;
            this.btnChonDonHang.Text = "Chọn Đơn Hàng";
            this.btnChonDonHang.UseVisualStyleBackColor = true;
            this.btnChonDonHang.Click += new System.EventHandler(this.btnChonDonHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 170);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(519, 23);
            this.separatorControl1.TabIndex = 38;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 96);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(125, 22);
            this.txtMaNV.TabIndex = 37;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(131, 142);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(125, 22);
            this.txtMaKho.TabIndex = 36;
            // 
            // dteNgay
            // 
            this.dteNgay.EditValue = null;
            this.dteNgay.Location = new System.Drawing.Point(360, 53);
            this.dteNgay.MenuManager = this.barManager1;
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Size = new System.Drawing.Size(149, 22);
            this.dteNgay.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Phiếu Nhập";
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.DataSource = this.bdsCTPN;
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(542, 306);
            this.gcChiTietPhieuNhap.MainView = this.gridView2;
            this.gcChiTietPhieuNhap.MenuManager = this.barManager1;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(707, 311);
            this.gcChiTietPhieuNhap.TabIndex = 9;
            this.gcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG});
            this.gridView2.GridControl = this.gcChiTietPhieuNhap;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 637);
            this.Controls.Add(this.gcChiTietPhieuNhap);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.pnlChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChiNhanh)).EndInit();
            this.pnlChiNhanh.ResumeLayout(false);
            this.pnlChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVTCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        public DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnCheDoPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl pnlChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private DSTableAdapters.PhieuNhapTableAdapter PhieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnlNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private System.Windows.Forms.Button btnChonChiTietDonHang;
        private DevExpress.XtraEditors.SpinEdit txtDonGiaCTPN;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongCTPN;
        private DevExpress.XtraEditors.TextEdit txtMaVTCTPN;
        private DevExpress.XtraEditors.TextEdit txtMaDDH;
        private System.Windows.Forms.Button btnChonDonHang;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
    }
}