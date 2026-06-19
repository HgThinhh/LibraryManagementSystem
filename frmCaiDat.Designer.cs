namespace WindowsFormsApp1
{
    partial class frmCaiDat
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
            this.flpCaiDat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpCaiDat
            // 
            this.flpCaiDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCaiDat.Location = new System.Drawing.Point(0, 0);
            this.flpCaiDat.Name = "flpCaiDat";
            this.flpCaiDat.Size = new System.Drawing.Size(800, 450);
            this.flpCaiDat.TabIndex = 0;
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpCaiDat);
            this.Name = "frmCaiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCaiDat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCaiDat;
    }
}