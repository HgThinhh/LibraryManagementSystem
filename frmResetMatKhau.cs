using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmResetMatKhau : Form
    {

        public string TenDangNhap { get; set; }
        public string MatKhauMoi { get; private set; }
        public frmResetMatKhau(string tenDangNhap)
        {
            InitializeComponent();
            TenDangNhap = tenDangNhap;
            lblTenDangNhap.Text = tenDangNhap; 
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MatKhauMoi = txtMK.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
