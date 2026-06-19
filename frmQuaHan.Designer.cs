namespace WindowsFormsApp1
{
    partial class frmQuaHan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuaHan));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnRefeshQH = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.btnXuLyQuaHan = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvQuaHan = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1501, 72);
			this.guna2Panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(44, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Xử Quá Hạn - Tạo Phiếu";
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.AutoSize = true;
			this.guna2Panel3.BorderRadius = 15;
			this.guna2Panel3.BorderThickness = 3;
			this.guna2Panel3.Controls.Add(this.btnRefeshQH);
			this.guna2Panel3.Controls.Add(this.guna2Separator1);
			this.guna2Panel3.Controls.Add(this.btnXuLyQuaHan);
			this.guna2Panel3.Controls.Add(this.guna2Panel2);
			this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel3.Location = new System.Drawing.Point(191, 98);
			this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(1062, 425);
			this.guna2Panel3.TabIndex = 51;
			// 
			// btnRefeshQH
			// 
			this.btnRefeshQH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
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
			this.btnRefeshQH.Location = new System.Drawing.Point(370, 357);
			this.btnRefeshQH.Name = "btnRefeshQH";
			this.btnRefeshQH.Size = new System.Drawing.Size(109, 42);
			this.btnRefeshQH.TabIndex = 53;
			this.btnRefeshQH.Text = "Huỷ";
			this.btnRefeshQH.Click += new System.EventHandler(this.btnRefeshQH_Click_1);
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Separator1.Location = new System.Drawing.Point(103, 319);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(852, 21);
			this.guna2Separator1.TabIndex = 52;
			// 
			// btnXuLyQuaHan
			// 
			this.btnXuLyQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.btnXuLyQuaHan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnXuLyQuaHan.BorderRadius = 13;
			this.btnXuLyQuaHan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXuLyQuaHan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXuLyQuaHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuLyQuaHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXuLyQuaHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnXuLyQuaHan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnXuLyQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnXuLyQuaHan.Image = ((System.Drawing.Image)(resources.GetObject("btnXuLyQuaHan.Image")));
			this.btnXuLyQuaHan.Location = new System.Drawing.Point(513, 357);
			this.btnXuLyQuaHan.Name = "btnXuLyQuaHan";
			this.btnXuLyQuaHan.Size = new System.Drawing.Size(170, 42);
			this.btnXuLyQuaHan.TabIndex = 51;
			this.btnXuLyQuaHan.Text = "Xác Nhận Trả";
			this.btnXuLyQuaHan.Click += new System.EventHandler(this.btnXuLyQuaHan_Click_1);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.AutoSize = true;
			this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.BorderThickness = 3;
			this.guna2Panel2.Controls.Add(this.label6);
			this.guna2Panel2.Controls.Add(this.dgvQuaHan);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.guna2Panel2.Location = new System.Drawing.Point(54, 33);
			this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(954, 269);
			this.guna2Panel2.TabIndex = 50;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(15, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Quá Hạn";
			// 
			// dgvQuaHan
			// 
			this.dgvQuaHan.AllowUserToAddRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgvQuaHan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvQuaHan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuaHan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvQuaHan.ColumnHeadersHeight = 20;
			this.dgvQuaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvQuaHan.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvQuaHan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvQuaHan.Location = new System.Drawing.Point(30, 50);
			this.dgvQuaHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvQuaHan.MultiSelect = false;
			this.dgvQuaHan.Name = "dgvQuaHan";
			this.dgvQuaHan.ReadOnly = true;
			this.dgvQuaHan.RowHeadersVisible = false;
			this.dgvQuaHan.RowHeadersWidth = 62;
			this.dgvQuaHan.RowTemplate.Height = 28;
			this.dgvQuaHan.Size = new System.Drawing.Size(899, 196);
			this.dgvQuaHan.TabIndex = 0;
			this.dgvQuaHan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvQuaHan.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvQuaHan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvQuaHan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvQuaHan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvQuaHan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
			this.dgvQuaHan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvQuaHan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvQuaHan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvQuaHan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvQuaHan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvQuaHan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvQuaHan.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvQuaHan.ThemeStyle.ReadOnly = true;
			this.dgvQuaHan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvQuaHan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvQuaHan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dgvQuaHan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvQuaHan.ThemeStyle.RowsStyle.Height = 28;
			this.dgvQuaHan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvQuaHan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// frmQuaHan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1501, 679);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "frmQuaHan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmQuaHan";
			this.Load += new System.EventHandler(this.frmQuaHan_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnRefeshQH;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnXuLyQuaHan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQuaHan;
    }
}