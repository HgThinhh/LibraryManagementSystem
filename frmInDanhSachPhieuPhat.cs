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
	public partial class frmInDanhSachPhieuPhat : Form
	{
		public frmInDanhSachPhieuPhat()
		{
			InitializeComponent();
		}

		private void frmInDanhSachPhieuPhat_Load(object sender, EventArgs e)
		{
			LoadBaoCao();
		}

		private void LoadBaoCao()
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);

			// Lấy toàn bộ phí phạt
			var data = from ct in db.ChiTietPhieuTras
					   join pt in db.PhieuTras on ct.MaPhieuTra equals pt.MaPhieuTra
					   join pm in db.PhieuMuons on pt.MaPhieuMuon equals pm.MaPhieuMuon
					   join dg in db.DocGias on pm.MaDocGia equals dg.MaDocGia
					   join s in db.Saches on ct.MaSach equals s.MaSach
					   select new
					   {
						   pt.MaPhieuTra,
						   pt.NgayTra,
						   TongTienPhat = pt.SoTien,
						   dg.MaDocGia,
						   TenDocGia = dg.HoTen,
						   dg.DiaChi,
						   dg.Email,
						   dg.DienThoai,
						   s.MaSach,
						   s.TieuDe,
						   ct.TinhTrang,
						   PhiPhatChiTiet = ct.PhiPhat,
						   ct.GhiChu
					   };

			// Tạo DataTable cho Crystal Report
			DataTable dt = new DataTable("PhiPhat");
			dt.Columns.Add("MaPhieuTra");
			dt.Columns.Add("NgayTra", typeof(DateTime));
			dt.Columns.Add("TongTienPhat", typeof(decimal));
			dt.Columns.Add("MaDocGia");
			dt.Columns.Add("TenDocGia");
			dt.Columns.Add("DiaChi");
			dt.Columns.Add("Email");
			dt.Columns.Add("DienThoai");
			dt.Columns.Add("MaSach");
			dt.Columns.Add("TieuDe");
			dt.Columns.Add("TinhTrang");
			dt.Columns.Add("PhiPhatChiTiet", typeof(decimal));
			dt.Columns.Add("GhiChu");

			foreach (var item in data)
			{
				dt.Rows.Add(item.MaPhieuTra, item.NgayTra, item.TongTienPhat,
							item.MaDocGia, item.TenDocGia, item.DiaChi,
							item.Email, item.DienThoai, item.MaSach,
							item.TieuDe, item.TinhTrang, item.PhiPhatChiTiet,
							item.GhiChu);
			}

			// Load Crystal Report
			InDanhSachPhieuPhat rpt = new InDanhSachPhieuPhat();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}
	}
}
