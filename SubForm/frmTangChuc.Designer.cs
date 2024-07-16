
namespace QLVT.SubForm
{
    partial class frmTangChuc
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
            this.cmbHoTenNV = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTangChuc = new System.Windows.Forms.Button();
            this.dS = new QLVT.DS();
            this.bdsNhanVienUser = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENUSERTableAdapter = new QLVT.DSTableAdapters.NHANVIENUSERTableAdapter();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienUser)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(293, 119);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(76, 17);
            hOTENLabel.TabIndex = 6;
            hOTENLabel.Text = "Nhân viên:";
            // 
            // cmbHoTenNV
            // 
            this.cmbHoTenNV.DataSource = this.bdsNhanVienUser;
            this.cmbHoTenNV.DisplayMember = "HOTEN";
            this.cmbHoTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTenNV.FormattingEnabled = true;
            this.cmbHoTenNV.Location = new System.Drawing.Point(416, 111);
            this.cmbHoTenNV.Name = "cmbHoTenNV";
            this.cmbHoTenNV.Size = new System.Drawing.Size(261, 24);
            this.cmbHoTenNV.TabIndex = 7;
            this.cmbHoTenNV.ValueMember = "MANV";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(576, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTangChuc
            // 
            this.btnTangChuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangChuc.Location = new System.Drawing.Point(218, 200);
            this.btnTangChuc.Name = "btnTangChuc";
            this.btnTangChuc.Size = new System.Drawing.Size(170, 50);
            this.btnTangChuc.TabIndex = 8;
            this.btnTangChuc.Text = "TĂNG CHỨC";
            this.btnTangChuc.UseVisualStyleBackColor = true;
            this.btnTangChuc.Click += new System.EventHandler(this.btnTangChuc_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVienUser
            // 
            this.bdsNhanVienUser.DataMember = "NHANVIENUSER";
            this.bdsNhanVienUser.DataSource = this.dS;
            // 
            // NHANVIENUSERTableAdapter
            // 
            this.NHANVIENUSERTableAdapter.ClearBeforeFill = true;
            // 
            // frmTangChuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTangChuc);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.cmbHoTenNV);
            this.Name = "frmTangChuc";
            this.Text = "frmTangChuc";
            this.Load += new System.EventHandler(this.frmTangChuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVienUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHoTenNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTangChuc;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNhanVienUser;
        private DSTableAdapters.NHANVIENUSERTableAdapter NHANVIENUSERTableAdapter;
    }
}