
namespace QLVT
{
    partial class Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH
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
            this.lbtl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dptNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dptNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtl
            // 
            this.lbtl.AutoSize = true;
            this.lbtl.Location = new System.Drawing.Point(241, 151);
            this.lbtl.Name = "lbtl";
            this.lbtl.Size = new System.Drawing.Size(101, 19);
            this.lbtl.TabIndex = 0;
            this.lbtl.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Kết Thúc:";
            // 
            // dptNgayBatDau
            // 
            this.dptNgayBatDau.EditValue = null;
            this.dptNgayBatDau.Location = new System.Drawing.Point(364, 151);
            this.dptNgayBatDau.Name = "dptNgayBatDau";
            this.dptNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayBatDau.Size = new System.Drawing.Size(125, 22);
            this.dptNgayBatDau.TabIndex = 2;
            // 
            // dptNgayKetThuc
            // 
            this.dptNgayKetThuc.EditValue = null;
            this.dptNgayKetThuc.Location = new System.Drawing.Point(697, 148);
            this.dptNgayKetThuc.Name = "dptNgayKetThuc";
            this.dptNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayKetThuc.Size = new System.Drawing.Size(125, 22);
            this.dptNgayKetThuc.TabIndex = 3;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(465, 277);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(145, 38);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 453);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dptNgayKetThuc);
            this.Controls.Add(this.dptNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH";
            this.Text = "Frpt_SP_TONG_HOP_NHAP_XUAT_FOR_CHI_NHANH";
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtl;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dptNgayBatDau;
        private DevExpress.XtraEditors.DateEdit dptNgayKetThuc;
        private System.Windows.Forms.Button btnPreview;
    }
}