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
using DocumentFormat.OpenXml.Office2010.Drawing;
using ET_ThuVien;

namespace WindowsFormsApp1
{
	public partial class frmThemTheThuVien : Form
	{

		TheThuVienBUS bus = new TheThuVienBUS();
		private string _maDocGia;
		private string _maThe;
		public frmThemTheThuVien(string maDocGia)
		{
			InitializeComponent();
			_maDocGia = maDocGia;
		}

		public frmThemTheThuVien(string maDocGia, string maThe)
		{
			InitializeComponent();
			_maDocGia = maDocGia;
			_maThe = maThe; 
		}

		private void frmThemTheThuVien_Load(object sender, EventArgs e)
		{
			txtMaDocGia.Text = _maDocGia;
			txtMaDocGia.Enabled = false; // không cho sửa

			dtNgayCap.Value = DateTime.Now;
			dtHetHan.Value = DateTime.Now.AddYears(1);

			cboTrangThai.Items.Clear();
			cboTrangThai.Items.Add("Còn hiệu lực");
			cboTrangThai.Items.Add("Hết hạn");
			cboTrangThai.Items.Add("Bị khóa");
			cboTrangThai.Text = "Còn hiệu lực";

			if (!string.IsNullOrEmpty(_maThe))
			{
				// Đã có thẻ → load dữ liệu để sửa
				var existing = bus.GetByDocGia(_maDocGia);
				if (existing != null)
				{
					txtMaThe.Text = existing.MaThe;
					dtNgayCap.Value = existing.NgayCap ?? DateTime.Now;
					dtHetHan.Value = existing.NgayHetHan ?? DateTime.Now;
					cboTrangThai.Text = existing.TrangThai;
				}
			}
			else
			{
				// Chưa có thẻ → để trống, nhập mới
				txtMaThe.Text = "";
				dtNgayCap.Value = DateTime.Now;
				dtHetHan.Value = DateTime.Now.AddYears(1);
				cboTrangThai.SelectedIndex = 0;
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var the = new TheThuVienET
			{
				MaThe = txtMaThe.Text.Trim(),
				MaDocGia = _maDocGia,
				NgayCap = dtNgayCap.Value,
				NgayHetHan = dtHetHan.Value,
				TrangThai = cboTrangThai.Text
			};

			if (string.IsNullOrEmpty(_maThe))
			{
				// chưa có thẻ → thêm mới
				var result = bus.Them(the);
				MessageBox.Show(result.msg);
				if (result.ok) this.Close();
			}
			else
			{
				// đã có thẻ → cập nhật
				var result = bus.CapNhat(the);
				MessageBox.Show(result.msg);
				if (result.ok) this.Close();
			}
		}

		private void btnRefeshQH_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
