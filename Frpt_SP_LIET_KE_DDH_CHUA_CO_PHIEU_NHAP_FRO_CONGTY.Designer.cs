
namespace QLVT
{
    partial class Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY
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
            this.ckTatCa = new System.Windows.Forms.CheckBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tất cả";
            // 
            // ckTatCa
            // 
            this.ckTatCa.AutoSize = true;
            this.ckTatCa.Location = new System.Drawing.Point(436, 213);
            this.ckTatCa.Name = "ckTatCa";
            this.ckTatCa.Size = new System.Drawing.Size(18, 17);
            this.ckTatCa.TabIndex = 14;
            this.ckTatCa.UseVisualStyleBackColor = true;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(436, 161);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(491, 27);
            this.cmbChiNhanh.TabIndex = 13;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(346, 164);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(76, 19);
            this.lblChiNhanh.TabIndex = 12;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(569, 282);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(145, 38);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 391);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckTatCa);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.lblChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY";
            this.Text = "Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY";
            this.Load += new System.EventHandler(this.Frpt_SP_LIET_KE_DDH_CHUA_CO_PHIEU_NHAP_FRO_CONGTY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckTatCa;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Button btnPreview;
    }
}