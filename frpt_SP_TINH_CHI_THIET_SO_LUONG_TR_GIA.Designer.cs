
namespace QLVT
{
    partial class frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dptNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dptNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu:";
            // 
            // cmbPhieu
            // 
            this.cmbPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhieu.FormattingEnabled = true;
            this.cmbPhieu.Items.AddRange(new object[] {
            "Phiếu Nhập",
            "Phiếu Xuất"});
            this.cmbPhieu.Location = new System.Drawing.Point(257, 152);
            this.cmbPhieu.Name = "cmbPhieu";
            this.cmbPhieu.Size = new System.Drawing.Size(189, 24);
            this.cmbPhieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // dptNgayBatDau
            // 
            this.dptNgayBatDau.EditValue = null;
            this.dptNgayBatDau.Location = new System.Drawing.Point(321, 214);
            this.dptNgayBatDau.Name = "dptNgayBatDau";
            this.dptNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Size = new System.Drawing.Size(125, 22);
            this.dptNgayBatDau.TabIndex = 4;
            // 
            // dptNgayKetThuc
            // 
            this.dptNgayKetThuc.EditValue = null;
            this.dptNgayKetThuc.Location = new System.Drawing.Point(621, 214);
            this.dptNgayKetThuc.Name = "dptNgayKetThuc";
            this.dptNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Size = new System.Drawing.Size(125, 22);
            this.dptNgayKetThuc.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(621, 115);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(125, 61);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 368);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dptNgayKetThuc);
            this.Controls.Add(this.dptNgayBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPhieu);
            this.Controls.Add(this.label1);
            this.Name = "frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA";
            this.Text = "frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA";
            this.Load += new System.EventHandler(this.frpt_SP_TINH_CHI_THIET_SO_LUONG_TR_GIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dptNgayBatDau;
        private DevExpress.XtraEditors.DateEdit dptNgayKetThuc;
        private System.Windows.Forms.Button btnPreview;
    }
}