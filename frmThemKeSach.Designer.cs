namespace WindowsFormsApp1
{
	partial class frmThemKeSach
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
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtMaKe = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtTenKe = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtHinhAnh = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtViTri = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnRefeshQH = new Guna.UI2.WinForms.Guna2Button();
			this.cboTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Black;
			this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThem.BorderRadius = 15;
			this.btnThem.BorderThickness = 2;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThem.Image = global::WindowsFormsApp1.Properties.Resources.check_solid__1_;
			this.btnThem.Location = new System.Drawing.Point(704, 26);
			this.btnThem.Name = "btnThem";
			this.btnThem.PressedColor = System.Drawing.Color.BlanchedAlmond;
			this.btnThem.Size = new System.Drawing.Size(261, 56);
			this.btnThem.TabIndex = 37;
			this.btnThem.Text = "Save";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.Black;
			this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.BorderThickness = 2;
			this.guna2Panel2.Controls.Add(this.txtGhiChu);
			this.guna2Panel2.Controls.Add(this.txtViTri);
			this.guna2Panel2.Controls.Add(this.txtSoLuong);
			this.guna2Panel2.Controls.Add(this.txtHinhAnh);
			this.guna2Panel2.Controls.Add(this.txtTenKe);
			this.guna2Panel2.Controls.Add(this.label9);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.label14);
			this.guna2Panel2.Controls.Add(this.txtMaKe);
			this.guna2Panel2.Controls.Add(this.label6);
			this.guna2Panel2.Controls.Add(this.label17);
			this.guna2Panel2.Controls.Add(this.label15);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel2.Location = new System.Drawing.Point(47, 137);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(730, 261);
			this.guna2Panel2.TabIndex = 126;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(54, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 20);
			this.label9.TabIndex = 132;
			this.label9.Text = "Mã Kệ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(54, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 128;
			this.label1.Text = "Tên Kệ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(54, 171);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(75, 20);
			this.label14.TabIndex = 124;
			this.label14.Text = "Hình Ảnh";
			// 
			// txtMaKe
			// 
			this.txtMaKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtMaKe.BorderRadius = 10;
			this.txtMaKe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaKe.DefaultText = "";
			this.txtMaKe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaKe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaKe.FillColor = System.Drawing.Color.LightGray;
			this.txtMaKe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaKe.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaKe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaKe.Location = new System.Drawing.Point(53, 39);
			this.txtMaKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaKe.Name = "txtMaKe";
			this.txtMaKe.PlaceholderText = "";
			this.txtMaKe.SelectedText = "";
			this.txtMaKe.Size = new System.Drawing.Size(248, 36);
			this.txtMaKe.TabIndex = 131;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(402, 89);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 20);
			this.label6.TabIndex = 130;
			this.label6.Text = "Vị trí";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(392, 14);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(78, 20);
			this.label17.TabIndex = 127;
			this.label17.Text = "Số Lượng";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(398, 171);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 20);
			this.label15.TabIndex = 126;
			this.label15.Text = "Ghi Chú";
			// 
			// txtTenKe
			// 
			this.txtTenKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtTenKe.BorderRadius = 10;
			this.txtTenKe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenKe.DefaultText = "";
			this.txtTenKe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenKe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenKe.FillColor = System.Drawing.Color.LightGray;
			this.txtTenKe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenKe.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTenKe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenKe.Location = new System.Drawing.Point(53, 119);
			this.txtTenKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenKe.Name = "txtTenKe";
			this.txtTenKe.PlaceholderText = "";
			this.txtTenKe.SelectedText = "";
			this.txtTenKe.Size = new System.Drawing.Size(248, 36);
			this.txtTenKe.TabIndex = 133;
			// 
			// txtHinhAnh
			// 
			this.txtHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtHinhAnh.BorderRadius = 10;
			this.txtHinhAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHinhAnh.DefaultText = "";
			this.txtHinhAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtHinhAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtHinhAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtHinhAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtHinhAnh.FillColor = System.Drawing.Color.LightGray;
			this.txtHinhAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtHinhAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtHinhAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtHinhAnh.Location = new System.Drawing.Point(58, 206);
			this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtHinhAnh.Name = "txtHinhAnh";
			this.txtHinhAnh.PlaceholderText = "";
			this.txtHinhAnh.SelectedText = "";
			this.txtHinhAnh.Size = new System.Drawing.Size(248, 36);
			this.txtHinhAnh.TabIndex = 134;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtSoLuong.BorderRadius = 10;
			this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSoLuong.DefaultText = "";
			this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoLuong.FillColor = System.Drawing.Color.LightGray;
			this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoLuong.Location = new System.Drawing.Point(402, 39);
			this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.PlaceholderText = "";
			this.txtSoLuong.SelectedText = "";
			this.txtSoLuong.Size = new System.Drawing.Size(248, 36);
			this.txtSoLuong.TabIndex = 135;
			// 
			// txtViTri
			// 
			this.txtViTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtViTri.BorderRadius = 10;
			this.txtViTri.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtViTri.DefaultText = "";
			this.txtViTri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtViTri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtViTri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtViTri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtViTri.FillColor = System.Drawing.Color.LightGray;
			this.txtViTri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtViTri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtViTri.Location = new System.Drawing.Point(406, 119);
			this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtViTri.Name = "txtViTri";
			this.txtViTri.PlaceholderText = "";
			this.txtViTri.SelectedText = "";
			this.txtViTri.Size = new System.Drawing.Size(248, 36);
			this.txtViTri.TabIndex = 136;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtGhiChu.BorderRadius = 10;
			this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGhiChu.DefaultText = "";
			this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGhiChu.FillColor = System.Drawing.Color.LightGray;
			this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGhiChu.Location = new System.Drawing.Point(406, 206);
			this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.PlaceholderText = "";
			this.txtGhiChu.SelectedText = "";
			this.txtGhiChu.Size = new System.Drawing.Size(248, 36);
			this.txtGhiChu.TabIndex = 137;
			// 
			// btnRefeshQH
			// 
			this.btnRefeshQH.BackColor = System.Drawing.Color.Black;
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
			this.btnRefeshQH.Location = new System.Drawing.Point(531, 26);
			this.btnRefeshQH.Name = "btnRefeshQH";
			this.btnRefeshQH.Size = new System.Drawing.Size(124, 56);
			this.btnRefeshQH.TabIndex = 141;
			this.btnRefeshQH.Text = "Huỷ";
			this.btnRefeshQH.Click += new System.EventHandler(this.btnRefeshQH_Click);
			// 
			// cboTheLoai
			// 
			this.cboTheLoai.BackColor = System.Drawing.Color.Black;
			this.cboTheLoai.BorderRadius = 12;
			this.cboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTheLoai.FillColor = System.Drawing.Color.LightGray;
			this.cboTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboTheLoai.ItemHeight = 30;
			this.cboTheLoai.Location = new System.Drawing.Point(105, 46);
			this.cboTheLoai.Name = "cboTheLoai";
			this.cboTheLoai.Size = new System.Drawing.Size(228, 36);
			this.cboTheLoai.TabIndex = 142;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(96, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 143;
			this.label2.Text = "Thể Loại";
			// 
			// frmThemKeSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1019, 642);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTheLoai);
			this.Controls.Add(this.btnRefeshQH);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.btnThem);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmThemKeSach";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmThemKeSach";
			this.Load += new System.EventHandler(this.frmThemKeSach_Load_1);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnThem;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label14;
		private Guna.UI2.WinForms.Guna2TextBox txtMaKe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
		private Guna.UI2.WinForms.Guna2TextBox txtViTri;
		private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
		private Guna.UI2.WinForms.Guna2TextBox txtHinhAnh;
		private Guna.UI2.WinForms.Guna2TextBox txtTenKe;
		private Guna.UI2.WinForms.Guna2Button btnRefeshQH;
		private Guna.UI2.WinForms.Guna2ComboBox cboTheLoai;
		private System.Windows.Forms.Label label2;
	}
}