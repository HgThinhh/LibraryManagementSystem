using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_ThuVien;
using XuatExcelPDF;

namespace WindowsFormsApp1
{
	public partial class frmDangNhap : Form
	{
		private readonly TaiKhoanBUS _bus = new TaiKhoanBUS();
		private int _soLanSai = 0;
		private const int MAX_SAI = 5;
		private const string REMEMBER_FILE = "remember.ini";
		private string _vaiTroDangChon = "Admin";
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
			DocGhiNhoTK();
			txtTenDangNhap.Focus();
		}

		private void ChonVaiTro(string vaiTro)
		{
			_vaiTroDangChon = vaiTro;
			txtTenDangNhap.Focus();
		}
		private void btnAdmin_Click(object sender, EventArgs e)
		{
			ChonVaiTro("Admin");
		}

		private void btnThuthu_Click(object sender, EventArgs e)
		{
			ChonVaiTro("ThuThu");
		}

		private void btnDocGia_Click(object sender, EventArgs e)
		{
			ChonVaiTro("DocGia");
		}

		private void btnHienMK_Click(object sender, EventArgs e)
		{
			if (txtMatKhau.PasswordChar == '*')
			{
				txtMatKhau.PasswordChar = '\0'; 
			}
			else
			{
				txtMatKhau.PasswordChar = '*';  
			}
		}

		private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) ThucHienDangNhap();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			ThucHienDangNhap();
		}

		private void ThucHienDangNhap()
		{
			if (_soLanSai >= MAX_SAI)
			{
				lblLoi.Text = " Tài khoản bị tạm khóa! Vui lòng liên hệ Admin.";
				return;
			}

			string tenDN = txtTenDangNhap.Text.Trim();
			string mk = txtMatKhau.Text;

			if (string.IsNullOrEmpty(tenDN)) { lblLoi.Text = " Vui lòng nhập tên đăng nhập!"; return; }
			if (string.IsNullOrEmpty(mk)) { lblLoi.Text = "Vui lòng nhập mật khẩu!"; return; }

			string ketQua = _bus.DangNhap(tenDN, mk);

			if (ketQua == "OK")
			{
				string vaiTroTK = SessionManager.TaiKhoanHienTai?.TenVaiTro ?? "";
				if (_vaiTroDangChon != "Admin" && vaiTroTK != _vaiTroDangChon)
				{
					_soLanSai++;
					lblLoi.Text = $" Tài khoản này không có quyền '{_vaiTroDangChon}'! Còn {MAX_SAI - _soLanSai} lần.";
					SessionManager.DangXuat();
					return;
				}

				_soLanSai = 0;
				LuuGhiNho(tenDN);
				ChuyenFormChinh();
			}
			else
			{
				_soLanSai++;
				lblLoi.Text = MAX_SAI - _soLanSai > 0
					? $" Sai tên đăng nhập hoặc mật khẩu! Còn {MAX_SAI - _soLanSai} lần thử."
					: " Tài khoản bị tạm khóa! Vui lòng liên hệ Admin.";
				txtMatKhau.Clear();
				txtMatKhau.Focus();

				if (_soLanSai >= MAX_SAI)
				{
					btnDangNhap.Enabled = false;
					btnDangNhap.Text = "Tài khoản tạm khóa";
				}
			}
		}
		private void ChuyenFormChinh()
		{
			string vaiTro = SessionManager.TaiKhoanHienTai?.TenVaiTro ?? "";
			Form formChinh = new Main(); 

			this.Hide();
			formChinh.Show();
			formChinh.FormClosed += (s, e) => Application.Exit();
		}

		// Ghi nhớ tài khoản
		private string RememberPath => Path.Combine(Application.UserAppDataPath, REMEMBER_FILE);

		private void LuuGhiNho(string tenDN)
		{
			Directory.CreateDirectory(Path.GetDirectoryName(RememberPath));
			if (chkGhiNho.Checked)
				File.WriteAllText(RememberPath, tenDN);
			else if (File.Exists(RememberPath))
				File.Delete(RememberPath);
		}

		private void DocGhiNhoTK()
		{
			if (!File.Exists(RememberPath)) return;
			string tenDN = File.ReadAllText(RememberPath).Trim();
			if (!string.IsNullOrEmpty(tenDN))
			{
				txtTenDangNhap.Text = tenDN;
				chkGhiNho.Checked = true;
			}
		}
	}
}
