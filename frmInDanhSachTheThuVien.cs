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
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace WindowsFormsApp1
{
	public partial class frmInDanhSachTheThuVien : Form
	{
		public frmInDanhSachTheThuVien()
		{
			InitializeComponent();
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			string maThe = txtMa.Text.Trim();
			if (string.IsNullOrEmpty(maThe))
			{
				MessageBox.Show("Vui lòng nhập mã thẻ!");
				return;
			}
			LoadBaoCao(maThe);
		}

		private void LoadBaoCao(string maThe)
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);

			// Lấy thông tin thẻ + độc giả
			var data = from t in db.TheThuViens
					   join dg in db.DocGias on t.MaDocGia equals dg.MaDocGia
					   where t.MaThe == maThe
					   select new
					   {
						   t.MaThe,
						   t.NgayCap,
						   t.NgayHetHan,
						   t.TrangThai,
						   dg.MaDocGia,
						   TenDocGia = dg.HoTen,
						   dg.DiaChi,
						   dg.Email,
						   dg.DienThoai
					   };

			if (!data.Any())
			{
				MessageBox.Show("Không tìm thấy thẻ thư viện!");
				return;
			}

			// Tạo DataTable cho Crystal Report
			DataTable dt = new DataTable("TheThuVien");
			dt.Columns.Add("MaThe");
			dt.Columns.Add("NgayCap", typeof(DateTime));
			dt.Columns.Add("NgayHetHan", typeof(DateTime));
			dt.Columns.Add("TrangThai");
			dt.Columns.Add("MaDocGia");
			dt.Columns.Add("TenDocGia");
			dt.Columns.Add("DiaChi");
			dt.Columns.Add("Email");
			dt.Columns.Add("DienThoai");

			foreach (var item in data)
			{
				dt.Rows.Add(item.MaThe, item.NgayCap, item.NgayHetHan, item.TrangThai,
							item.MaDocGia, item.TenDocGia, item.DiaChi,
							item.Email, item.DienThoai);
			}

			// Load Crystal Report
			InDanhSachTheThuVien rpt = new InDanhSachTheThuVien();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}

		private void frmInDanhSachTheThuVien_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnXuatHoaDon;
		}
	}
}
