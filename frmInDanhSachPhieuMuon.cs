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
	public partial class frmInDanhSachPhieuMuon : Form
	{
		public frmInDanhSachPhieuMuon()
		{
			InitializeComponent();
		}

		private void frmInDanhSachPhieuMuon_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnXuatHoaDon;
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			string maPM = txtMa.Text.Trim();
			if (string.IsNullOrEmpty(maPM))
			{
				MessageBox.Show("Vui lòng nhập mã phiếu mượn!");
				return;
			}
			LoadBaoCao(maPM);
		}

		private void LoadBaoCao(string maPM)
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);

			// Lấy thông tin phiếu	 + độc giả + nhân viên
			var phieu = (from pm in db.PhieuMuons
						 join dg in db.DocGias on pm.MaDocGia equals dg.MaDocGia
						 join nv in db.NhanViens on pm.NguoiPhuTrach equals nv.MaNV
						 where pm.MaPhieuMuon == maPM
						 select new
						 {
							 pm.MaPhieuMuon,
							 pm.NgayMuon,
							 pm.HanTra,
							 pm.TrangThai,
							 TenDocGia = dg.HoTen,
							 dg.DiaChi,
							 dg.Email,
							 dg.DienThoai,
							 TenNhanVien = nv.HoTen,
							 nv.ChucVu
						 }).FirstOrDefault();

			if (phieu == null)
			{
				MessageBox.Show("Không tìm thấy phiếu mượn!");
				return;
			}

			// Lấy danh sách sách trong phiếu mượn
			var data = from ct in db.ChiTietPhieuMuons
					   join s in db.Saches on ct.MaSach equals s.MaSach
					   where ct.MaPhieuMuon == maPM
					   select new
					   {
						   phieu.MaPhieuMuon,
						   phieu.NgayMuon,
						   phieu.HanTra,
						   phieu.TrangThai,
						   phieu.TenDocGia,
						   phieu.DiaChi,
						   phieu.Email,
						   phieu.DienThoai,
						   phieu.TenNhanVien,
						   phieu.ChucVu,
						   s.MaSach,
						   s.TieuDe,
						   s.ISBN,
						   s.NamXuatBan
					   };

			// Tạo DataTable cho Crystal Report
			DataTable dt = new DataTable("DataPhieuMuon");
			dt.Columns.Add("MaPhieuMuon");
			dt.Columns.Add("NgayMuon", typeof(DateTime));
			dt.Columns.Add("HanTra", typeof(DateTime));
			dt.Columns.Add("TrangThai");
			dt.Columns.Add("TenDocGia");
			dt.Columns.Add("DiaChi");
			dt.Columns.Add("Email");
			dt.Columns.Add("DienThoai");
			dt.Columns.Add("TenNhanVien");
			dt.Columns.Add("ChucVu");
			dt.Columns.Add("MaSach");
			dt.Columns.Add("TieuDe");
			dt.Columns.Add("ISBN");
			dt.Columns.Add("NamXuatBan", typeof(int));

			foreach (var item in data)
			{
				dt.Rows.Add(item.MaPhieuMuon, item.NgayMuon, item.HanTra, item.TrangThai,
							item.TenDocGia, item.DiaChi, item.Email, item.DienThoai,
							item.TenNhanVien, item.ChucVu,
							item.MaSach, item.TieuDe, item.ISBN, item.NamXuatBan);
			}

			// Load Crystal Report
			InDanhSachPhieuMuon rpt = new InDanhSachPhieuMuon();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}


	}
}
