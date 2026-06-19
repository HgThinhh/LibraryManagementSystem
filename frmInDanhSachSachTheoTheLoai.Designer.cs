namespace WindowsFormsApp1
{
	partial class frmInDanhSachSachTheoTheLoai
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
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnXuatHoaDon = new Guna.UI2.WinForms.Guna2Button();
			this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.InDanhSachSachTheoTheLoai1 = new WindowsFormsApp1.InDanhSachSachTheoTheLoai();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.btnXuatHoaDon);
			this.guna2Panel1.Controls.Add(this.txtMa);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1382, 116);
			this.guna2Panel1.TabIndex = 0;
			// 
			// btnXuatHoaDon
			// 
			this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnXuatHoaDon.BorderColor = System.Drawing.Color.Lime;
			this.btnXuatHoaDon.BorderRadius = 13;
			this.btnXuatHoaDon.BorderThickness = 2;
			this.btnXuatHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXuatHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXuatHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuatHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXuatHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnXuatHoaDon.Image = global::WindowsFormsApp1.Properties.Resources.circle_check_regular1;
			this.btnXuatHoaDon.Location = new System.Drawing.Point(1222, 36);
			this.btnXuatHoaDon.Name = "btnXuatHoaDon";
			this.btnXuatHoaDon.Size = new System.Drawing.Size(226, 53);
			this.btnXuatHoaDon.TabIndex = 32;
			this.btnXuatHoaDon.Text = "Xuất Hoá Đơn";
			this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
			this.btnXuatHoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnXuatHoaDon_KeyDown);
			// 
			// txtMa
			// 
			this.txtMa.BorderRadius = 15;
			this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMa.DefaultText = "";
			this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMa.IconLeftOffset = new System.Drawing.Point(12, 0);
			this.txtMa.Location = new System.Drawing.Point(574, 36);
			this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMa.Name = "txtMa";
			this.txtMa.PlaceholderText = "Nhập thể loại sách muốn xuất hoá đơn...";
			this.txtMa.SelectedText = "";
			this.txtMa.Size = new System.Drawing.Size(574, 53);
			this.txtMa.TabIndex = 1;
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 116);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.InDanhSachSachTheoTheLoai1;
			this.crystalReportViewer1.Size = new System.Drawing.Size(1382, 489);
			this.crystalReportViewer1.TabIndex = 1;
			// 
			// frmInDanhSachSachTheoTheLoai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1382, 605);
			this.Controls.Add(this.crystalReportViewer1);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "frmInDanhSachSachTheoTheLoai";
			this.Text = "frmInDanhSachSachTheoTheLoai";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmInDanhSachSachTheoTheLoai_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private Guna.UI2.WinForms.Guna2TextBox txtMa;
		private Guna.UI2.WinForms.Guna2Button btnXuatHoaDon;
		private InDanhSachSachTheoTheLoai InDanhSachSachTheoTheLoai1;
	}
}