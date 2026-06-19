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
	public partial class frmThemDocGia : Form
	{
		BUS_DocGia bs = new BUS_DocGia();
		private string _maDocGia;
		public frmThemDocGia(string maDocGia = null)
		{
			InitializeComponent();
			_maDocGia = maDocGia;
		}

		private void frmThemDocGia_Load(object sender, EventArgs e)
		{

			//// Thiết lập giới hạn cho DateTimePicker
			//dtpNgaySinh.MinDate = new DateTime(1753, 1, 1);
			//dtpNgaySinh.MaxDate = DateTime.MaxValue;
			//dtpNgayDangKy.MinDate = new DateTime(1753, 1, 1);
			//dtpNgayDangKy.MaxDate = DateTime.MaxValue;

			//// Khi gán giá trị
			//if (dg.NgaySinh.Year < 1753)
			//	dtpNgaySinh.Value = DateTime.Now;
			//else
			//	dtpNgaySinh.Value = dg.NgaySinh;

			//if (dg.NgayDangKy.Year < 1753)
			//	dtpNgayDangKy.Value = DateTime.Now;
			//else
			//	dtpNgayDangKy.Value = dg.NgayDangKy;



			if (!string.IsNullOrEmpty(_maDocGia))	
			{
				// Load dữ liệu để sửa
				var dg = bs.GetById(_maDocGia);
				if (dg != null)
				{
					txtMaDocGia.Text = dg.MaDocGia;
					txtHoTen.Text = dg.HoTen;
					dtpNgayDangKy.Value = dg.NgaySinh;
					txtDiaChi.Text = dg.DiaChi;
					txtDienThoai.Text = dg.DienThoai;
					txtEmail.Text = dg.Email;
					dtpNgayDangKy.Value = dg.NgayDangKy;

					// Tick RadioButton theo giới tính
					if (dg.GioiTinh == "Nam") radNam.Checked = true;
					else if (dg.GioiTinh == "Nữ") radNu.Checked = true;
					else radKhac.Checked = true;

					txtMaDocGia.Enabled = false; // không cho sửa mã
				}
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string gioiTinh = radNam.Checked ? "Nam" :
								  radNu.Checked ? "Nữ" : "Khác";

			var dg = new DocGiaET
			{
				MaDocGia = txtMaDocGia.Text.Trim(),
				HoTen = txtHoTen.Text.Trim(),
				NgaySinh = dtpNgayDangKy.Value,
				GioiTinh = gioiTinh,
				DiaChi = txtDiaChi.Text.Trim(),
				DienThoai = txtDienThoai.Text.Trim(),
				Email = txtEmail.Text.Trim(),
				NgayDangKy = dtpNgayDangKy.Value
			};
				
			if (string.IsNullOrEmpty(_maDocGia))	
			{
				// Thêm mới
				var result = bs.Them(dg);
				MessageBox.Show(result.msg);
				if (result.ok) this.Close();
			}
			else
			{
				// Cập nhật
				var result = bs.CapNhat(dg);
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
