
namespace QLVT
{
    partial class frmDonHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENKHOLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.dSDH = new QLVT.DSDH();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSDHTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSDHTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT.DSDHTableAdapters.CTDDHTableAdapter();
            this.gcDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHoten = new System.Windows.Forms.ComboBox();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.dptNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMSDDH = new DevExpress.XtraEditors.TextEdit();
            this.dSNVTableAdapter = new QLVT.DSDHTableAdapters.DSNVTableAdapter();
            this.dSKHOTableAdapter = new QLVT.DSDHTableAdapters.DSKHOTableAdapter();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsThemVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsReload = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSDHTableAdapters.PhieuNhapTableAdapter();
            this.vattuTableAdapter = new QLVT.DSDHTableAdapters.VattuTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.bdsSPVTKCTCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.sP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter = new QLVT.DSDHTableAdapters.SP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPVTKCTCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(30, 24);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(130, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số đơn đặt hàng";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(798, 30);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(30, 538);
            nhaCCLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(93, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(765, 144);
            mANVLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(89, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(919, 350);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(57, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(30, 155);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(49, 17);
            hOTENLabel.TabIndex = 10;
            hOTENLabel.Text = "Họ tên";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(62, 351);
            tENKHOLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(59, 17);
            tENKHOLabel.TabIndex = 12;
            tENKHOLabel.Text = "Tên Kho";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1251, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 762);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1251, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1251, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 715);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.lblChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 47);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1251, 164);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(320, 50);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(8);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(1102, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(62, 60);
            this.lblChiNhanh.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // dSDH
            // 
            this.dSDH.DataSetName = "DSDH";
            this.dSDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.dSDH;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSDHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcDatHang
            // 
            this.gcDatHang.DataSource = this.bdsDatHang;
            this.gcDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDatHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gcDatHang.Location = new System.Drawing.Point(0, 211);
            this.gcDatHang.MainView = this.gridView1;
            this.gcDatHang.Margin = new System.Windows.Forms.Padding(8);
            this.gcDatHang.MenuManager = this.barManager1;
            this.gcDatHang.Name = "gcDatHang";
            this.gcDatHang.Size = new System.Drawing.Size(1251, 198);
            this.gcDatHang.TabIndex = 6;
            this.gcDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.DetailHeight = 404;
            this.gridView1.GridControl = this.gcDatHang;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 87;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 23;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 87;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 23;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 87;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 87;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 23;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 87;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(tENKHOLabel);
            this.panelControl2.Controls.Add(this.cmbTenKho);
            this.panelControl2.Controls.Add(hOTENLabel);
            this.panelControl2.Controls.Add(this.cmbHoten);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(this.txtMAKHO);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txtMANV);
            this.panelControl2.Controls.Add(nhaCCLabel);
            this.panelControl2.Controls.Add(this.txtNhaCC);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.dptNgay);
            this.panelControl2.Controls.Add(masoDDHLabel);
            this.panelControl2.Controls.Add(this.txtMSDDH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 409);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(917, 353);
            this.panelControl2.TabIndex = 7;
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSKHO, "TENKHO", true));
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDatHang, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bdsDSKHO;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(352, 342);
            this.cmbTenKho.Margin = new System.Windows.Forms.Padding(8);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(465, 24);
            this.cmbTenKho.TabIndex = 13;
            this.cmbTenKho.ValueMember = "MAKHO";
            this.cmbTenKho.SelectedIndexChanged += new System.EventHandler(this.cmbTenKho_SelectedIndexChanged);
            // 
            // bdsDSKHO
            // 
            this.bdsDSKHO.DataMember = "DSKHO";
            this.bdsDSKHO.DataSource = this.dSDH;
            // 
            // cmbHoten
            // 
            this.cmbHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "HOTEN", true));
            this.cmbHoten.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDatHang, "MANV", true));
            this.cmbHoten.DataSource = this.bdsDSNV;
            this.cmbHoten.DisplayMember = "HOTEN";
            this.cmbHoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoten.FormattingEnabled = true;
            this.cmbHoten.Location = new System.Drawing.Point(211, 144);
            this.cmbHoten.Margin = new System.Windows.Forms.Padding(8);
            this.cmbHoten.Name = "cmbHoten";
            this.cmbHoten.Size = new System.Drawing.Size(455, 24);
            this.cmbHoten.TabIndex = 11;
            this.cmbHoten.ValueMember = "MANV";
            this.cmbHoten.SelectedIndexChanged += new System.EventHandler(this.cmbHoten_SelectedIndexChanged);
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dSDH;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(1144, 344);
            this.txtMAKHO.Margin = new System.Windows.Forms.Padding(8);
            this.txtMAKHO.MenuManager = this.barManager1;
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(244, 22);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(1019, 138);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(8);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(244, 22);
            this.txtMANV.TabIndex = 7;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(282, 530);
            this.txtNhaCC.Margin = new System.Windows.Forms.Padding(8);
            this.txtNhaCC.MenuManager = this.barManager1;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(601, 22);
            this.txtNhaCC.TabIndex = 5;
            // 
            // dptNgay
            // 
            this.dptNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NGAY", true));
            this.dptNgay.EditValue = null;
            this.dptNgay.Location = new System.Drawing.Point(925, 22);
            this.dptNgay.Margin = new System.Windows.Forms.Padding(8);
            this.dptNgay.MenuManager = this.barManager1;
            this.dptNgay.Name = "dptNgay";
            this.dptNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgay.Size = new System.Drawing.Size(244, 22);
            this.dptNgay.TabIndex = 3;
            // 
            // txtMSDDH
            // 
            this.txtMSDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MasoDDH", true));
            this.txtMSDDH.Location = new System.Drawing.Point(361, 22);
            this.txtMSDDH.Margin = new System.Windows.Forms.Padding(8);
            this.txtMSDDH.MenuManager = this.barManager1;
            this.txtMSDDH.Name = "txtMSDDH";
            this.txtMSDDH.Size = new System.Drawing.Size(244, 22);
            this.txtMSDDH.TabIndex = 1;
            // 
            // dSNVTableAdapter
            // 
            this.dSNVTableAdapter.ClearBeforeFill = true;
            // 
            // dSKHOTableAdapter
            // 
            this.dSKHOTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.dSDH;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsThemVatTu,
            this.tmsXoa,
            this.tmsGhi,
            this.tmsPhucHoi,
            this.tmsReload});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 124);
            // 
            // tmsThemVatTu
            // 
            this.tmsThemVatTu.Name = "tmsThemVatTu";
            this.tmsThemVatTu.Size = new System.Drawing.Size(157, 24);
            this.tmsThemVatTu.Text = "Thêm vật tư";
            this.tmsThemVatTu.Click += new System.EventHandler(this.tmsThemVatTu_Click);
            // 
            // tmsXoa
            // 
            this.tmsXoa.Name = "tmsXoa";
            this.tmsXoa.Size = new System.Drawing.Size(157, 24);
            this.tmsXoa.Text = "Xóa vật tư";
            this.tmsXoa.Click += new System.EventHandler(this.tmsXoa_Click);
            // 
            // tmsGhi
            // 
            this.tmsGhi.Name = "tmsGhi";
            this.tmsGhi.Size = new System.Drawing.Size(157, 24);
            this.tmsGhi.Text = "Ghi";
            this.tmsGhi.Click += new System.EventHandler(this.tmsiGhi_Click);
            // 
            // tmsPhucHoi
            // 
            this.tmsPhucHoi.Name = "tmsPhucHoi";
            this.tmsPhucHoi.Size = new System.Drawing.Size(157, 24);
            this.tmsPhucHoi.Text = "Phục hồi";
            this.tmsPhucHoi.Click += new System.EventHandler(this.tmsPhucHoi_Click);
            // 
            // tmsReload
            // 
            this.tmsReload.Name = "tmsReload";
            this.tmsReload.Size = new System.Drawing.Size(157, 24);
            this.tmsReload.Text = "Reload";
            this.tmsReload.Click += new System.EventHandler(this.tmsReload_Click);
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPhieuNhap.DataSource = this.bdsDatHang;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
            // 
            // cTDDHDataGridView
            // 
            this.cTDDHDataGridView.AllowUserToAddRows = false;
            this.cTDDHDataGridView.AllowUserToDeleteRows = false;
            this.cTDDHDataGridView.AutoGenerateColumns = false;
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MAVT,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cTDDHDataGridView.DataSource = this.bdsCTDDH;
            this.cTDDHDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTDDHDataGridView.Location = new System.Drawing.Point(917, 409);
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.RowHeadersWidth = 51;
            this.cTDDHDataGridView.RowTemplate.Height = 24;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(334, 353);
            this.cTDDHDataGridView.TabIndex = 11;
            // 
            // bdsSPVTKCTCTDDH
            // 
            this.bdsSPVTKCTCTDDH.DataMember = "SP_VAT_TU_KHONG_CO_TRONG_CTDDH";
            this.bdsSPVTKCTCTDDH.DataSource = this.dSDH;
            // 
            // sP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter
            // 
            this.sP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số Đơn Đặt Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // MAVT
            // 
            this.MAVT.DataPropertyName = "MAVT";
            this.MAVT.DataSource = this.bdsVatTu;
            this.MAVT.DisplayMember = "TENVT";
            this.MAVT.HeaderText = "Mã Vật Tư";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ValueMember = "MAVT";
            this.MAVT.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 782);
            this.Controls.Add(this.cTDDHDataGridView);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDonHang";
            this.Text = "frmDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPVTKCTCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DSDH dSDH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private DSDHTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSDHTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private DevExpress.XtraEditors.DateEdit dptNgay;
        private DevExpress.XtraEditors.TextEdit txtMSDDH;
        private DevExpress.XtraGrid.GridControl gcDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DSDHTableAdapters.DSNVTableAdapter dSNVTableAdapter;
        private System.Windows.Forms.ComboBox cmbHoten;
        private System.Windows.Forms.BindingSource bdsDSKHO;
        private DSDHTableAdapters.DSKHOTableAdapter dSKHOTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private DSDHTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsThemVatTu;
        private System.Windows.Forms.ToolStripMenuItem tmsXoa;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSDHTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSDHTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private System.Windows.Forms.ToolStripMenuItem tmsPhucHoi;
        private System.Windows.Forms.ToolStripMenuItem tmsReload;
        private System.Windows.Forms.ToolStripMenuItem tmsGhi;
        private System.Windows.Forms.BindingSource bdsSPVTKCTCTDDH;
        private DSDHTableAdapters.SP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter sP_VAT_TU_KHONG_CO_TRONG_CTDDHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}