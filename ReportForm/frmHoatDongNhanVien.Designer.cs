
namespace QLVT.ReportForm
{
    partial class frmHoatDongNhanVien
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
            System.Windows.Forms.Label hOTENLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.dteNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.HOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(60, 234);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(139, 21);
            hOTENLabel.TabIndex = 17;
            hOTENLabel.Text = "Họ tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Location = new System.Drawing.Point(304, 154);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Size = new System.Drawing.Size(156, 22);
            this.dteTuNgay.TabIndex = 3;
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = null;
            this.dteDenNgay.Location = new System.Drawing.Point(626, 155);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Size = new System.Drawing.Size(156, 22);
            this.dteDenNgay.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày lập báo cáo:";
            // 
            // dteNgayLap
            // 
            this.dteNgayLap.EditValue = null;
            this.dteNgayLap.Enabled = false;
            this.dteNgayLap.Location = new System.Drawing.Point(209, 266);
            this.dteNgayLap.Name = "dteNgayLap";
            this.dteNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Size = new System.Drawing.Size(158, 22);
            this.dteNgayLap.TabIndex = 8;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Blue;
            this.btnIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(561, 340);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(128, 35);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.BackColor = System.Drawing.Color.Blue;
            this.btnXemTruoc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTruoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemTruoc.Location = new System.Drawing.Point(272, 340);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(121, 35);
            this.btnXemTruoc.TabIndex = 13;
            this.btnXemTruoc.Text = "XEM TRƯỚC";
            this.btnXemTruoc.UseVisualStyleBackColor = false;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.Location = new System.Drawing.Point(386, 94);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(331, 28);
            this.cmbChiNhanh.TabIndex = 15;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chi Nhánh:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HOTENNV";
            this.bdsHoTenNV.DataSource = this.DS;
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
//            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTenNV, "HOTEN", true));
            this.cmbHoTen.DataSource = this.bdsHoTenNV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(209, 231);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(313, 28);
            this.cmbHoTen.TabIndex = 18;
            this.cmbHoTen.ValueMember = "MANV";
            // 
            // frmHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 476);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.cmbHoTen);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXemTruoc);
            this.Controls.Add(this.dteNgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dteDenNgay);
            this.Controls.Add(this.dteTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoatDongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoạt Động Nhân Viên";
            this.Load += new System.EventHandler(this.frmHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.DateEdit dteDenNgay;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dteNgayLap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label6;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoTen;
    }
}