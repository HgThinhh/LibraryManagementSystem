using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_ThuVien;
using XuatExcelPDF;

namespace WindowsFormsApp1
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

		private readonly TaiKhoanBUS _bus = new TaiKhoanBUS();
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string mkCu = txtMKCu.Text.Trim();
			string mkMoi = txtMKMoi.Text.Trim();
			string mkXacNhan = txtXN.Text.Trim();

			if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(mkXacNhan))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (mkMoi != mkXacNhan)
			{
				MessageBox.Show("Mật khẩu mới và xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int maTaiKhoan = SessionManager.TaiKhoanHienTai.MaTaiKhoan;

			bool ketQua = _bus.DoiMatKhau(maTaiKhoan, mkCu, mkMoi);

			if (ketQua)
			{
				MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
