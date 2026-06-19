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
using ET_ThuVien;
using ET_ThuVien.ET_ThuVien;
using ET_ThuVien.ET_ThuVien.ET_ThuVien;

namespace WindowsFormsApp1
{
    public partial class MuonTra : Form
    {
        public MuonTra()
        {
            InitializeComponent();
        }
        BUS_PhieuMuonDashBoard db = new BUS_PhieuMuonDashBoard();
        BUS_PhieuMuon _bus = new BUS_PhieuMuon();
        BUS_NhanVien _busNV = new BUS_NhanVien();
       private List<ET_ChiTietPhieuMuon> _dsSachMuon = new List<ET_ChiTietPhieuMuon>();

        private void MuonTra_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadChart();
            LoadDanhSachPhieuMuon();
            LoadSach();

            var dsNV = _busNV.LayDanhSachNhanVien(); 
            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "HoTen"; 
            cboNhanVien.ValueMember = "MaNV";    
  
        }


        private void LoadSach()
        {
            var busSach = new SachBUS();
            var dsSach = busSach.GetAll();

            cboSach.DataSource = dsSach;
            cboSach.DisplayMember = "TieuDe"; 
            cboSach.ValueMember = "MaSach";    
        }

        private void LoadChart()
        {
            var busChart = new BUS_PhieuMuonDashBoard();
            var data = busChart.LayLuotMuon7Ngay();
        }


        private void btnChonSach_Click(object sender, EventArgs e)
        {
            string maSach = cboSach.SelectedValue.ToString();

            if (_dsSachMuon.Any(x => x.MaSach == maSach))
            {
                MessageBox.Show("Sách này đã được chọn!");
                return;
            }

            var sach = (SachET)cboSach.SelectedItem;
            _dsSachMuon.Add(new ET_ChiTietPhieuMuon
            {
                MaSach = sach.MaSach,
                TieuDe = sach.TieuDe,
                TacGia = sach.MaTacGia 
            });

            RefreshGridSachMuon();
        }


        private void RefreshGridSachMuon()
        {
            dgvSach.Rows.Clear();
            dgvSach.Columns.Clear();

            dgvSach.Columns.Add("MaSach", "Mã sách");
            dgvSach.Columns.Add("TieuDe", "Tiêu đề");
            dgvSach.Columns.Add("TacGia", "Tác giả");

            foreach (var s in _dsSachMuon)
            {
                dgvSach.Rows.Add(s.MaSach, s.TieuDe, s.TacGia);
            }
        }





        private void LoadThongKe()
        {
            var tk = _bus.GetThongKe();
            lblDangMuon.Text = tk.TongDangMuon.ToString();
            lblQuaHan.Text = tk.QuaHan.ToString();
            lblDaTra.Text = tk.DaTraThang.ToString();
            lblTienPhatThang.Text = tk.TongPhatThang.ToString("N0") + "đ";
        }


        private void LoadDanhSachPhieuMuon()
        {
            var ds = _bus.GetPhieuDangMuon();
            dgvPhieuMuon.Rows.Clear();
            dgvPhieuMuon.Columns.Clear();

            dgvPhieuMuon.Columns.Add("MaPhieuMuon", "Mã phiếu");
            dgvPhieuMuon.Columns.Add("TenDocGia", "Độc giả");
            dgvPhieuMuon.Columns.Add("NgayMuon", "Ngày mượn");
            dgvPhieuMuon.Columns.Add("HanTra", "Hạn trả");
            dgvPhieuMuon.Columns.Add("SoSach", "Sách");
            dgvPhieuMuon.Columns.Add("TrangThai", "Trạng thái");

            // Cột Action

            var colEdit = new DataGridViewImageColumn();
            colEdit.Name = "Edit";
            colEdit.Image = Properties.Resources.update; // ảnh bạn thêm vào Resources
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
            dgvPhieuMuon.Columns.Add(colEdit);

            var colDelete = new DataGridViewImageColumn();
            colDelete.Name = "Delete"; 
            colDelete.Image = Properties.Resources.delete;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
            dgvPhieuMuon.Columns.Add(colDelete);



            foreach (var pm in ds)
            {
                string danhSachSach = _bus.GetDanhSachTenSachCongDon(pm.MaPhieuMuon);
                dgvPhieuMuon.Rows.Add(
                    pm.MaPhieuMuon,
                    pm.TenDocGia,
                    pm.NgayMuon.Value.ToString("dd/MM/yyyy"),
                    pm.HanTra.Value.ToString("dd/MM/yyyy"),
                    danhSachSach,
                    pm.TrangThai,
                    null, // ô cho cột Edit
                    null  // ô cho cột Delete
                );
            }

        }



        //private void btnTaoPhieu_Click(object sender, EventArgs e)
        //{
        //    var data = new ET_TaoPhieuMuon
        //    {
        //        PhieuMuon = new ET_PhieuMuon
        //        {
        //            MaDocGia = txtMaDocGia.Text.Trim(),
        //            MaThe = txtMaThe.Text.Trim(),
        //            NguoiPhuTrach = LayMaNV(cboNhanVien.Text),
        //            NgayMuon = dtpNgayMuon.Value,
        //            HanTra = dtpNgayTra.Value 
        //        },
        //        DanhSachMaSach = _dsSachMuon.Select(x => x.MaSach).ToList()
        //    };



        //    var (ok, msg) = _bus.TaoPhieuMuon(data);
        //    MessageBox.Show(msg);
        //    if (ok) LoadDanhSachPhieuMuon();
        //}

        //private void btnTaoPhieu_Click(object sender, EventArgs e)
        //{
        //    var data = new ET_TaoPhieuMuon
        //    {
        //        PhieuMuon = new ET_PhieuMuon
        //        {
        //            MaDocGia = txtMaDocGia.Text.Trim(),
        //            MaThe = txtMaThe.Text.Trim(),
        //            NguoiPhuTrach = cboNhanVien.SelectedValue?.ToString() ?? "",
        //            NgayMuon = dtpNgayMuon.Value,
        //            HanTra = dtpNgayTra.Value
        //        },
        //        DanhSachMaSach = _dsSachMuon.Select(x => x.MaSach).ToList()
        //    };

        //    var (ok, msg) = _bus.TaoPhieuMuon(data);
        //    MessageBox.Show(msg);
        //    if (ok) LoadDanhSachPhieuMuon();
        //}


        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            var data = new ET_TaoPhieuMuon
            {
                PhieuMuon = new ET_PhieuMuon
                {
                    MaDocGia = txtMaDocGia.Text,
                    MaThe = txtMaThe.Text,
                    NguoiPhuTrach = cboNhanVien.SelectedValue?.ToString() ?? "",
                    NgayMuon = dtpNgayMuon.Value.Date,
                    HanTra = dtpNgayTra.Value.Date,
                },
                DanhSachMaSach = _dsSachMuon.Select(x => x.MaSach).ToList()
            };

			var frmMain = Application.OpenForms["Main"] as Main;

			if (_maPhieuDangSua == null)
			{
				// Tạo mới
				var (ok, msg) = _bus.TaoPhieuMuon(data);
				MessageBox.Show(ok ? $"Tạo thành công! {msg}" : $"Tạo thất bại: {msg}");

				if (ok)
				{
					frmMain?.LoadDashboard();       
					frmMain?.LoadLuotMuon7Ngay();   
				}
			}
			else
			{
				// Cập nhật
				var (ok, msg) = _bus.CapNhatPhieuMuon(_maPhieuDangSua, data);
				MessageBox.Show(ok ? "Cập nhật thành công!" : $"Cập nhật thất bại: {msg}");
				_maPhieuDangSua = null;

				if (ok)
				{
					frmMain?.LoadDashboard();
					frmMain?.LoadLuotMuon7Ngay();
				}
			}

			LoadDanhSachPhieuMuon();
      
        }


        private static string LayMaNV(string display)
        {
            return display.Contains("–")
                ? display.Split('–')[0].Trim()
                : display.Trim();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSach = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                string tieuDe = dgvSach.Rows[e.RowIndex].Cells["TieuDe"].Value.ToString();
                string tacGia = dgvSach.Rows[e.RowIndex].Cells["TacGia"].Value.ToString();

                if (!_dsSachMuon.Any(x => x.MaSach == maSach))
                {
                    _dsSachMuon.Add(new ET_ChiTietPhieuMuon
                    {
                        MaSach = maSach,
                        TieuDe = tieuDe,
                        TacGia = tacGia
                    });
                }
            }
        }

        private string _maPhieuDangSua = null;
     

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Clear();
            txtMaThe.Clear();
            cboSach.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtpNgayMuon.Value = DateTime.Today;
            dtpNgayTra.Value = DateTime.Today.AddDays(14);

            // Nếu bạn có biến trạng thái sửa
            _maPhieuDangSua = null;
        }

        private void btnXuLyTra_Click(object sender, EventArgs e)
        {
            frmPhieuTra pt = new frmPhieuTra();
            pt.Show();    
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            frmQuaHan pt = new frmQuaHan();
            pt.Show();
        }

		private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			string maPhieu = dgvPhieuMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value.ToString();

			if (dgvPhieuMuon.Columns[e.ColumnIndex].Name == "Edit")
			{
				var pm = _bus.GetPhieuMuonByMa(maPhieu);
				if (pm != null)
				{
					txtMaDocGia.Text = pm.MaDocGia;
					txtMaThe.Text = pm.MaThe;
					dtpNgayMuon.Value = pm.NgayMuon ?? DateTime.Today;
					dtpNgayTra.Value = pm.HanTra ?? DateTime.Today.AddDays(14);
					cboSach.SelectedValue = _bus.GetChiTietPhieuMuon(maPhieu).FirstOrDefault()?.MaSach;
					cboNhanVien.Text = pm.TenNhanVien;

					_maPhieuDangSua = maPhieu; // đánh dấu đang sửa
				}
			}

			if (dgvPhieuMuon.Columns[e.ColumnIndex].Name == "Delete")
			{
				if (MessageBox.Show($"Xóa phiếu {maPhieu}?", "Xác nhận",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					bool ok = _bus.XoaPhieuMuon(maPhieu);
					MessageBox.Show(ok ? "Xóa thành công!" : "Xóa thất bại!");
					if (ok) LoadDanhSachPhieuMuon();
				}
			}
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
