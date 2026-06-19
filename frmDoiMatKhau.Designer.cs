namespace WindowsFormsApp1
{
    partial class frmDoiMatKhau
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
			this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMKMoi = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMKCu = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtXN = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnLuu.BorderRadius = 12;
			this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Location = new System.Drawing.Point(105, 193);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
			this.btnLuu.Size = new System.Drawing.Size(135, 39);
			this.btnLuu.TabIndex = 105;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 103;
			this.label1.Text = "Mật Khẩu Mới";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(15, 129);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(79, 20);
			this.label14.TabIndex = 101;
			this.label14.Text = "Xác Nhận";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 106;
			this.label2.Text = "Mật Khẩu Cũ";
			// 
			// txtMKMoi
			// 
			this.txtMKMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtMKMoi.BorderRadius = 10;
			this.txtMKMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMKMoi.DefaultText = "";
			this.txtMKMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMKMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMKMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMKMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMKMoi.FillColor = System.Drawing.Color.LightGray;
			this.txtMKMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMKMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMKMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMKMoi.Location = new System.Drawing.Point(46, 94);
			this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMKMoi.Name = "txtMKMoi";
			this.txtMKMoi.PlaceholderText = "";
			this.txtMKMoi.SelectedText = "";
			this.txtMKMoi.Size = new System.Drawing.Size(283, 30);
			this.txtMKMoi.TabIndex = 107;
			// 
			// txtMKCu
			// 
			this.txtMKCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtMKCu.BorderRadius = 10;
			this.txtMKCu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMKCu.DefaultText = "";
			this.txtMKCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMKCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMKCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMKCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMKCu.FillColor = System.Drawing.Color.LightGray;
			this.txtMKCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMKCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMKCu.Location = new System.Drawing.Point(46, 34);
			this.txtMKCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMKCu.Name = "txtMKCu";
			this.txtMKCu.PlaceholderText = "";
			this.txtMKCu.SelectedText = "";
			this.txtMKCu.Size = new System.Drawing.Size(283, 30);
			this.txtMKCu.TabIndex = 108;
			// 
			// txtXN
			// 
			this.txtXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtXN.BorderRadius = 10;
			this.txtXN.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtXN.DefaultText = "";
			this.txtXN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtXN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtXN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtXN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtXN.FillColor = System.Drawing.Color.LightGray;
			this.txtXN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtXN.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtXN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtXN.Location = new System.Drawing.Point(46, 155);
			this.txtXN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtXN.Name = "txtXN";
			this.txtXN.PlaceholderText = "";
			this.txtXN.SelectedText = "";
			this.txtXN.Size = new System.Drawing.Size(283, 30);
			this.txtXN.TabIndex = 109;
			// 
			// frmDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.ClientSize = new System.Drawing.Size(358, 244);
			this.Controls.Add(this.txtXN);
			this.Controls.Add(this.txtMKCu);
			this.Controls.Add(this.txtMKMoi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label14);
			this.Name = "frmDoiMatKhau";
			this.Text = "frmDoiMatKhau";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtMKMoi;
		private Guna.UI2.WinForms.Guna2TextBox txtMKCu;
		private Guna.UI2.WinForms.Guna2TextBox txtXN;
	}
}