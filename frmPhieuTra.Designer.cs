namespace WindowsFormsApp1
{
    partial class frmPhieuTra
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
			this.label18 = new System.Windows.Forms.Label();
			this.dgvPhieuTra = new Guna.UI2.WinForms.Guna2DataGridView();
			this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvSachTra = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblDocGia = new System.Windows.Forms.Label();
			this.lblNgayMuon = new System.Windows.Forms.Label();
			this.lblHanTra = new System.Windows.Forms.Label();
			this.lblSoNgayTre = new System.Windows.Forms.Label();
			this.dtpNgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnTimPhieu = new Guna.UI2.WinForms.Guna2Button();
			this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
			this.lblDangMuon = new System.Windows.Forms.Label();
			this.lblDaTra = new System.Windows.Forms.Label();
			this.lblQuaHan = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).BeginInit();
			this.guna2Panel3.SuspendLayout();
			this.guna2Panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1400, 72);
			this.guna2Panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(44, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Xử Lý Trả - Tạo Phiếu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Chọn Phiếu Mượn";
			// 
			// cboNhanVien
			// 
			this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
			this.cboNhanVien.BorderRadius = 12;
			this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNhanVien.FillColor = System.Drawing.Color.LightGray;
			this.cboNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cboNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cboNhanVien.ItemHeight = 30;
			this.cboNhanVien.Location = new System.Drawing.Point(64, 41);
			this.cboNhanVien.Name = "cboNhanVien";
			this.cboNhanVien.Size = new System.Drawing.Size(264, 36);
			this.cboNhanVien.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(60, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 20);
			this.label4.TabIndex = 33;
			this.label4.Text = "Nhân Viện Phụ Trách";
			// 
			// guna2Panel9
			// 
			this.guna2Panel9.AutoSize = true;
			this.guna2Panel9.BorderRadius = 15;
			this.guna2Panel9.BorderThickness = 3;
			this.guna2Panel9.Controls.Add(this.label18);
			this.guna2Panel9.Controls.Add(this.dgvPhieuTra);
			this.guna2Panel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel9.Location = new System.Drawing.Point(631, 304);
			this.guna2Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel9.Name = "guna2Panel9";
			this.guna2Panel9.Size = new System.Drawing.Size(686, 208);
			this.guna2Panel9.TabIndex = 35;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label18.Location = new System.Drawing.Point(15, 14);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(200, 25);
			this.label18.TabIndex = 1;
			this.label18.Text = "Danh Sách Phiếu Trả";
			// 
			// dgvPhieuTra
			// 
			this.dgvPhieuTra.AllowUserToAddRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.dgvPhieuTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvPhieuTra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPhieuTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvPhieuTra.ColumnHeadersHeight = 20;
			this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPhieuTra.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvPhieuTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvPhieuTra.Location = new System.Drawing.Point(20, 48);
			this.dgvPhieuTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvPhieuTra.MultiSelect = false;
			this.dgvPhieuTra.Name = "dgvPhieuTra";
			this.dgvPhieuTra.ReadOnly = true;
			this.dgvPhieuTra.RowHeadersVisible = false;
			this.dgvPhieuTra.RowHeadersWidth = 62;
			this.dgvPhieuTra.RowTemplate.Height = 28;
			this.dgvPhieuTra.Size = new System.Drawing.Size(630, 144);
			this.dgvPhieuTra.TabIndex = 0;
			this.dgvPhieuTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPhieuTra.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPhieuTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPhieuTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPhieuTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPhieuTra.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dgvPhieuTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPhieuTra.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvPhieuTra.ThemeStyle.ReadOnly = true;
			this.dgvPhieuTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPhieuTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPhieuTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvPhieuTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPhieuTra.ThemeStyle.RowsStyle.Height = 28;
			this.dgvPhieuTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPhieuTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.txtGhiChu.BorderRadius = 12;
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
			this.txtGhiChu.Location = new System.Drawing.Point(64, 105);
			this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.PlaceholderText = "";
			this.txtGhiChu.SelectedText = "";
			this.txtGhiChu.Size = new System.Drawing.Size(537, 69);
			this.txtGhiChu.TabIndex = 36;
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTongTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTongTien.Location = new System.Drawing.Point(52, 573);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(111, 20);
			this.lblTongTien.TabIndex = 38;
			this.lblTongTien.Text = "Tổng tiền phạt";
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.Black;
			this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnHuy.BorderRadius = 15;
			this.btnHuy.BorderThickness = 1;
			this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnHuy.Location = new System.Drawing.Point(850, 625);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(109, 42);
			this.btnHuy.TabIndex = 41;
			this.btnHuy.Text = "Huỷ";
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.AutoSize = true;
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.BorderThickness = 3;
			this.guna2Panel2.Controls.Add(this.label6);
			this.guna2Panel2.Controls.Add(this.dgvSachTra);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel2.Location = new System.Drawing.Point(16, 302);
			this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(576, 208);
			this.guna2Panel2.TabIndex = 45;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(15, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Sách Trả";
			// 
			// dgvSachTra
			// 
			this.dgvSachTra.AllowUserToAddRows = false;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.dgvSachTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvSachTra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSachTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvSachTra.ColumnHeadersHeight = 20;
			this.dgvSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSachTra.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvSachTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvSachTra.Location = new System.Drawing.Point(30, 50);
			this.dgvSachTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvSachTra.MultiSelect = false;
			this.dgvSachTra.Name = "dgvSachTra";
			this.dgvSachTra.ReadOnly = true;
			this.dgvSachTra.RowHeadersVisible = false;
			this.dgvSachTra.RowHeadersWidth = 62;
			this.dgvSachTra.RowTemplate.Height = 28;
			this.dgvSachTra.Size = new System.Drawing.Size(528, 144);
			this.dgvSachTra.TabIndex = 0;
			this.dgvSachTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSachTra.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvSachTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvSachTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvSachTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvSachTra.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dgvSachTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvSachTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvSachTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvSachTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvSachTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvSachTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvSachTra.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvSachTra.ThemeStyle.ReadOnly = true;
			this.dgvSachTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSachTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSachTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvSachTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSachTra.ThemeStyle.RowsStyle.Height = 28;
			this.dgvSachTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSachTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSachTra.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachTra_CellValueChanged);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Separator1.Location = new System.Drawing.Point(-11, 608);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(1354, 14);
			this.guna2Separator1.TabIndex = 40;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.AutoSize = true;
			this.guna2Panel3.BorderRadius = 15;
			this.guna2Panel3.BorderThickness = 3;
			this.guna2Panel3.Controls.Add(this.lblDocGia);
			this.guna2Panel3.Controls.Add(this.dtpNgayTra);
			this.guna2Panel3.Controls.Add(this.lblNgayMuon);
			this.guna2Panel3.Controls.Add(this.lblHanTra);
			this.guna2Panel3.Controls.Add(this.label3);
			this.guna2Panel3.Controls.Add(this.lblSoNgayTre);
			this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel3.Location = new System.Drawing.Point(16, 155);
			this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(576, 132);
			this.guna2Panel3.TabIndex = 46;
			// 
			// lblDocGia
			// 
			this.lblDocGia.AutoSize = true;
			this.lblDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.lblDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDocGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblDocGia.Location = new System.Drawing.Point(20, 11);
			this.lblDocGia.Name = "lblDocGia";
			this.lblDocGia.Size = new System.Drawing.Size(67, 20);
			this.lblDocGia.TabIndex = 37;
			this.lblDocGia.Text = "Độc giả:";
			// 
			// lblNgayMuon
			// 
			this.lblNgayMuon.AutoSize = true;
			this.lblNgayMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblNgayMuon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNgayMuon.Location = new System.Drawing.Point(20, 41);
			this.lblNgayMuon.Name = "lblNgayMuon";
			this.lblNgayMuon.Size = new System.Drawing.Size(93, 20);
			this.lblNgayMuon.TabIndex = 36;
			this.lblNgayMuon.Text = "Ngày Mượn:";
			// 
			// lblHanTra
			// 
			this.lblHanTra.AutoSize = true;
			this.lblHanTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.lblHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblHanTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHanTra.Location = new System.Drawing.Point(20, 72);
			this.lblHanTra.Name = "lblHanTra";
			this.lblHanTra.Size = new System.Drawing.Size(70, 20);
			this.lblHanTra.TabIndex = 35;
			this.lblHanTra.Text = "Hạn Trả:";
			// 
			// lblSoNgayTre
			// 
			this.lblSoNgayTre.AutoSize = true;
			this.lblSoNgayTre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.lblSoNgayTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblSoNgayTre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSoNgayTre.Location = new System.Drawing.Point(23, 105);
			this.lblSoNgayTre.Name = "lblSoNgayTre";
			this.lblSoNgayTre.Size = new System.Drawing.Size(104, 20);
			this.lblSoNgayTre.TabIndex = 34;
			this.lblSoNgayTre.Text = "Số Ngày Trễ: ";
			// 
			// dtpNgayTra
			// 
			this.dtpNgayTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dtpNgayTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.dtpNgayTra.BorderRadius = 12;
			this.dtpNgayTra.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			this.dtpNgayTra.Checked = true;
			this.dtpNgayTra.FillColor = System.Drawing.Color.White;
			this.dtpNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpNgayTra.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayTra.Location = new System.Drawing.Point(276, 41);
			this.dtpNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpNgayTra.Name = "dtpNgayTra";
			this.dtpNgayTra.Size = new System.Drawing.Size(208, 36);
			this.dtpNgayTra.TabIndex = 32;
			this.dtpNgayTra.Value = new System.DateTime(2026, 4, 18, 12, 52, 44, 457);
			this.dtpNgayTra.ValueChanged += new System.EventHandler(this.dtpNgayTra_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(272, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 31;
			this.label3.Text = "Ngày Trả";
			// 
			// txtMaPhieu
			// 
			this.txtMaPhieu.BorderRadius = 12;
			this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaPhieu.DefaultText = "";
			this.txtMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaPhieu.FillColor = System.Drawing.Color.LightGray;
			this.txtMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaPhieu.Location = new System.Drawing.Point(16, 100);
			this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaPhieu.Name = "txtMaPhieu";
			this.txtMaPhieu.PlaceholderText = "";
			this.txtMaPhieu.SelectedText = "";
			this.txtMaPhieu.Size = new System.Drawing.Size(172, 36);
			this.txtMaPhieu.TabIndex = 47;
			// 
			// btnTimPhieu
			// 
			this.btnTimPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnTimPhieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnTimPhieu.BorderRadius = 13;
			this.btnTimPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTimPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTimPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTimPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnTimPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnTimPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnTimPhieu.Image = global::WindowsFormsApp1.Properties.Resources.circle_check_regular1;
			this.btnTimPhieu.Location = new System.Drawing.Point(228, 98);
			this.btnTimPhieu.Name = "btnTimPhieu";
			this.btnTimPhieu.Size = new System.Drawing.Size(155, 42);
			this.btnTimPhieu.TabIndex = 48;
			this.btnTimPhieu.Text = "Xác Nhận";
			this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnXacNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnXacNhan.BorderRadius = 13;
			this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnXacNhan.Image = global::WindowsFormsApp1.Properties.Resources.circle_check_regular1;
			this.btnXacNhan.Location = new System.Drawing.Point(993, 625);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(170, 42);
			this.btnXacNhan.TabIndex = 39;
			this.btnXacNhan.Text = "Xác Nhận Trả";
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// lblDangMuon
			// 
			this.lblDangMuon.AutoSize = true;
			this.lblDangMuon.BackColor = System.Drawing.Color.Black;
			this.lblDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDangMuon.ForeColor = System.Drawing.Color.Blue;
			this.lblDangMuon.Location = new System.Drawing.Point(401, 572);
			this.lblDangMuon.Name = "lblDangMuon";
			this.lblDangMuon.Size = new System.Drawing.Size(124, 25);
			this.lblDangMuon.TabIndex = 49;
			this.lblDangMuon.Text = "Đang mượn: ";
			// 
			// lblDaTra
			// 
			this.lblDaTra.AutoSize = true;
			this.lblDaTra.BackColor = System.Drawing.Color.Black;
			this.lblDaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDaTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblDaTra.Location = new System.Drawing.Point(782, 572);
			this.lblDaTra.Name = "lblDaTra";
			this.lblDaTra.Size = new System.Drawing.Size(64, 25);
			this.lblDaTra.TabIndex = 51;
			this.lblDaTra.Text = "Đã trả";
			// 
			// lblQuaHan
			// 
			this.lblQuaHan.AutoSize = true;
			this.lblQuaHan.BackColor = System.Drawing.Color.Black;
			this.lblQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblQuaHan.ForeColor = System.Drawing.Color.Red;
			this.lblQuaHan.Location = new System.Drawing.Point(1141, 568);
			this.lblQuaHan.Name = "lblQuaHan";
			this.lblQuaHan.Size = new System.Drawing.Size(91, 25);
			this.lblQuaHan.TabIndex = 50;
			this.lblQuaHan.Text = "Quá Hạn";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(401, 538);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 25);
			this.label5.TabIndex = 52;
			this.label5.Text = "Đang mượn: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(44, 539);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 25);
			this.label7.TabIndex = 53;
			this.label7.Text = "Tổng tiền phạt";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label8.Location = new System.Drawing.Point(782, 538);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 25);
			this.label8.TabIndex = 54;
			this.label8.Text = "Đã trả";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Black;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(1141, 538);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 25);
			this.label9.TabIndex = 55;
			this.label9.Text = "Quá Hạn";
			// 
			// guna2Panel4
			// 
			this.guna2Panel4.AutoSize = true;
			this.guna2Panel4.BackColor = System.Drawing.Color.Black;
			this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
			this.guna2Panel4.BorderRadius = 15;
			this.guna2Panel4.BorderThickness = 3;
			this.guna2Panel4.Controls.Add(this.cboNhanVien);
			this.guna2Panel4.Controls.Add(this.txtGhiChu);
			this.guna2Panel4.Controls.Add(this.label4);
			this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel4.Location = new System.Drawing.Point(631, 91);
			this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new System.Drawing.Size(686, 189);
			this.guna2Panel4.TabIndex = 56;
			// 
			// frmPhieuTra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1400, 679);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblDangMuon);
			this.Controls.Add(this.lblDaTra);
			this.Controls.Add(this.lblQuaHan);
			this.Controls.Add(this.btnTimPhieu);
			this.Controls.Add(this.txtMaPhieu);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.guna2Panel9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2Panel4);
			this.Name = "frmPhieuTra";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPhieuTra";
			this.Load += new System.EventHandler(this.frmPhieuTra_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel9.ResumeLayout(false);
			this.guna2Panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).EndInit();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVien;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuTra;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSachTra;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.Label lblSoNgayTre;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieu;
        private Guna.UI2.WinForms.Guna2Button btnTimPhieu;
        private System.Windows.Forms.Label lblDangMuon;
        private System.Windows.Forms.Label lblDaTra;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    }
}