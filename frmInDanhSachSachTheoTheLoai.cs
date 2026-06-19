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
	public partial class frmInDanhSachSachTheoTheLoai : Form
	{
		public frmInDanhSachSachTheoTheLoai()
		{
			InitializeComponent();
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			string maTL = txtMa.Text.Trim();
			if (string.IsNullOrEmpty(maTL))
			{
				MessageBox.Show("Vui lòng nhập mã thể loại!");
				return;
			}
			LoadBaoCao(maTL);
		}

		private void LoadBaoCao(string maTL)
		{
			QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext(DBConnect.conn);
			var tenTL = db.TheLoais
						  .Where(t => t.MaTheLoai == maTL)
						  .Select(t => t.TenTheLoai)
						  .FirstOrDefault();

			var data = from s in db.Saches
					   where s.MaTheLoai == maTL
					   select new
					   {
						   s.MaSach,
						   s.TieuDe,
						   s.ISBN,
						   s.NamXuatBan,
						   s.SoTrang,
						   s.SoLuongTon,
						   s.MoTa,
						   s.MaTheLoai,
						   TenTheLoai = tenTL
					   };

			DataTable dt = new DataTable("SachTheoTheLoai");
			dt.Columns.Add("MaSach");
			dt.Columns.Add("TieuDe");
			dt.Columns.Add("ISBN");
			dt.Columns.Add("NamXuatBan");
			dt.Columns.Add("SoTrang");
			dt.Columns.Add("SoLuongTon");
			dt.Columns.Add("MoTa");
			dt.Columns.Add("MaTheLoai");
			dt.Columns.Add("TenTheLoai");

			foreach (var item in data)
				dt.Rows.Add(item.MaSach, item.TieuDe, item.ISBN, item.NamXuatBan,
							item.SoTrang, item.SoLuongTon, item.MoTa, item.MaTheLoai, item.TenTheLoai);

			InDanhSachSachTheoTheLoai rpt = new InDanhSachSachTheoTheLoai();
			rpt.SetDataSource(dt);
			crystalReportViewer1.ReportSource = rpt;
		}

		private void btnXuatHoaDon_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnXuatHoaDon.PerformClick();

				e.SuppressKeyPress = true;
			}
		}

		private void frmInDanhSachSachTheoTheLoai_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnXuatHoaDon;
		}
	}
}
