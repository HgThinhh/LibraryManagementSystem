namespace WindowsFormsApp1
{
	partial class ucTimKiem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlKetQua = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTag = new System.Windows.Forms.Label();
			this.lblSub = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblIcon = new System.Windows.Forms.Label();
			this.pnlKetQua.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlKetQua
			// 
			this.pnlKetQua.BackColor = System.Drawing.Color.Black;
			this.pnlKetQua.BorderColor = System.Drawing.Color.White;
			this.pnlKetQua.BorderRadius = 15;
			this.pnlKetQua.BorderThickness = 2;
			this.pnlKetQua.Controls.Add(this.lblTag);
			this.pnlKetQua.Controls.Add(this.lblSub);
			this.pnlKetQua.Controls.Add(this.lblTitle);
			this.pnlKetQua.Controls.Add(this.lblIcon);
			this.pnlKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlKetQua.Location = new System.Drawing.Point(0, 0);
			this.pnlKetQua.Name = "pnlKetQua";
			this.pnlKetQua.Size = new System.Drawing.Size(428, 81);
			this.pnlKetQua.TabIndex = 0;
			// 
			// lblTag
			// 
			this.lblTag.AutoSize = true;
			this.lblTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTag.Location = new System.Drawing.Point(329, 28);
			this.lblTag.Name = "lblTag";
			this.lblTag.Size = new System.Drawing.Size(51, 20);
			this.lblTag.TabIndex = 0;
			this.lblTag.Text = "label1";
			// 
			// lblSub
			// 
			this.lblSub.AutoSize = true;
			this.lblSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSub.Location = new System.Drawing.Point(216, 28);
			this.lblSub.Name = "lblSub";
			this.lblSub.Size = new System.Drawing.Size(51, 20);
			this.lblSub.TabIndex = 0;
			this.lblSub.Text = "label1";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTitle.Location = new System.Drawing.Point(85, 28);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(51, 20);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
			// 
			// lblIcon
			// 
			this.lblIcon.AutoSize = true;
			this.lblIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblIcon.Location = new System.Drawing.Point(19, 28);
			this.lblIcon.Name = "lblIcon";
			this.lblIcon.Size = new System.Drawing.Size(51, 20);
			this.lblIcon.TabIndex = 0;
			this.lblIcon.Text = "label1";
			// 
			// ucTimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlKetQua);
			this.Name = "ucTimKiem";
			this.Size = new System.Drawing.Size(428, 81);
			this.Click += new System.EventHandler(this.ucTimKiem_Click);
			this.pnlKetQua.ResumeLayout(false);
			this.pnlKetQua.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel pnlKetQua;
		private System.Windows.Forms.Label lblTag;
		private System.Windows.Forms.Label lblSub;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblIcon;
	}
}
