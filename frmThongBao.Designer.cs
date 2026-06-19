namespace WindowsFormsApp1
{
    partial class frmThongBao
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
			this.flpThongBao = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpThongBao
			// 
			this.flpThongBao.AutoScroll = true;
			this.flpThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpThongBao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpThongBao.Location = new System.Drawing.Point(0, 0);
			this.flpThongBao.Name = "flpThongBao";
			this.flpThongBao.Size = new System.Drawing.Size(628, 450);
			this.flpThongBao.TabIndex = 1;
			this.flpThongBao.WrapContents = false;
			// 
			// frmThongBao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(628, 450);
			this.Controls.Add(this.flpThongBao);
			this.Name = "frmThongBao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmThongBao";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpThongBao;
    }
}