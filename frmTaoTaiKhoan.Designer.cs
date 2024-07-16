
namespace QLVT
{
    partial class frmTaoTaiKhoan
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
            this.dSDH = new QLVT.DSDH();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.dSNVTableAdapter = new QLVT.DSDHTableAdapters.DSNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSDHTableAdapters.TableAdapterManager();
            this.cmbHoTenNV = new System.Windows.Forms.ComboBox();
            this.bdsNhanVienChuaLapTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nhanVienChuaLapTKTableAdapter = new QLVT.DSDHTableAdapters.NhanVienChuaLapTKTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienChuaLapTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(438, 231);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(81, 19);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // dSDH
            // 
            this.dSDH.DataSetName = "DSDH";
            this.dSDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dSDH;
            // 
            // dSNVTableAdapter
            // 
            this.dSNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSDHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cmbHoTenNV
            // 
            this.cmbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "HOTEN", true));
            this.cmbHoTenNV.DataSource = this.bdsNhanVienChuaLapTaiKhoan;
            this.cmbHoTenNV.DisplayMember = "HOTEN";
            this.cmbHoTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTenNV.FormattingEnabled = true;
            this.cmbHoTenNV.Location = new System.Drawing.Point(561, 223);
            this.cmbHoTenNV.Name = "cmbHoTenNV";
            this.cmbHoTenNV.Size = new System.Drawing.Size(261, 27);
            this.cmbHoTenNV.TabIndex = 5;
            this.cmbHoTenNV.ValueMember = "MANV";
            // 
            // bdsNhanVienChuaLapTaiKhoan
            // 
            this.bdsNhanVienChuaLapTaiKhoan.DataMember = "NhanVienChuaLapTK";
            this.bdsNhanVienChuaLapTaiKhoan.DataSource = this.dSDH;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(561, 294);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(261, 27);
            this.cmbRole.TabIndex = 7;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(561, 110);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(261, 27);
            this.txtTenTaiKhoan.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(561, 167);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(261, 27);
            this.txtMatKhau.TabIndex = 9;
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(416, 375);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(133, 52);
            this.btnTaoTaiKhoan.TabIndex = 10;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(742, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // nhanVienChuaLapTKTableAdapter
            // 
            this.nhanVienChuaLapTKTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.lblChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1353, 58);
            this.panelControl1.TabIndex = 12;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(112, 18);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(390, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(22, 21);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 580);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.cmbHoTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienChuaLapTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DSDH dSDH;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DSDHTableAdapters.DSNVTableAdapter dSNVTableAdapter;
        private DSDHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource bdsNhanVienChuaLapTaiKhoan;
        private DSDHTableAdapters.NhanVienChuaLapTKTableAdapter nhanVienChuaLapTKTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
    }
}