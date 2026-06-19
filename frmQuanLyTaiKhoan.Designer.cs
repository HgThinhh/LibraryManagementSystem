using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class frmQuanLyTaiKhoan
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
		/// 

		public TabControl TaiKhoanTabControl => tabMain;

		private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabMain = new Guna.UI2.WinForms.Guna2TabControl();
			this.tabTaiKhoan = new System.Windows.Forms.TabPage();
			this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
			this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.cboFilterTT = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cboFilterVT = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMaDG = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtTenDN = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnKhoaTK = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cboVaiTro = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTong = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblDangHD = new System.Windows.Forms.Label();
			this.lblDangNhap = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblBiKhoa = new System.Windows.Forms.Label();
			this.cardTong = new Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cardBiKhoa = new Guna.UI2.WinForms.Guna2Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cardHD = new Guna.UI2.WinForms.Guna2Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.cardVaiTro = new Guna.UI2.WinForms.Guna2Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPhanQuyen = new System.Windows.Forms.TabPage();
			this.flpQuyen = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlPQ = new Guna.UI2.WinForms.Guna2Panel();
			this.r = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.tsPQ = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.btnLuuQuyen = new Guna.UI2.WinForms.Guna2Button();
			this.cboVaiTroPQ = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.tabLichSu = new System.Windows.Forms.TabPage();
			this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblFillerLS = new System.Windows.Forms.Label();
			this.dgvLichSu = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Panel1.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tabTaiKhoan.SuspendLayout();
			this.guna2Panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
			this.guna2Panel6.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.cardTong.SuspendLayout();
			this.cardBiKhoa.SuspendLayout();
			this.cardHD.SuspendLayout();
			this.cardVaiTro.SuspendLayout();
			this.tabPhanQuyen.SuspendLayout();
			this.flpQuyen.SuspendLayout();
			this.pnlPQ.SuspendLayout();
			this.tabLichSu.SuspendLayout();
			this.guna2Panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel1.Controls.Add(this.label9);
			this.guna2Panel1.Controls.Add(this.label8);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1565, 99);
			this.guna2Panel1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(84, 57);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(263, 20);
			this.label9.TabIndex = 6;
			this.label9.Text = "Phân quyền người dùng và hệ thống";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(82, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(275, 32);
			this.label8.TabIndex = 7;
			this.label8.Text = "Quản Lý Tài Khoản";
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tabTaiKhoan);
			this.tabMain.Controls.Add(this.tabPhanQuyen);
			this.tabMain.Controls.Add(this.tabLichSu);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.ItemSize = new System.Drawing.Size(150, 40);
			this.tabMain.Location = new System.Drawing.Point(0, 99);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(1565, 951);
			this.tabMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
			this.tabMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.tabMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.tabMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
			this.tabMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.tabMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
			this.tabMain.TabButtonIdleState.FillColor = System.Drawing.Color.Black;
			this.tabMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.tabMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
			this.tabMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			this.tabMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
			this.tabMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
			this.tabMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.tabMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
			this.tabMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
			this.tabMain.TabButtonSize = new System.Drawing.Size(150, 40);
			this.tabMain.TabIndex = 56;
			this.tabMain.TabMenuBackColor = System.Drawing.Color.Black;
			this.tabMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
			// 
			// tabTaiKhoan
			// 
			this.tabTaiKhoan.AutoScroll = true;
			this.tabTaiKhoan.BackColor = System.Drawing.Color.Black;
			this.tabTaiKhoan.Controls.Add(this.guna2Panel8);
			this.tabTaiKhoan.Controls.Add(this.guna2Panel6);
			this.tabTaiKhoan.Controls.Add(this.guna2Panel2);
			this.tabTaiKhoan.Controls.Add(this.label1);
			this.tabTaiKhoan.Controls.Add(this.lblTong);
			this.tabTaiKhoan.Controls.Add(this.label12);
			this.tabTaiKhoan.Controls.Add(this.lblDangHD);
			this.tabTaiKhoan.Controls.Add(this.lblDangNhap);
			this.tabTaiKhoan.Controls.Add(this.label4);
			this.tabTaiKhoan.Controls.Add(this.lblBiKhoa);
			this.tabTaiKhoan.Controls.Add(this.cardTong);
			this.tabTaiKhoan.Controls.Add(this.cardBiKhoa);
			this.tabTaiKhoan.Controls.Add(this.cardHD);
			this.tabTaiKhoan.Controls.Add(this.cardVaiTro);
			this.tabTaiKhoan.Location = new System.Drawing.Point(4, 44);
			this.tabTaiKhoan.Name = "tabTaiKhoan";
			this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
			this.tabTaiKhoan.Size = new System.Drawing.Size(1557, 903);
			this.tabTaiKhoan.TabIndex = 0;
			this.tabTaiKhoan.Text = "Tài Khoản";
			// 
			// guna2Panel8
			// 
			this.guna2Panel8.AutoSize = true;
			this.guna2Panel8.BackColor = System.Drawing.Color.Black;
			this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel8.BorderRadius = 15;
			this.guna2Panel8.BorderThickness = 2;
			this.guna2Panel8.Controls.Add(this.dgvTaiKhoan);
			this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel8.Location = new System.Drawing.Point(534, 341);
			this.guna2Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel8.Name = "guna2Panel8";
			this.guna2Panel8.Size = new System.Drawing.Size(936, 516);
			this.guna2Panel8.TabIndex = 82;
			// 
			// dgvTaiKhoan
			// 
			this.dgvTaiKhoan.AllowUserToAddRows = false;
			this.dgvTaiKhoan.AllowUserToResizeColumns = false;
			this.dgvTaiKhoan.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver;
			this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvTaiKhoan.ColumnHeadersHeight = 25;
			this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvTaiKhoan.GridColor = System.Drawing.Color.Gray;
			this.dgvTaiKhoan.Location = new System.Drawing.Point(33, 29);
			this.dgvTaiKhoan.Name = "dgvTaiKhoan";
			this.dgvTaiKhoan.ReadOnly = true;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvTaiKhoan.RowHeadersVisible = false;
			this.dgvTaiKhoan.RowHeadersWidth = 62;
			this.dgvTaiKhoan.RowTemplate.Height = 28;
			this.dgvTaiKhoan.Size = new System.Drawing.Size(900, 460);
			this.dgvTaiKhoan.TabIndex = 3;
			this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.dgvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.Gray;
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 25;
			this.dgvTaiKhoan.ThemeStyle.ReadOnly = true;
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 28;
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick_1);
			// 
			// guna2Panel6
			// 
			this.guna2Panel6.AutoSize = true;
			this.guna2Panel6.BackColor = System.Drawing.Color.Black;
			this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel6.BorderRadius = 15;
			this.guna2Panel6.BorderThickness = 2;
			this.guna2Panel6.Controls.Add(this.txtTimKiem);
			this.guna2Panel6.Controls.Add(this.cboFilterTT);
			this.guna2Panel6.Controls.Add(this.cboFilterVT);
			this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel6.Location = new System.Drawing.Point(534, 200);
			this.guna2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new System.Drawing.Size(933, 126);
			this.guna2Panel6.TabIndex = 81;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtTimKiem.BorderRadius = 10;
			this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTimKiem.DefaultText = "";
			this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.FillColor = System.Drawing.SystemColors.Window;
			this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
			this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Location = new System.Drawing.Point(33, 15);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.PlaceholderText = "Tìm kiếm....";
			this.txtTimKiem.SelectedText = "";
			this.txtTimKiem.Size = new System.Drawing.Size(317, 36);
			this.txtTimKiem.TabIndex = 85;
			// 
			// cboFilterTT
			// 
			this.cboFilterTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.cboFilterTT.BorderRadius = 12;
			this.cboFilterTT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboFilterTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFilterTT.FillColor = System.Drawing.Color.LightGray;
			this.cboFilterTT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboFilterTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboFilterTT.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboFilterTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboFilterTT.ItemHeight = 30;
			this.cboFilterTT.Location = new System.Drawing.Point(503, 15);
			this.cboFilterTT.Name = "cboFilterTT";
			this.cboFilterTT.Size = new System.Drawing.Size(210, 36);
			this.cboFilterTT.TabIndex = 79;
			// 
			// cboFilterVT
			// 
			this.cboFilterVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.cboFilterVT.BorderRadius = 12;
			this.cboFilterVT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboFilterVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFilterVT.FillColor = System.Drawing.Color.LightGray;
			this.cboFilterVT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboFilterVT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboFilterVT.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboFilterVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboFilterVT.ItemHeight = 30;
			this.cboFilterVT.Location = new System.Drawing.Point(357, 15);
			this.cboFilterVT.Name = "cboFilterVT";
			this.cboFilterVT.Size = new System.Drawing.Size(140, 36);
			this.cboFilterVT.TabIndex = 77;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.AutoSize = true;
			this.guna2Panel2.BackColor = System.Drawing.Color.Black;
			this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.BorderThickness = 2;
			this.guna2Panel2.Controls.Add(this.txtMaNV);
			this.guna2Panel2.Controls.Add(this.txtMaDG);
			this.guna2Panel2.Controls.Add(this.txtEmail);
			this.guna2Panel2.Controls.Add(this.txtHoTen);
			this.guna2Panel2.Controls.Add(this.txtTenDN);
			this.guna2Panel2.Controls.Add(this.btnKhoaTK);
			this.guna2Panel2.Controls.Add(this.guna2Separator1);
			this.guna2Panel2.Controls.Add(this.btnLamMoi);
			this.guna2Panel2.Controls.Add(this.btnXoa);
			this.guna2Panel2.Controls.Add(this.btnSua);
			this.guna2Panel2.Controls.Add(this.btnThem);
			this.guna2Panel2.Controls.Add(this.label17);
			this.guna2Panel2.Controls.Add(this.label16);
			this.guna2Panel2.Controls.Add(this.label15);
			this.guna2Panel2.Controls.Add(this.cboVaiTro);
			this.guna2Panel2.Controls.Add(this.label14);
			this.guna2Panel2.Controls.Add(this.label13);
			this.guna2Panel2.Controls.Add(this.label10);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.guna2Panel2.Location = new System.Drawing.Point(62, 200);
			this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(416, 657);
			this.guna2Panel2.TabIndex = 80;
			// 
			// txtMaNV
			// 
			this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtMaNV.BorderRadius = 10;
			this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaNV.DefaultText = "";
			this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaNV.FillColor = System.Drawing.Color.LightGray;
			this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaNV.Location = new System.Drawing.Point(56, 257);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.PlaceholderText = "";
			this.txtMaNV.SelectedText = "";
			this.txtMaNV.Size = new System.Drawing.Size(316, 36);
			this.txtMaNV.TabIndex = 101;
			// 
			// txtMaDG
			// 
			this.txtMaDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtMaDG.BorderRadius = 10;
			this.txtMaDG.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaDG.DefaultText = "";
			this.txtMaDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaDG.FillColor = System.Drawing.Color.LightGray;
			this.txtMaDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaDG.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaDG.Location = new System.Drawing.Point(56, 323);
			this.txtMaDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaDG.Name = "txtMaDG";
			this.txtMaDG.PlaceholderText = "";
			this.txtMaDG.SelectedText = "";
			this.txtMaDG.Size = new System.Drawing.Size(316, 43);
			this.txtMaDG.TabIndex = 100;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderRadius = 10;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.Enabled = false;
			this.txtEmail.FillColor = System.Drawing.Color.LightGray;
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(55, 191);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PlaceholderText = "";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(317, 36);
			this.txtEmail.TabIndex = 92;
			// 
			// txtHoTen
			// 
			this.txtHoTen.BorderRadius = 10;
			this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHoTen.DefaultText = "";
			this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtHoTen.Enabled = false;
			this.txtHoTen.FillColor = System.Drawing.Color.LightGray;
			this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtHoTen.Location = new System.Drawing.Point(56, 129);
			this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.PlaceholderText = "";
			this.txtHoTen.SelectedText = "";
			this.txtHoTen.Size = new System.Drawing.Size(317, 36);
			this.txtHoTen.TabIndex = 91;
			// 
			// txtTenDN
			// 
			this.txtTenDN.BorderRadius = 10;
			this.txtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenDN.DefaultText = "";
			this.txtTenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenDN.Enabled = false;
			this.txtTenDN.FillColor = System.Drawing.Color.LightGray;
			this.txtTenDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenDN.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTenDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenDN.Location = new System.Drawing.Point(55, 71);
			this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.PlaceholderText = "";
			this.txtTenDN.SelectedText = "";
			this.txtTenDN.Size = new System.Drawing.Size(317, 36);
			this.txtTenDN.TabIndex = 90;
			// 
			// btnKhoaTK
			// 
			this.btnKhoaTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnKhoaTK.BorderRadius = 12;
			this.btnKhoaTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnKhoaTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnKhoaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnKhoaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnKhoaTK.FillColor = System.Drawing.Color.White;
			this.btnKhoaTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnKhoaTK.ForeColor = System.Drawing.Color.White;
			this.btnKhoaTK.ImageSize = new System.Drawing.Size(30, 30);
			this.btnKhoaTK.Location = new System.Drawing.Point(104, 601);
			this.btnKhoaTK.Name = "btnKhoaTK";
			this.btnKhoaTK.Size = new System.Drawing.Size(177, 40);
			this.btnKhoaTK.TabIndex = 88;
			this.btnKhoaTK.Click += new System.EventHandler(this.btnKhoaTK_Click);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(22, 466);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(367, 10);
			this.guna2Separator1.TabIndex = 87;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnLamMoi.BorderRadius = 12;
			this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Image = global::WindowsFormsApp1.Properties.Resources.arrows_rotate_solid;
			this.btnLamMoi.Location = new System.Drawing.Point(239, 548);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(134, 38);
			this.btnLamMoi.TabIndex = 86;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnXoa.BorderRadius = 12;
			this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXoa.FillColor = System.Drawing.Color.Red;
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Image = global::WindowsFormsApp1.Properties.Resources.eraser_solid;
			this.btnXoa.Location = new System.Drawing.Point(39, 548);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(134, 38);
			this.btnXoa.TabIndex = 85;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
			this.btnSua.BorderRadius = 12;
			this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSua.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Image = global::WindowsFormsApp1.Properties.Resources.pen_solid;
			this.btnSua.Location = new System.Drawing.Point(239, 491);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(134, 39);
			this.btnSua.TabIndex = 84;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnThem.BorderRadius = 12;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Image = global::WindowsFormsApp1.Properties.Resources.plus_solid;
			this.btnThem.Location = new System.Drawing.Point(38, 491);
			this.btnThem.Name = "btnThem";
			this.btnThem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
			this.btnThem.Size = new System.Drawing.Size(135, 39);
			this.btnThem.TabIndex = 83;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(25, 298);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(93, 20);
			this.label17.TabIndex = 81;
			this.label17.Text = "Mã Độc Giả";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(25, 232);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(109, 20);
			this.label16.TabIndex = 79;
			this.label16.Text = "Mã Nhân Viên";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(25, 371);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(59, 20);
			this.label15.TabIndex = 78;
			this.label15.Text = "Vai Trò";
			// 
			// cboVaiTro
			// 
			this.cboVaiTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.cboVaiTro.BorderRadius = 12;
			this.cboVaiTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboVaiTro.FillColor = System.Drawing.Color.LightGray;
			this.cboVaiTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboVaiTro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboVaiTro.ItemHeight = 30;
			this.cboVaiTro.Location = new System.Drawing.Point(55, 395);
			this.cboVaiTro.Name = "cboVaiTro";
			this.cboVaiTro.Size = new System.Drawing.Size(318, 36);
			this.cboVaiTro.TabIndex = 77;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(26, 170);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 20);
			this.label14.TabIndex = 75;
			this.label14.Text = "Email";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(25, 106);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 20);
			this.label13.TabIndex = 73;
			this.label13.Text = "Họ Tên";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(25, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(121, 20);
			this.label10.TabIndex = 71;
			this.label10.Text = "Tên Đăng Nhập";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 22);
			this.label5.TabIndex = 70;
			this.label5.Text = "Chi tiết tài khoản";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(96, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 22);
			this.label1.TabIndex = 69;
			this.label1.Text = "Tổng tài khoản";
			// 
			// lblTong
			// 
			this.lblTong.AutoSize = true;
			this.lblTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTong.ForeColor = System.Drawing.Color.White;
			this.lblTong.Location = new System.Drawing.Point(95, 43);
			this.lblTong.Name = "lblTong";
			this.lblTong.Size = new System.Drawing.Size(64, 25);
			this.lblTong.TabIndex = 68;
			this.lblTong.Text = "label1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(484, 91);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(138, 22);
			this.label12.TabIndex = 75;
			this.label12.Text = "Đang hoạt động";
			// 
			// lblDangHD
			// 
			this.lblDangHD.AutoSize = true;
			this.lblDangHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblDangHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDangHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblDangHD.Location = new System.Drawing.Point(483, 43);
			this.lblDangHD.Name = "lblDangHD";
			this.lblDangHD.Size = new System.Drawing.Size(64, 25);
			this.lblDangHD.TabIndex = 74;
			this.lblDangHD.Text = "label1";
			// 
			// lblDangNhap
			// 
			this.lblDangNhap.AutoSize = true;
			this.lblDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDangNhap.ForeColor = System.Drawing.Color.White;
			this.lblDangNhap.Location = new System.Drawing.Point(886, 43);
			this.lblDangNhap.Name = "lblDangNhap";
			this.lblDangNhap.Size = new System.Drawing.Size(64, 25);
			this.lblDangNhap.TabIndex = 72;
			this.lblDangNhap.Text = "label1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1298, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 22);
			this.label4.TabIndex = 71;
			this.label4.Text = "Bị Khoá";
			// 
			// lblBiKhoa
			// 
			this.lblBiKhoa.AutoSize = true;
			this.lblBiKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.lblBiKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblBiKhoa.ForeColor = System.Drawing.Color.Red;
			this.lblBiKhoa.Location = new System.Drawing.Point(1297, 43);
			this.lblBiKhoa.Name = "lblBiKhoa";
			this.lblBiKhoa.Size = new System.Drawing.Size(64, 25);
			this.lblBiKhoa.TabIndex = 70;
			this.lblBiKhoa.Text = "label1";
			// 
			// cardTong
			// 
			this.cardTong.AutoSize = true;
			this.cardTong.BackColor = System.Drawing.Color.Black;
			this.cardTong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cardTong.BorderRadius = 15;
			this.cardTong.BorderThickness = 2;
			this.cardTong.Controls.Add(this.label2);
			this.cardTong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.cardTong.Location = new System.Drawing.Point(62, 24);
			this.cardTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cardTong.Name = "cardTong";
			this.cardTong.Size = new System.Drawing.Size(213, 149);
			this.cardTong.TabIndex = 76;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.Cyan;
			this.label2.Location = new System.Drawing.Point(34, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 22);
			this.label2.TabIndex = 42;
			this.label2.Text = "____________";
			// 
			// cardBiKhoa
			// 
			this.cardBiKhoa.AutoSize = true;
			this.cardBiKhoa.BackColor = System.Drawing.Color.Black;
			this.cardBiKhoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cardBiKhoa.BorderRadius = 15;
			this.cardBiKhoa.BorderThickness = 2;
			this.cardBiKhoa.Controls.Add(this.label3);
			this.cardBiKhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.cardBiKhoa.Location = new System.Drawing.Point(1254, 24);
			this.cardBiKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cardBiKhoa.Name = "cardBiKhoa";
			this.cardBiKhoa.Size = new System.Drawing.Size(213, 149);
			this.cardBiKhoa.TabIndex = 77;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(44, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 22);
			this.label3.TabIndex = 45;
			this.label3.Text = "____________";
			// 
			// cardHD
			// 
			this.cardHD.AutoSize = true;
			this.cardHD.BackColor = System.Drawing.Color.Black;
			this.cardHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cardHD.BorderRadius = 15;
			this.cardHD.BorderThickness = 2;
			this.cardHD.Controls.Add(this.label11);
			this.cardHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.cardHD.Location = new System.Drawing.Point(456, 24);
			this.cardHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cardHD.Name = "cardHD";
			this.cardHD.Size = new System.Drawing.Size(213, 149);
			this.cardHD.TabIndex = 78;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label11.ForeColor = System.Drawing.Color.Lime;
			this.label11.Location = new System.Drawing.Point(28, 99);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(142, 22);
			this.label11.TabIndex = 51;
			this.label11.Text = "____________";
			// 
			// cardVaiTro
			// 
			this.cardVaiTro.AutoSize = true;
			this.cardVaiTro.BackColor = System.Drawing.Color.Black;
			this.cardVaiTro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cardVaiTro.BorderRadius = 15;
			this.cardVaiTro.BorderThickness = 2;
			this.cardVaiTro.Controls.Add(this.label6);
			this.cardVaiTro.Controls.Add(this.label7);
			this.cardVaiTro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.cardVaiTro.Location = new System.Drawing.Point(859, 24);
			this.cardVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cardVaiTro.Name = "cardVaiTro";
			this.cardVaiTro.Size = new System.Drawing.Size(235, 149);
			this.cardVaiTro.TabIndex = 79;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.Fuchsia;
			this.label6.Location = new System.Drawing.Point(28, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 22);
			this.label6.TabIndex = 48;
			this.label6.Text = "____________";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(28, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(180, 22);
			this.label7.TabIndex = 73;
			this.label7.Text = "Đăng Nhập Hôm Nay";
			// 
			// tabPhanQuyen
			// 
			this.tabPhanQuyen.BackColor = System.Drawing.Color.Black;
			this.tabPhanQuyen.Controls.Add(this.flpQuyen);
			this.tabPhanQuyen.Controls.Add(this.btnLuuQuyen);
			this.tabPhanQuyen.Controls.Add(this.cboVaiTroPQ);
			this.tabPhanQuyen.Controls.Add(this.label18);
			this.tabPhanQuyen.Location = new System.Drawing.Point(4, 44);
			this.tabPhanQuyen.Name = "tabPhanQuyen";
			this.tabPhanQuyen.Padding = new System.Windows.Forms.Padding(3);
			this.tabPhanQuyen.Size = new System.Drawing.Size(1557, 903);
			this.tabPhanQuyen.TabIndex = 1;
			this.tabPhanQuyen.Text = "Phân Quyền";
			// 
			// flpQuyen
			// 
			this.flpQuyen.AutoScroll = true;
			this.flpQuyen.Controls.Add(this.pnlPQ);
			this.flpQuyen.Location = new System.Drawing.Point(84, 115);
			this.flpQuyen.Name = "flpQuyen";
			this.flpQuyen.Size = new System.Drawing.Size(1187, 551);
			this.flpQuyen.TabIndex = 86;
			// 
			// pnlPQ
			// 
			this.pnlPQ.AutoSize = true;
			this.pnlPQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.pnlPQ.BorderRadius = 20;
			this.pnlPQ.BorderThickness = 3;
			this.pnlPQ.Controls.Add(this.r);
			this.pnlPQ.Controls.Add(this.tsPQ);
			this.pnlPQ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.pnlPQ.Location = new System.Drawing.Point(3, 2);
			this.pnlPQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlPQ.Name = "pnlPQ";
			this.pnlPQ.Size = new System.Drawing.Size(222, 47);
			this.pnlPQ.TabIndex = 89;
			// 
			// r
			// 
			this.r.BackColor = System.Drawing.Color.Transparent;
			this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.r.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.r.Location = new System.Drawing.Point(17, 17);
			this.r.Name = "r";
			this.r.Size = new System.Drawing.Size(156, 27);
			this.r.TabIndex = 90;
			this.r.Text = "guna2HtmlLabel1";
			// 
			// tsPQ
			// 
			this.tsPQ.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tsPQ.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tsPQ.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsPQ.CheckedState.InnerColor = System.Drawing.Color.White;
			this.tsPQ.Location = new System.Drawing.Point(179, 22);
			this.tsPQ.Name = "tsPQ";
			this.tsPQ.Size = new System.Drawing.Size(40, 22);
			this.tsPQ.TabIndex = 91;
			this.tsPQ.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.tsPQ.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.tsPQ.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsPQ.UncheckedState.InnerColor = System.Drawing.Color.White;
			// 
			// btnLuuQuyen
			// 
			this.btnLuuQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnLuuQuyen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
			this.btnLuuQuyen.BorderRadius = 12;
			this.btnLuuQuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLuuQuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLuuQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLuuQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLuuQuyen.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnLuuQuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLuuQuyen.ForeColor = System.Drawing.Color.White;
			this.btnLuuQuyen.Location = new System.Drawing.Point(1107, 35);
			this.btnLuuQuyen.Name = "btnLuuQuyen";
			this.btnLuuQuyen.Size = new System.Drawing.Size(134, 39);
			this.btnLuuQuyen.TabIndex = 85;
			this.btnLuuQuyen.Text = "Save";
			this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
			// 
			// cboVaiTroPQ
			// 
			this.cboVaiTroPQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.cboVaiTroPQ.BorderRadius = 12;
			this.cboVaiTroPQ.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboVaiTroPQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboVaiTroPQ.FillColor = System.Drawing.Color.LightGray;
			this.cboVaiTroPQ.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboVaiTroPQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboVaiTroPQ.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboVaiTroPQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboVaiTroPQ.ItemHeight = 30;
			this.cboVaiTroPQ.Location = new System.Drawing.Point(157, 35);
			this.cboVaiTroPQ.Name = "cboVaiTroPQ";
			this.cboVaiTroPQ.Size = new System.Drawing.Size(186, 36);
			this.cboVaiTroPQ.TabIndex = 78;
			this.cboVaiTroPQ.SelectedIndexChanged += new System.EventHandler(this.cboVaiTroPQ_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(23, 35);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(128, 25);
			this.label18.TabIndex = 69;
			this.label18.Text = "Chọn vai trò: ";
			// 
			// tabLichSu
			// 
			this.tabLichSu.BackColor = System.Drawing.Color.Black;
			this.tabLichSu.Controls.Add(this.guna2Panel10);
			this.tabLichSu.Location = new System.Drawing.Point(4, 44);
			this.tabLichSu.Name = "tabLichSu";
			this.tabLichSu.Size = new System.Drawing.Size(1557, 903);
			this.tabLichSu.TabIndex = 2;
			this.tabLichSu.Text = "Lịch Sử";
			// 
			// guna2Panel10
			// 
			this.guna2Panel10.AutoSize = true;
			this.guna2Panel10.BackColor = System.Drawing.Color.Black;
			this.guna2Panel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Panel10.BorderRadius = 20;
			this.guna2Panel10.BorderThickness = 2;
			this.guna2Panel10.Controls.Add(this.lblFillerLS);
			this.guna2Panel10.Controls.Add(this.dgvLichSu);
			this.guna2Panel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel10.Location = new System.Drawing.Point(84, 32);
			this.guna2Panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel10.Name = "guna2Panel10";
			this.guna2Panel10.Size = new System.Drawing.Size(1416, 538);
			this.guna2Panel10.TabIndex = 83;
			// 
			// lblFillerLS
			// 
			this.lblFillerLS.AutoSize = true;
			this.lblFillerLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.lblFillerLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblFillerLS.ForeColor = System.Drawing.Color.White;
			this.lblFillerLS.Location = new System.Drawing.Point(31, 14);
			this.lblFillerLS.Name = "lblFillerLS";
			this.lblFillerLS.Size = new System.Drawing.Size(117, 22);
			this.lblFillerLS.TabIndex = 84;
			this.lblFillerLS.Text = "Tất cả lịch sử";
			// 
			// dgvLichSu
			// 
			this.dgvLichSu.AllowUserToAddRows = false;
			this.dgvLichSu.AllowUserToResizeColumns = false;
			this.dgvLichSu.AllowUserToResizeRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Silver;
			this.dgvLichSu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvLichSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvLichSu.ColumnHeadersHeight = 25;
			this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLichSu.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvLichSu.GridColor = System.Drawing.Color.Gray;
			this.dgvLichSu.Location = new System.Drawing.Point(35, 39);
			this.dgvLichSu.Name = "dgvLichSu";
			this.dgvLichSu.ReadOnly = true;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLichSu.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvLichSu.RowHeadersVisible = false;
			this.dgvLichSu.RowHeadersWidth = 62;
			this.dgvLichSu.RowTemplate.Height = 28;
			this.dgvLichSu.Size = new System.Drawing.Size(1378, 475);
			this.dgvLichSu.TabIndex = 4;
			this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvLichSu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
			this.dgvLichSu.ThemeStyle.GridColor = System.Drawing.Color.Gray;
			this.dgvLichSu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvLichSu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvLichSu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvLichSu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvLichSu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvLichSu.ThemeStyle.HeaderStyle.Height = 25;
			this.dgvLichSu.ThemeStyle.ReadOnly = true;
			this.dgvLichSu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvLichSu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvLichSu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvLichSu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvLichSu.ThemeStyle.RowsStyle.Height = 28;
			this.dgvLichSu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvLichSu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// frmQuanLyTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
			this.ClientSize = new System.Drawing.Size(1565, 1050);
			this.Controls.Add(this.tabMain);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "frmQuanLyTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmQuanLyTaiKhoan";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.tabTaiKhoan.ResumeLayout(false);
			this.tabTaiKhoan.PerformLayout();
			this.guna2Panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
			this.guna2Panel6.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.cardTong.ResumeLayout(false);
			this.cardTong.PerformLayout();
			this.cardBiKhoa.ResumeLayout(false);
			this.cardBiKhoa.PerformLayout();
			this.cardHD.ResumeLayout(false);
			this.cardHD.PerformLayout();
			this.cardVaiTro.ResumeLayout(false);
			this.cardVaiTro.PerformLayout();
			this.tabPhanQuyen.ResumeLayout(false);
			this.tabPhanQuyen.PerformLayout();
			this.flpQuyen.ResumeLayout(false);
			this.flpQuyen.PerformLayout();
			this.pnlPQ.ResumeLayout(false);
			this.pnlPQ.PerformLayout();
			this.tabLichSu.ResumeLayout(false);
			this.tabLichSu.PerformLayout();
			this.guna2Panel10.ResumeLayout(false);
			this.guna2Panel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TabControl tabMain;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabPhanQuyen;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDangHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBiKhoa;
        private Guna.UI2.WinForms.Guna2Panel cardTong;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel cardBiKhoa;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel cardHD;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel cardVaiTro;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox cboVaiTro;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnKhoaTK;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilterVT;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilterTT;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2Button btnLuuQuyen;
        private Guna.UI2.WinForms.Guna2ComboBox cboVaiTroPQ;
        private System.Windows.Forms.FlowLayoutPanel flpQuyen;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDN;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDG;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2Panel pnlPQ;
        private Guna.UI2.WinForms.Guna2HtmlLabel r;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsPQ;
		private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
		private Guna.UI2.WinForms.Guna2DataGridView dgvLichSu;
		private System.Windows.Forms.Label lblFillerLS;
	}
}