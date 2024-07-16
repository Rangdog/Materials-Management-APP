
namespace QLVT
{
    partial class Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY
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
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.ctddhTableAdapter1 = new QLVT.DSDHTableAdapters.CTDDHTableAdapter();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dptNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.dptNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtl = new System.Windows.Forms.Label();
            this.ckTatCa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(390, 89);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(491, 27);
            this.cmbChiNhanh.TabIndex = 3;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(300, 92);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(76, 19);
            this.lblChiNhanh.TabIndex = 2;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // ctddhTableAdapter1
            // 
            this.ctddhTableAdapter1.ClearBeforeFill = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(524, 307);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(145, 38);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dptNgayKetThuc
            // 
            this.dptNgayKetThuc.EditValue = null;
            this.dptNgayKetThuc.Location = new System.Drawing.Point(756, 178);
            this.dptNgayKetThuc.Name = "dptNgayKetThuc";
            this.dptNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Size = new System.Drawing.Size(125, 22);
            this.dptNgayKetThuc.TabIndex = 8;
            // 
            // dptNgayBatDau
            // 
            this.dptNgayBatDau.EditValue = null;
            this.dptNgayBatDau.Location = new System.Drawing.Point(423, 181);
            this.dptNgayBatDau.Name = "dptNgayBatDau";
            this.dptNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Size = new System.Drawing.Size(125, 22);
            this.dptNgayBatDau.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày Kết Thúc:";
            // 
            // lbtl
            // 
            this.lbtl.AutoSize = true;
            this.lbtl.Location = new System.Drawing.Point(300, 181);
            this.lbtl.Name = "lbtl";
            this.lbtl.Size = new System.Drawing.Size(101, 19);
            this.lbtl.TabIndex = 5;
            this.lbtl.Text = "Ngày bắt đầu:";
            // 
            // ckTatCa
            // 
            this.ckTatCa.AutoSize = true;
            this.ckTatCa.Location = new System.Drawing.Point(390, 141);
            this.ckTatCa.Name = "ckTatCa";
            this.ckTatCa.Size = new System.Drawing.Size(18, 17);
            this.ckTatCa.TabIndex = 10;
            this.ckTatCa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tất cả";
            // 
            // Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckTatCa);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dptNgayKetThuc);
            this.Controls.Add(this.dptNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtl);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.lblChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY";
            this.Text = "Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY";
            this.Load += new System.EventHandler(this.Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CONG_TY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private DSDHTableAdapters.CTDDHTableAdapter ctddhTableAdapter1;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit dptNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit dptNgayBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtl;
        private System.Windows.Forms.CheckBox ckTatCa;
        private System.Windows.Forms.Label label1;
    }
}