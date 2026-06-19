using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAl_ThuVien;

namespace WindowsFormsApp1
{
	public partial class frmInDanhSachSachTheoTenTacGia : Form
	{
		public frmInDanhSachSachTheoTenTacGia()
		{
			InitializeComponent();
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			string tenTG = txtMa.Text.Trim();
			if (string.IsNullOrEmpty(tenTG))
			{
				MessageBox.Show("Vui lòng nhập tên tác giả!");
				return;
			}
			LoadBaoCao(tenTG);
		}

		private void LoadBaoCao(string tenTG)
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);

			// Lấy thông tin tác giả
			var tg = db.TacGias
					   .Where(t => t.HoTen.Contains(tenTG))
					   .FirstOrDefault();

			if (tg == null)
			{
				MessageBox.Show("Không tìm thấy tác giả!");
				return;
			}

			// Lấy danh sách sách theo tác giả
			var data = from s in db.Saches
					   join tl in db.TheLoais on s.MaTheLoai equals tl.MaTheLoai
					   join nxb in db.NhaXuatBans on s.MaNXB equals nxb.MaNXB
					   where s.MaTacGia == tg.MaTacGia
					   select new
					   {
						   tg.MaTacGia,
						   TenTacGia = tg.HoTen,
						   tg.NamSinh,
						   tg.NamMat,
						   tg.QuocTich,
						   s.MaSach,
						   s.TieuDe,
						   s.ISBN,
						   s.NamXuatBan,
						   s.SoTrang,
						   s.SoLuongTon,
						   s.MoTa,
						   TenTheLoai = tl.TenTheLoai,
						   TenNXB = nxb.TenNXB
					   };

			// Tạo DataTable cho Crystal Report
			DataTable dt = new DataTable("SachTheoTacGia");
			dt.Columns.Add("MaTacGia");
			dt.Columns.Add("TenTacGia");
			dt.Columns.Add("NamSinh", typeof(int));
			dt.Columns.Add("NamMat", typeof(int));
			dt.Columns.Add("QuocTich");
			dt.Columns.Add("MaSach");
			dt.Columns.Add("TieuDe");
			dt.Columns.Add("ISBN");
			dt.Columns.Add("NamXuatBan", typeof(int));
			dt.Columns.Add("SoTrang", typeof(int));
			dt.Columns.Add("SoLuongTon", typeof(int));
			dt.Columns.Add("MoTa");
			dt.Columns.Add("TenTheLoai");
			dt.Columns.Add("TenNXB");

			foreach (var item in data)
			{
				dt.Rows.Add(item.MaTacGia, item.TenTacGia, item.NamSinh, item.NamMat,
							item.QuocTich, item.MaSach, item.TieuDe, item.ISBN,
							item.NamXuatBan, item.SoTrang, item.SoLuongTon,
							item.MoTa, item.TenTheLoai, item.TenNXB);
			}

			// Load Crystal Report
			InDanhSachSachTheoTacGia rpt = new InDanhSachSachTheoTacGia();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}

		private void frmInDanhSachSachTheoTenTacGia_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnXuatHoaDon;
		}
	}
}
