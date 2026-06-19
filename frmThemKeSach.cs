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
using ET_ThuVien;

namespace WindowsFormsApp1
{
	public partial class frmThemKeSach : Form
	{
		public frmThemKeSach()
		{
			InitializeComponent();
		}

		BUS_THELOAI bus = new BUS_THELOAI();
		public string maKe;
		public frmThemKeSach(string maKe)
		{
			InitializeComponent();
			this.maKe = maKe;

			// Load dữ liệu kệ cần sửa
			BUS_KeSach ks = new BUS_KeSach();
			ET_KeSach ke = ks.LayKeTheoMa(maKe); // bạn cần có hàm này trong BUS/DAL

			if (ke != null)
			{
				txtMaKe.Text = ke.MaKe;
				txtTenKe.Text = ke.TenKe;
				txtViTri.Text = ke.ViTri;
				cboTheLoai.SelectedValue = ke.MaTheLoai;
				txtSoLuong.Text = ke.SoLuongSach.ToString();
				txtHinhAnh.Text = ke.HinhAnh;
				txtGhiChu.Text = ke.MoTa;
			}
		}

		private void frmThemKeSach_Load_1(object sender, EventArgs e)
		{

			cboTheLoai.DataSource = bus.LayDSTheLoai();
			cboTheLoai.DisplayMember = "TenTheLoai";
			cboTheLoai.ValueMember = "MaTheLoai";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			BUS_KeSach ks = new BUS_KeSach();

			// Tạo đối tượng ET_KeSach từ dữ liệu nhập
			ET_KeSach ke = new ET_KeSach(
				txtMaKe.Text.Trim(),
				txtTenKe.Text.Trim(),
				txtViTri.Text.Trim(),
				cboTheLoai.SelectedValue.ToString(),
				int.TryParse(txtSoLuong.Text, out int soLuong) ? soLuong : 0,
				txtHinhAnh.Text.Trim(),
				txtGhiChu.Text.Trim()
			);

			bool result = false;

			if (string.IsNullOrEmpty(maKe)) // thêm mới
			{
				result = ks.ThemKe(ke);
				if (result)
				{
					MessageBox.Show("Thêm kệ thành công!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Thêm kệ thất bại!");
				}
			}
			else // sửa
			{
				result = ks.SuaKe(ke);
				if (result)
				{
					MessageBox.Show("Sửa kệ thành công!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Sửa kệ thất bại!");
				}
			}
		}

		private void btnRefeshQH_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
