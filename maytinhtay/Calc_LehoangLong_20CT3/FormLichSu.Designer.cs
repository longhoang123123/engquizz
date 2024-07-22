namespace Calc_LehoangLong_20CT3
{
    partial class frmLichSu
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
            this.btnMayTinh = new ePOSOne.btnProduct.Button_WOC();
            this.rtbLichSu = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // btnMayTinh
            // 
            this.btnMayTinh.BackColor = System.Drawing.Color.Black;
            this.btnMayTinh.BackgroundImage = global::Calc_LehoangLong_20CT3.Properties.Resources.calculator_icon;
            this.btnMayTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMayTinh.BorderColor = System.Drawing.Color.Empty;
            this.btnMayTinh.ButtonColor = System.Drawing.Color.Empty;
            this.btnMayTinh.FlatAppearance.BorderSize = 0;
            this.btnMayTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMayTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayTinh.Location = new System.Drawing.Point(12, 12);
            this.btnMayTinh.Name = "btnMayTinh";
            this.btnMayTinh.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnMayTinh.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnMayTinh.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnMayTinh.Size = new System.Drawing.Size(45, 45);
            this.btnMayTinh.TabIndex = 10;
            this.btnMayTinh.TextColor = System.Drawing.Color.Empty;
            this.btnMayTinh.UseVisualStyleBackColor = false;
            this.btnMayTinh.Click += new System.EventHandler(this.btnMayTinh_Click);
            // 
            // rtbLichSu
            // 
            this.rtbLichSu.BackColor = System.Drawing.Color.Black;
            this.rtbLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLichSu.ForeColor = System.Drawing.Color.White;
            this.rtbLichSu.Location = new System.Drawing.Point(22, 86);
            this.rtbLichSu.Name = "rtbLichSu";
            this.rtbLichSu.ReadOnly = true;
            this.rtbLichSu.Size = new System.Drawing.Size(412, 647);
            this.rtbLichSu.TabIndex = 11;
            this.rtbLichSu.Text = "";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.Empty;
            this.btnXoa.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(22, 738);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnXoa.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(412, 83);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa nhật ký";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(456, 833);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.rtbLichSu);
            this.Controls.Add(this.btnMayTinh);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLichSu";
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnMayTinh;
        private System.Windows.Forms.RichTextBox rtbLichSu;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
    }
}