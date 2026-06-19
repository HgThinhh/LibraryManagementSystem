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
	public partial class frmInDanhSachTheoNgonNgu : Form
	{
		public frmInDanhSachTheoNgonNgu()
		{
			InitializeComponent();
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			string tenNgonNgu = txtMa.Text.Trim();
			if (string.IsNullOrEmpty(tenNgonNgu))
			{
				MessageBox.Show("Vui lòng nhập tên ngôn ngữ!");
				return;
			}
			LoadBaoCao(tenNgonNgu);
		}

		private void LoadBaoCao(string tenNgonNgu)
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);

			// Lấy thông tin ngôn ngữ
			var nn = db.NgonNgus
					   .Where(n => n.TenNgonNgu.Contains(tenNgonNgu))
					   .FirstOrDefault();

			if (nn == null)
			{
				MessageBox.Show("Không tìm thấy ngôn ngữ!");
				return;
			}

			// Lấy danh sách sách theo ngôn ngữ
			var data = from s in db.Saches
					   join tg in db.TacGias on s.MaTacGia equals tg.MaTacGia
					   join tl in db.TheLoais on s.MaTheLoai equals tl.MaTheLoai
					   join nxb in db.NhaXuatBans on s.MaNXB equals nxb.MaNXB
					   where s.MaNgonNgu == nn.MaNgonNgu
					   select new
					   {
						   nn.MaNgonNgu,
						   TenNgonNgu = nn.TenNgonNgu,
						   s.MaSach,
						   s.TieuDe,
						   s.ISBN,
						   s.NamXuatBan,
						   s.SoTrang,
						   s.SoLuongTon,
						   s.MoTa,
						   TenTacGia = tg.HoTen,
						   TenTheLoai = tl.TenTheLoai,
						   TenNXB = nxb.TenNXB
					   };

			if (!data.Any())
			{
				MessageBox.Show("Không có sách nào theo ngôn ngữ này!");
				return;
			}

			// Tạo DataTable cho Crystal Report
			DataTable dt = new DataTable("SachTheoNgonNgu");
			dt.Columns.Add("MaNgonNgu");
			dt.Columns.Add("TenNgonNgu");
			dt.Columns.Add("MaSach");
			dt.Columns.Add("TieuDe");
			dt.Columns.Add("ISBN");
			dt.Columns.Add("NamXuatBan", typeof(int));
			dt.Columns.Add("SoTrang", typeof(int));
			dt.Columns.Add("SoLuongTon", typeof(int));
			dt.Columns.Add("MoTa");
			dt.Columns.Add("TenTacGia");
			dt.Columns.Add("TenTheLoai");
			dt.Columns.Add("TenNXB");

			foreach (var item in data)
			{
				dt.Rows.Add(item.MaNgonNgu, item.TenNgonNgu, item.MaSach, item.TieuDe,
							item.ISBN, item.NamXuatBan, item.SoTrang, item.SoLuongTon,
							item.MoTa, item.TenTacGia, item.TenTheLoai, item.TenNXB);
			}

			// Load Crystal Report
			InDanhSachSachTheoNgonNgu rpt = new InDanhSachSachTheoNgonNgu();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}

		private void frmInDanhSachTheoNgonNgu_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnXuatHoaDon;
		}
	}
}
