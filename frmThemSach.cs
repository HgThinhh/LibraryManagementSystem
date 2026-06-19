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
using DAl_ThuVien;
using ET_ThuVien.ET_ThuVien.ET_ThuVien;
using System.Data.Linq;


namespace WindowsFormsApp1
{
	public partial class frmThemSach : Form
	{
		SachBUS bs = new SachBUS();
		private string _maSach;
		QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);
		public frmThemSach(string maSach = null)
		{
			InitializeComponent();
			_maSach = maSach;
		}

		private void frmThemSach_Load(object sender, EventArgs e)
		{

			// Load NXB
			cboNXB.DataSource = db.NhaXuatBans.ToList();
			cboNXB.DisplayMember = "TenNXB";
			cboNXB.ValueMember = "MaNXB";

			// Load Ngôn ngữ
			cboNgonNgu.DataSource = db.NgonNgus.ToList();
			cboNgonNgu.DisplayMember = "TenNgonNgu";
			cboNgonNgu.ValueMember = "MaNgonNgu";

			// Load Tác giả
			cboTacGia.DataSource = db.TacGias.ToList();
			cboTacGia.DisplayMember = "HoTen";
			cboTacGia.ValueMember = "MaTacGia";

			// Load Kho
			cboKho.DataSource = db.Khos.ToList();
			cboKho.DisplayMember = "TenKho";
			cboKho.ValueMember = "MaKho";

			// Load Kệ
			cboKeSach.DataSource = db.KeSaches.ToList();
			cboKeSach.DisplayMember = "TenKe";
			cboKeSach.ValueMember = "MaKe";

			// Load Thể loại
			cboTheLoai.DataSource = db.TheLoais.ToList();
			cboTheLoai.DisplayMember = "TenTheLoai";
			cboTheLoai.ValueMember = "MaTheLoai";

			if (!string.IsNullOrEmpty(_maSach))
			{
				// Load dữ liệu để sửa
				var sach = bs.GetById(_maSach);
				if (sach != null)
				{
					txtMaSach.Text = sach.MaSach;
					txtTieuDe.Text = sach.TieuDe;
					txtISBN.Text = sach.ISBN;
					numNXB.Value = sach.NamXuatBan;
					numSoTrang.Value = sach.SoTrang;
					numSoLuong.Value = sach.SoLuongTon;
					txtMoTa.Text = sach.MoTa;

					cboNXB.SelectedValue = sach.MaNXB;
					cboNgonNgu.SelectedValue = sach.MaNgonNgu;
					cboTacGia.SelectedValue = sach.MaTacGia;
					cboKho.SelectedValue = sach.MaKho;
					cboKeSach.SelectedValue = sach.MaKe;
					cboTheLoai.SelectedValue = sach.MaTheLoai;

					txtMaSach.Enabled = false; 
				}
			}

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var s = new SachET
			{
				MaSach = txtMaSach.Text.Trim(),
				TieuDe = txtTieuDe.Text.Trim(),
				ISBN = txtISBN.Text.Trim(),
				NamXuatBan = (int)numNXB.Value,
				SoTrang = (int)numSoTrang.Value,
				SoLuongTon = (int)numSoLuong.Value,
				MoTa = txtMoTa.Text.Trim(),
				MaNXB = cboNXB.SelectedValue?.ToString(),
				MaNgonNgu = cboNgonNgu.SelectedValue?.ToString(),
				MaTacGia = cboTacGia.SelectedValue?.ToString(),
				MaKho = cboKho.SelectedValue?.ToString(),
				MaKe = cboKeSach.SelectedValue?.ToString(),
				MaTheLoai = cboTheLoai.SelectedValue?.ToString()
			};

			if (string.IsNullOrEmpty(_maSach))
			{
				// Thêm mới
				var result = bs.Them(s);
				MessageBox.Show(result.msg);
				if (result.ok) this.Close();
			}
			else
			{
				// Cập nhật
				var result = bs.CapNhat(s);
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
