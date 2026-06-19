namespace WindowsFormsApp1
{
	partial class frmThemTheThuVien
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
			this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnRefeshQH = new Guna.UI2.WinForms.Guna2Button();
			this.label8 = new System.Windows.Forms.Label();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.dtHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.dtNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaThe = new Guna.UI2.WinForms.Guna2TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2Panel4.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel4
			// 
			this.guna2Panel4.BackColor = System.Drawing.Color.Black;
			this.guna2Panel4.BorderColor = System.Drawing.Color.White;
			this.guna2Panel4.BorderRadius = 1;
			this.guna2Panel4.Controls.Add(this.label7);
			this.guna2Panel4.Controls.Add(this.label8);
			this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new System.Drawing.Size(1336, 123);
			this.guna2Panel4.TabIndex = 144;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(294, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 20);
			this.label7.TabIndex = 142;
			this.label7.Text = "Trạng Thái";
			// 
			// btnRefeshQH
			// 
			this.btnRefeshQH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.btnRefeshQH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRefeshQH.BorderRadius = 15;
			this.btnRefeshQH.BorderThickness = 1;
			this.btnRefeshQH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRefeshQH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnRefeshQH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRefeshQH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnRefeshQH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnRefeshQH.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnRefeshQH.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnRefeshQH.Location = new System.Drawing.Point(282, 238);
			this.btnRefeshQH.Name = "btnRefeshQH";
			this.btnRefeshQH.Size = new System.Drawing.Size(109, 49);
			this.btnRefeshQH.TabIndex = 140;
			this.btnRefeshQH.Text = "Huỷ";
			this.btnRefeshQH.Click += new System.EventHandler(this.btnRefeshQH_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(25, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(280, 32);
			this.label8.TabIndex = 7;
			this.label8.Text = "Thêm Thẻ Thư Viện";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThem.BorderRadius = 15;
			this.btnThem.BorderThickness = 2;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThem.Image = global::WindowsFormsApp1.Properties.Resources.check_solid__1_;
			this.btnThem.Location = new System.Drawing.Point(425, 236);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(141, 51);
			this.btnThem.TabIndex = 128;
			this.btnThem.Text = "Save";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Separator1.Location = new System.Drawing.Point(247, 217);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(341, 10);
			this.guna2Separator1.TabIndex = 141;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.Black;
			this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel1.BorderRadius = 15;
			this.guna2Panel1.BorderThickness = 2;
			this.guna2Panel1.Controls.Add(this.dtHetHan);
			this.guna2Panel1.Controls.Add(this.btnRefeshQH);
			this.guna2Panel1.Controls.Add(this.dtNgayCap);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.btnThem);
			this.guna2Panel1.Controls.Add(this.guna2Separator1);
			this.guna2Panel1.Controls.Add(this.txtMaThe);
			this.guna2Panel1.Controls.Add(this.label9);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Controls.Add(this.txtMaDocGia);
			this.guna2Panel1.Controls.Add(this.label15);
			this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel1.Location = new System.Drawing.Point(286, 207);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(888, 326);
			this.guna2Panel1.TabIndex = 145;
			// 
			// dtHetHan
			// 
			this.dtHetHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dtHetHan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.dtHetHan.BorderRadius = 12;
			this.dtHetHan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			this.dtHetHan.Checked = true;
			this.dtHetHan.FillColor = System.Drawing.Color.White;
			this.dtHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtHetHan.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dtHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtHetHan.Location = new System.Drawing.Point(456, 144);
			this.dtHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtHetHan.Name = "dtHetHan";
			this.dtHetHan.Size = new System.Drawing.Size(258, 36);
			this.dtHetHan.TabIndex = 136;
			this.dtHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dtHetHan.Value = new System.DateTime(2026, 5, 27, 0, 9, 26, 0);
			// 
			// dtNgayCap
			// 
			this.dtNgayCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dtNgayCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.dtNgayCap.BorderRadius = 12;
			this.dtNgayCap.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			this.dtNgayCap.Checked = true;
			this.dtNgayCap.FillColor = System.Drawing.Color.White;
			this.dtNgayCap.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtNgayCap.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayCap.Location = new System.Drawing.Point(456, 47);
			this.dtNgayCap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtNgayCap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtNgayCap.Name = "dtNgayCap";
			this.dtNgayCap.Size = new System.Drawing.Size(258, 36);
			this.dtNgayCap.TabIndex = 136;
			this.dtNgayCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dtNgayCap.Value = new System.DateTime(2026, 5, 27, 0, 12, 32, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(398, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 134;
			this.label3.Text = "Ngày Cấp";
			// 
			// txtMaThe
			// 
			this.txtMaThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtMaThe.BorderRadius = 10;
			this.txtMaThe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaThe.DefaultText = "";
			this.txtMaThe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaThe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaThe.FillColor = System.Drawing.Color.LightGray;
			this.txtMaThe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaThe.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaThe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaThe.Location = new System.Drawing.Point(34, 47);
			this.txtMaThe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaThe.Name = "txtMaThe";
			this.txtMaThe.PlaceholderText = "";
			this.txtMaThe.SelectedText = "";
			this.txtMaThe.Size = new System.Drawing.Size(321, 36);
			this.txtMaThe.TabIndex = 133;
			this.txtMaThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(30, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 20);
			this.label9.TabIndex = 132;
			this.label9.Text = "Mã Thẻ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(398, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 128;
			this.label1.Text = "Hết Hạn";
			// 
			// txtMaDocGia
			// 
			this.txtMaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtMaDocGia.BorderRadius = 10;
			this.txtMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaDocGia.DefaultText = "";
			this.txtMaDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaDocGia.FillColor = System.Drawing.Color.LightGray;
			this.txtMaDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaDocGia.Location = new System.Drawing.Point(34, 144);
			this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaDocGia.Name = "txtMaDocGia";
			this.txtMaDocGia.PlaceholderText = "";
			this.txtMaDocGia.SelectedText = "";
			this.txtMaDocGia.Size = new System.Drawing.Size(321, 36);
			this.txtMaDocGia.TabIndex = 125;
			this.txtMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(30, 111);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(93, 20);
			this.label15.TabIndex = 126;
			this.label15.Text = "Mã Độc Giả";
			// 
			// cboTrangThai
			// 
			this.cboTrangThai.BackColor = System.Drawing.Color.Black;
			this.cboTrangThai.BorderRadius = 12;
			this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTrangThai.FillColor = System.Drawing.Color.LightGray;
			this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboTrangThai.ItemHeight = 30;
			this.cboTrangThai.Location = new System.Drawing.Point(289, 136);
			this.cboTrangThai.Name = "cboTrangThai";
			this.cboTrangThai.Size = new System.Drawing.Size(318, 36);
			this.cboTrangThai.TabIndex = 146;
			// 
			// frmThemTheThuVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1336, 570);
			this.Controls.Add(this.cboTrangThai);
			this.Controls.Add(this.guna2Panel4);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmThemTheThuVien";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmThemTheThuVien";
			this.Load += new System.EventHandler(this.frmThemTheThuVien_Load);
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2Button btnRefeshQH;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2Button btnThem;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtHetHan;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayCap;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtMaThe;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txtMaDocGia;
		private System.Windows.Forms.Label label15;
		private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
	}
}