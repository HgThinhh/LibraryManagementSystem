namespace WindowsFormsApp1
{
	partial class frmQuanLySach
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTheLoai = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblDangMuon = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblSachCon = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvSach = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTongSach = new System.Windows.Forms.Label();
			this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Panel4.SuspendLayout();
			this.guna2Panel8.SuspendLayout();
			this.guna2Panel7.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
			this.guna2Panel14.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel4
			// 
			this.guna2Panel4.BackColor = System.Drawing.Color.Black;
			this.guna2Panel4.BorderColor = System.Drawing.Color.White;
			this.guna2Panel4.BorderRadius = 1;
			this.guna2Panel4.Controls.Add(this.label2);
			this.guna2Panel4.Controls.Add(this.label3);
			this.guna2Panel4.Controls.Add(this.btnThem);
			this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new System.Drawing.Size(1702, 161);
			this.guna2Panel4.TabIndex = 42;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(112, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 46);
			this.label2.TabIndex = 11;
			this.label2.Text = "Giúp người dùng biết được sách nào đang hiện có trong thư viện";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(110, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 32);
			this.label3.TabIndex = 12;
			this.label3.Text = "Quản Lý Sách";
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
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThem.Image = global::WindowsFormsApp1.Properties.Resources.check_solid__1_;
			this.btnThem.Location = new System.Drawing.Point(1213, 54);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(339, 83);
			this.btnThem.TabIndex = 10;
			this.btnThem.Text = "Thêm Sách Mới";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// guna2Panel8
			// 
			this.guna2Panel8.AutoSize = true;
			this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel8.BorderRadius = 15;
			this.guna2Panel8.BorderThickness = 2;
			this.guna2Panel8.Controls.Add(this.guna2Separator4);
			this.guna2Panel8.Controls.Add(this.lblTheLoai);
			this.guna2Panel8.Controls.Add(this.label17);
			this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel8.Location = new System.Drawing.Point(1228, 200);
			this.guna2Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel8.Name = "guna2Panel8";
			this.guna2Panel8.Size = new System.Drawing.Size(235, 166);
			this.guna2Panel8.TabIndex = 43;
			// 
			// lblTheLoai
			// 
			this.lblTheLoai.AutoSize = true;
			this.lblTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTheLoai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTheLoai.Location = new System.Drawing.Point(18, 22);
			this.lblTheLoai.Name = "lblTheLoai";
			this.lblTheLoai.Size = new System.Drawing.Size(87, 37);
			this.lblTheLoai.TabIndex = 13;
			this.lblTheLoai.Text = "1200";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label17.Location = new System.Drawing.Point(21, 68);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(172, 20);
			this.label17.TabIndex = 13;
			this.label17.Text = "Thể Loại Sách Hiện Có";
			// 
			// guna2Panel7
			// 
			this.guna2Panel7.AutoSize = true;
			this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel7.BorderRadius = 15;
			this.guna2Panel7.BorderThickness = 2;
			this.guna2Panel7.Controls.Add(this.guna2Separator3);
			this.guna2Panel7.Controls.Add(this.lblDangMuon);
			this.guna2Panel7.Controls.Add(this.label15);
			this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel7.Location = new System.Drawing.Point(853, 200);
			this.guna2Panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel7.Name = "guna2Panel7";
			this.guna2Panel7.Size = new System.Drawing.Size(235, 166);
			this.guna2Panel7.TabIndex = 44;
			// 
			// lblDangMuon
			// 
			this.lblDangMuon.AutoSize = true;
			this.lblDangMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDangMuon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblDangMuon.Location = new System.Drawing.Point(28, 22);
			this.lblDangMuon.Name = "lblDangMuon";
			this.lblDangMuon.Size = new System.Drawing.Size(69, 37);
			this.lblDangMuon.TabIndex = 13;
			this.lblDangMuon.Text = "120";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label15.Location = new System.Drawing.Point(31, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(130, 20);
			this.label15.TabIndex = 13;
			this.label15.Text = "Sách đang mượn";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.AutoSize = true;
			this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
			this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.BorderThickness = 2;
			this.guna2Panel2.Controls.Add(this.guna2Separator2);
			this.guna2Panel2.Controls.Add(this.lblSachCon);
			this.guna2Panel2.Controls.Add(this.label13);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel2.Location = new System.Drawing.Point(472, 200);
			this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(235, 166);
			this.guna2Panel2.TabIndex = 45;
			// 
			// lblSachCon
			// 
			this.lblSachCon.AutoSize = true;
			this.lblSachCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblSachCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblSachCon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSachCon.Location = new System.Drawing.Point(27, 22);
			this.lblSachCon.Name = "lblSachCon";
			this.lblSachCon.Size = new System.Drawing.Size(87, 37);
			this.lblSachCon.TabIndex = 13;
			this.lblSachCon.Text = "1200";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label13.Location = new System.Drawing.Point(31, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(147, 20);
			this.label13.TabIndex = 13;
			this.label13.Text = "Sách còn trong kho";
			// 
			// guna2Panel5
			// 
			this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel5.BorderRadius = 15;
			this.guna2Panel5.BorderThickness = 2;
			this.guna2Panel5.Controls.Add(this.txtTimKiem);
			this.guna2Panel5.Controls.Add(this.label1);
			this.guna2Panel5.Controls.Add(this.dgvSach);
			this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel5.Location = new System.Drawing.Point(109, 418);
			this.guna2Panel5.Name = "guna2Panel5";
			this.guna2Panel5.Size = new System.Drawing.Size(1354, 455);
			this.guna2Panel5.TabIndex = 47;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
			this.txtTimKiem.BorderRadius = 10;
			this.txtTimKiem.BorderThickness = 2;
			this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTimKiem.DefaultText = "";
			this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Location = new System.Drawing.Point(151, 12);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.PlaceholderText = "Tìm kiếm nhanh...";
			this.txtTimKiem.SelectedText = "";
			this.txtTimKiem.Size = new System.Drawing.Size(286, 48);
			this.txtTimKiem.TabIndex = 18;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(26, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Sách Hiện Có:";
			// 
			// dgvSach
			// 
			this.dgvSach.AllowUserToAddRows = false;
			this.dgvSach.AllowUserToResizeColumns = false;
			this.dgvSach.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
			this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSach.ColumnHeadersHeight = 25;
			this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSach.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSach.GridColor = System.Drawing.Color.Gray;
			this.dgvSach.Location = new System.Drawing.Point(16, 68);
			this.dgvSach.Name = "dgvSach";
			this.dgvSach.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSach.RowHeadersVisible = false;
			this.dgvSach.RowHeadersWidth = 62;
			this.dgvSach.RowTemplate.Height = 28;
			this.dgvSach.Size = new System.Drawing.Size(1335, 366);
			this.dgvSach.TabIndex = 1;
			this.dgvSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSach.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvSach.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.dgvSach.ThemeStyle.GridColor = System.Drawing.Color.Gray;
			this.dgvSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvSach.ThemeStyle.HeaderStyle.Height = 25;
			this.dgvSach.ThemeStyle.ReadOnly = true;
			this.dgvSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSach.ThemeStyle.RowsStyle.Height = 28;
			this.dgvSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(27, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "Tổng Số Sách";
			// 
			// lblTongSach
			// 
			this.lblTongSach.AutoSize = true;
			this.lblTongSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblTongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTongSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTongSach.Location = new System.Drawing.Point(23, 22);
			this.lblTongSach.Name = "lblTongSach";
			this.lblTongSach.Size = new System.Drawing.Size(87, 37);
			this.lblTongSach.TabIndex = 13;
			this.lblTongSach.Text = "1200";
			// 
			// guna2Panel14
			// 
			this.guna2Panel14.AutoSize = true;
			this.guna2Panel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel14.BorderRadius = 15;
			this.guna2Panel14.BorderThickness = 2;
			this.guna2Panel14.Controls.Add(this.guna2Separator1);
			this.guna2Panel14.Controls.Add(this.lblTongSach);
			this.guna2Panel14.Controls.Add(this.label10);
			this.guna2Panel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel14.Location = new System.Drawing.Point(109, 200);
			this.guna2Panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel14.Name = "guna2Panel14";
			this.guna2Panel14.Size = new System.Drawing.Size(235, 166);
			this.guna2Panel14.TabIndex = 46;
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Separator1.Location = new System.Drawing.Point(16, 129);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
			this.guna2Separator1.TabIndex = 14;
			// 
			// guna2Separator2
			// 
			this.guna2Separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Separator2.Location = new System.Drawing.Point(17, 129);
			this.guna2Separator2.Name = "guna2Separator2";
			this.guna2Separator2.Size = new System.Drawing.Size(200, 10);
			this.guna2Separator2.TabIndex = 15;
			// 
			// guna2Separator3
			// 
			this.guna2Separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Separator3.Location = new System.Drawing.Point(16, 129);
			this.guna2Separator3.Name = "guna2Separator3";
			this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
			this.guna2Separator3.TabIndex = 48;
			// 
			// guna2Separator4
			// 
			this.guna2Separator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Separator4.Location = new System.Drawing.Point(14, 129);
			this.guna2Separator4.Name = "guna2Separator4";
			this.guna2Separator4.Size = new System.Drawing.Size(200, 10);
			this.guna2Separator4.TabIndex = 15;
			// 
			// frmQuanLySach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1702, 1050);
			this.Controls.Add(this.guna2Panel5);
			this.Controls.Add(this.guna2Panel8);
			this.Controls.Add(this.guna2Panel7);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel14);
			this.Controls.Add(this.guna2Panel4);
			this.Name = "frmQuanLySach";
			this.ShowIcon = false;
			this.Text = "frmQuanLySach";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmQuanLySach_Load);
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			this.guna2Panel8.ResumeLayout(false);
			this.guna2Panel8.PerformLayout();
			this.guna2Panel7.ResumeLayout(false);
			this.guna2Panel7.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel5.ResumeLayout(false);
			this.guna2Panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
			this.guna2Panel14.ResumeLayout(false);
			this.guna2Panel14.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
		private Guna.UI2.WinForms.Guna2Button btnThem;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
		private System.Windows.Forms.Label lblTheLoai;
		private System.Windows.Forms.Label label17;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
		private System.Windows.Forms.Label lblDangMuon;
		private System.Windows.Forms.Label label15;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label lblSachCon;
		private System.Windows.Forms.Label label13;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
		private Guna.UI2.WinForms.Guna2DataGridView dgvSach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblTongSach;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
	}
}