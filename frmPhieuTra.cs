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
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
        }

        public frmPhieuTra(string maPhieu) : this()
        {
            txtMaPhieu.Text = maPhieu;
            TimPhieu(maPhieu);
        }

        private BUS_PhieuMuon _bus = new BUS_PhieuMuon();
        private ET_PhieuMuon _phieuDangXuLy;
        private List<ET_ChiTietPhieuTra> _dsChiTietTra = new List<ET_ChiTietPhieuTra>();

        BUS_NhanVien bsnv = new BUS_NhanVien();



        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            // Load danh sách nhân viên vào combobox
            var dsNV = bsnv.LayDanhSachNhanVien();
            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "TenNV";   // tên hiển thị
            cboNhanVien.ValueMember = "MaNV";      // giá trị lưu

            // Khởi tạo cột cho dgvPhieuTra (danh sách phiếu trả)
            dgvPhieuTra.Columns.Clear();
            dgvPhieuTra.Columns.Add("MaPhieuTra", "Mã phiếu trả");
            dgvPhieuTra.Columns.Add("MaPhieuMuon", "Mã phiếu mượn");
            dgvPhieuTra.Columns.Add("TenDocGia", "Độc giả");
            dgvPhieuTra.Columns.Add("NgayTra", "Ngày trả");
            dgvPhieuTra.Columns.Add("TinhTrangSach", "Tình trạng");
            dgvPhieuTra.Columns.Add("SoTien", "Tổng phạt");
            dgvPhieuTra.Columns.Add("TenNhanVien", "Nhân viên");

            // Gọi hàm load danh sách phiếu trả để hiển thị ngay
            LoadDanhSachPhieuTra();

        }

        //private void btnTimPhieu_Click(object sender, EventArgs e)
        //{
        //    string maPhieu = txtMaPhieu.Text.Trim();
        //    if (string.IsNullOrEmpty(maPhieu))
        //    {
        //        MessageBox.Show("Vui lòng nhập mã phiếu mượn!");
        //        return;
        //    }

        //    _phieuDangXuLy = _bus.GetPhieuMuonByMa(maPhieu);
        //    if (_phieuDangXuLy == null)
        //    {
        //        MessageBox.Show("Không tìm thấy phiếu mượn!");
        //        return;
        //    }

        //    if (_phieuDangXuLy.TrangThai == "Đã trả")
        //    {
        //        MessageBox.Show("Phiếu này đã được trả trước đó!");
        //        return;
        //    }

        //    // Hiển thị thông tin phiếu
        //    lblDocGia.Text = _phieuDangXuLy.TenDocGia;
        //    lblNgayMuon.Text = _phieuDangXuLy.NgayMuon?.ToString("dd/MM/yyyy");
        //    lblHanTra.Text = _phieuDangXuLy.HanTra?.ToString("dd/MM/yyyy");

        //    int soNgayTre = _bus.TinhSoNgayTre(_phieuDangXuLy.HanTra.Value, DateTime.Today);
        //    lblSoNgayTre.Text = soNgayTre > 0 ? $"Trễ {soNgayTre} ngày" : "Đúng hạn";

        //    // Load danh sách sách cần trả
        //    var dsSach = _bus.GetChiTietPhieuMuon(_phieuDangXuLy.MaPhieuMuon);
        //    _dsChiTietTra = dsSach.Select(s => new ET_ChiTietPhieuTra
        //    {
        //        MaSach = s.MaSach,
        //        TieuDe = s.TieuDe,
        //        TinhTrang = "Tốt",
        //        PhiPhat = _bus.TinhTienPhat(_phieuDangXuLy.HanTra.Value, DateTime.Today, "Tốt"),
        //        GhiChu = ""
        //    }).ToList();

        //    RefreshGridSachTra();
        //    TinhLaiTongPhat();
        //}

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu   = txtMaPhieu.Text.Trim();
            TimPhieu(maPhieu);
        }

        //private void TimPhieu(string maPhieu)
        //{
        //    _phieuDangXuLy = _bus.GetPhieuMuonByMa(maPhieu);
        //    if (_phieuDangXuLy == null)
        //    {
        //        MessageBox.Show("Không tìm thấy phiếu mượn!");
        //        return;
        //    }

        //    // Hiển thị thông tin phiếu
        //    lblDocGia.Text = _phieuDangXuLy.TenDocGia;
        //    lblNgayMuon.Text = _phieuDangXuLy.NgayMuon?.ToString("dd/MM/yyyy");
        //    lblHanTra.Text = _phieuDangXuLy.HanTra?.ToString("dd/MM/yyyy");

        //    int soNgayTre = _bus.TinhSoNgayTre(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value);
        //    lblSoNgayTre.Text = soNgayTre > 0 ? $"Trễ {soNgayTre} ngày" : "Đúng hạn";


        //    // Load danh sách sách cần trả
        //    var dsSach = _bus.GetChiTietPhieuMuon(_phieuDangXuLy.MaPhieuMuon);
        //    _dsChiTietTra = dsSach.Select(s => new ET_ChiTietPhieuTra
        //    {
        //        MaSach = s.MaSach,
        //        TieuDe = s.TieuDe,
        //        TinhTrang = "Tốt",
        //        PhiPhat = _bus.TinhTienPhat(_phieuDangXuLy.HanTra.Value, DateTime.Today, "Tốt"),
        //        GhiChu = ""
        //    }).ToList();

        //    RefreshGridSachTra();
        //    TinhLaiTongPhat();
        //}
        private void TimPhieu(string maPhieu)
        {
            _phieuDangXuLy = _bus.GetPhieuMuonByMa(maPhieu);
            if (_phieuDangXuLy == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn!");
                return;
            }

            // Hiển thị thông tin phiếu
            lblDocGia.Text = _phieuDangXuLy.TenDocGia;
            lblNgayMuon.Text = _phieuDangXuLy.NgayMuon?.ToString("dd/MM/yyyy");
            lblHanTra.Text = _phieuDangXuLy.HanTra?.ToString("dd/MM/yyyy");


            // Tính số ngày trễ theo ngày trả thực tế
            int soNgayTre = _bus.TinhSoNgayTre(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value);

          

            lblSoNgayTre.Text = "Chưa chọn ngày trả";

            // Load danh sách sách cần trả
            var dsSach = _bus.GetChiTietPhieuMuon(_phieuDangXuLy.MaPhieuMuon);
            _dsChiTietTra = dsSach.Select(s => new ET_ChiTietPhieuTra
            {
                MaSach = s.MaSach,
                TieuDe = s.TieuDe,
                TinhTrang = "Tốt",
                PhiPhat = _bus.TinhTienPhat(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value, "Tốt"),
                GhiChu = ""
            }).ToList();

            RefreshGridSachTra();
            TinhLaiTongPhat();
        }


        //private void RefreshGridSachTra()
        //{
        //    dgvSachTra.Rows.Clear();
        //    dgvSachTra.Columns.Clear();

        //    dgvSachTra.Columns.Add("TieuDe", "Tiêu đề");
        //    var colTinhTrang = new DataGridViewComboBoxColumn
        //    {
        //        Name = "TinhTrang",
        //        HeaderText = "Tình trạng",
        //        DataSource = new[] { "Tốt", "Hỏng nhẹ", "Hỏng nặng", "Mất sách" },
        //        Width = 110
        //    };
        //    dgvSachTra.Columns.Add(colTinhTrang);
        //    dgvSachTra.Columns.Add("PhiPhat", "Phí phạt");
        //    dgvSachTra.Columns.Add("GhiChu", "Ghi chú");
        //    dgvSachTra.Columns.Add("MaSach", "Mã sách");
        //    dgvSachTra.Columns["MaSach"].Visible = false;

        //    foreach (var ct in _dsChiTietTra)
        //        dgvSachTra.Rows.Add(ct.TieuDe, ct.TinhTrang, ct.PhiPhat.ToString("N0") + "đ", ct.GhiChu, ct.MaSach);

        //    dgvSachTra.ReadOnly = false;
        //}

        private void RefreshGridSachTra()
        {
            dgvSachTra.Rows.Clear();
            dgvSachTra.Columns.Clear();

            dgvSachTra.Columns.Add("TieuDe", "Tiêu đề");
            var colTinhTrang = new DataGridViewComboBoxColumn
            {
                Name = "TinhTrang",
                HeaderText = "Tình trạng",
                DataSource = new[] { "Tốt", "Hỏng nhẹ", "Hỏng nặng", "Mất sách" },
                Width = 110
            };
            dgvSachTra.Columns.Add(colTinhTrang);
            dgvSachTra.Columns.Add("PhiPhat", "Phí phạt");
            dgvSachTra.Columns.Add("GhiChu", "Ghi chú");
            dgvSachTra.Columns.Add("MaSach", "Mã sách");
            dgvSachTra.Columns["MaSach"].Visible = false;

            foreach (var ct in _dsChiTietTra)
                dgvSachTra.Rows.Add(ct.TieuDe, ct.TinhTrang, ct.PhiPhat.ToString("N0") + "đ", ct.GhiChu, ct.MaSach);

            dgvSachTra.ReadOnly = false;
        }



        private void dgvSachTra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvSachTra.Columns["TinhTrang"].Index) return;

            string tinhTrang = dgvSachTra.Rows[e.RowIndex].Cells["TinhTrang"].Value?.ToString() ?? "Tốt";
            string maSach = dgvSachTra.Rows[e.RowIndex].Cells["MaSach"].Value?.ToString() ?? "";

            var ct = _dsChiTietTra.FirstOrDefault(x => x.MaSach == maSach);
            if (ct == null || _phieuDangXuLy == null) return;

            ct.TinhTrang = tinhTrang;
            ct.PhiPhat = _bus.TinhTienPhat(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value, tinhTrang);

            dgvSachTra.Rows[e.RowIndex].Cells["PhiPhat"].Value = ct.PhiPhat.ToString("N0") + "đ";
            TinhLaiTongPhat();
        }
        private void TinhLaiTongPhat()
        {
            decimal tong = _dsChiTietTra.Sum(ct => ct.PhiPhat);
            lblTongTien.Text = $"Tổng phạt: {tong:N0}đ";
        }

        //private void btnXacNhan_Click(object sender, EventArgs e)
        //{
        //    if (_phieuDangXuLy == null)
        //    {
        //        MessageBox.Show("Vui lòng tìm phiếu mượn trước!");
        //        return;
        //    }

        //    foreach (DataGridViewRow row in dgvSachTra.Rows)
        //    {
        //        string maSach = row.Cells["MaSach"].Value?.ToString() ?? "";
        //        string ghiChu = row.Cells["GhiChu"].Value?.ToString() ?? "";
        //        var ct = _dsChiTietTra.FirstOrDefault(x => x.MaSach == maSach);
        //        if (ct != null) ct.GhiChu = ghiChu;
        //    }

        //    var data = new ET_XuLyTra
        //    {
        //        PhieuTra = new ET_PhieuTra
        //        {
        //            MaPhieuMuon = _phieuDangXuLy.MaPhieuMuon,
        //            NgayTra = dtpNgayTra.Value.Date,
        //            NguoiPhuTrach = cboNhanVien.SelectedValue?.ToString() ?? "",
        //            GhiChu = txtGhiChu.Text.Trim()
        //        },
        //        ChiTietList = _dsChiTietTra
        //    };

        //    var (ok, msg) = _bus.XuLyTraSach(data);
        //    MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
        //        MessageBoxButtons.OK,
        //        ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);


        //    if (ok)
        //    {
        //        LamMoiForm();
        //        LoadDanhSachPhieuTra();
        //    }
        //}

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_phieuDangXuLy == null)
            {
                MessageBox.Show("Vui lòng tìm phiếu mượn trước!");
                return;
            }

            // Cập nhật ghi chú từng sách
            foreach (DataGridViewRow row in dgvSachTra.Rows)
            {
                string maSach = row.Cells["MaSach"].Value?.ToString() ?? "";
                string ghiChu = row.Cells["GhiChu"].Value?.ToString() ?? "";
                var ct = _dsChiTietTra.FirstOrDefault(x => x.MaSach == maSach);
                if (ct != null) ct.GhiChu = ghiChu;
            }

            // Tạo đối tượng ET_XuLyTra
            var data = new ET_XuLyTra
            {
                PhieuTra = new ET_PhieuTra
                {
                    MaPhieuMuon = _phieuDangXuLy.MaPhieuMuon,
                    NgayTra = dtpNgayTra.Value.Date,
                    NguoiPhuTrach = cboNhanVien.SelectedValue?.ToString() ?? "",
                    GhiChu = txtGhiChu.Text.Trim()
                },
                ChiTietList = _dsChiTietTra
            };

            // Gọi BUS
            var (ok, msg) = _bus.XuLyTraSach(data);
            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok)
            {
                LamMoiForm();
                LoadThongKe();
            }
        }

        private void LoadThongKe()
        {
            var tk = _bus.GetThongKe();
            lblDangMuon.Text = tk.TongDangMuon.ToString();
            lblQuaHan.Text = tk.QuaHan.ToString();
            lblDaTra.Text = tk.DaTraThang.ToString();
            lblTongTien.Text = tk.TongPhatThang.ToString("N0") + "đ";
        }
        private void LamMoiForm()
        {
            txtMaPhieu.Clear();
            txtGhiChu.Clear();
            lblDocGia.Text = "---";
            lblNgayMuon.Text = "---";
            lblHanTra.Text = "---";
            lblTongTien.Text = "Tổng phạt: 0đ";
            lblSoNgayTre.Text = "----";
            dtpNgayTra.CustomFormat = " "; // hiển thị trống
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            _phieuDangXuLy = null;
            _dsChiTietTra.Clear();
            dgvSachTra.Rows.Clear();   // giữ nguyên Columns
        }


        private void LoadDanhSachPhieuTra()
        {
            var ds = _bus.GetDanhSachPhieuTra();
            dgvPhieuTra.Rows.Clear();
            foreach (var pt in ds)
            {
                dgvPhieuTra.Rows.Add(pt.MaPhieuTra, pt.MaPhieuMuon, pt.TenDocGia,
                    pt.NgayTra.HasValue ? pt.NgayTra.Value.ToString("dd/MM/yyyy") : "",
                    pt.TinhTrangSach, pt.SoTien.ToString("N0") + "đ", pt.TenNhanVien);
            }
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (_phieuDangXuLy == null || !_phieuDangXuLy.HanTra.HasValue) return;

            int soNgayTre = _bus.TinhSoNgayTre(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value);
            lblSoNgayTre.Text = soNgayTre > 0 ? $"Trễ {soNgayTre} ngày" : "Đúng hạn";

            // Đồng bộ phí phạt
            foreach (var ct in _dsChiTietTra)
            {
                ct.PhiPhat = _bus.TinhTienPhat(_phieuDangXuLy.HanTra.Value, dtpNgayTra.Value, ct.TinhTrang);
            }
            RefreshGridSachTra();
            TinhLaiTongPhat();
        }

		private void btnHuy_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
