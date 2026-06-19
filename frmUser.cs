using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace WindowsFormsApp1
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

		

		private void pnlDoiMatKhau_Click(object sender, EventArgs e)
		{
			var frm = new frmDoiMatKhau();
			frm.Show(); // không dùng ShowDialog
			this.Close(); // đóng frmUser để không nằm phía sau
		}

		private void pnlLichSuDangNhap_Click(object sender, EventArgs e)
		{
			var frm = new frmQuanLyTaiKhoan();

			// Chọn tab Lịch Sử (ví dụ tab index = 2)
			frm.TaiKhoanTabControl.SelectedTab = frm.TaiKhoanTabControl.TabPages["tabLichSu"];

			frm.ShowDialog();
		}

		private void pnlDangXuat_Click(object sender, EventArgs e)
		{
			var frm = new frmDangNhap();
			frm.Show();

		}

		private void pnlDangXuat_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}

