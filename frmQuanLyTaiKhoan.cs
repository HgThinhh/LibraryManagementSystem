using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using BUS_ThuVien;
using ET_ThuVien;
using Guna.UI2.WinForms;
using XuatExcelPDF;

namespace WindowsFormsApp1
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        TaiKhoanBUS _bus = new TaiKhoanBUS();

        private TaiKhoanET _tkDangChon = null;
        private int _maVaiTroPhanQuyen;
        private List<QuyenET> _dsQuyen = new List<QuyenET>();

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Khởi tạo combo lọc
            cboFilterTT.Items.AddRange(new[] { "Tất cả", "HoatDong", "BiKhoa" });
            cboFilterTT.SelectedIndex = 0;

            cboFilterVT.Items.AddRange(new[] { "Tất cả", "Admin", "ThuThu", "DocGia" });
            cboFilterVT.SelectedIndex = 0;

            // Gắn sự kiện realtime
            txtTimKiem.TextChanged += (s, ev) => LoadDanhSachTaiKhoan();
            cboFilterTT.SelectedIndexChanged += (s, ev) => LoadDanhSachTaiKhoan();
            cboFilterVT.SelectedIndexChanged += (s, ev) => LoadDanhSachTaiKhoan();

            LoadDanhSachTaiKhoan();
            LoadThongKe();
            LoadComboVaiTro();

            //phân quyền
            LoadComboVaiTroPhanQuyen();

            //lịch sử
            LoadLichSu();
        }


        private void LoadComboVaiTro()
        {
            var ds = _bus.GetAllVaiTro();
            cboVaiTro.DataSource = ds;
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "MaVaiTro";
        }


        // Tab 1 — Load thống kê

        // Load thống kê
        private void LoadThongKe()
        {
            var tk = _bus.GetThongKe();
            lblTong.Text = tk.TongTaiKhoan.ToString();
            lblDangHD.Text = tk.HoatDong.ToString();
            lblDangNhap.Text = tk.DangNhapHomNay.ToString();
            lblBiKhoa.Text = tk.BiKhoa.ToString();
        }


        // ── Màu theme ─────────────────────────────────────────
        static readonly Color TEAL = Color.FromArgb(16, 185, 129);
        static readonly Color RED = Color.FromArgb(239, 68, 68);
        static readonly Color PURP = Color.FromArgb(167, 139, 250);
        static readonly Color BLUE = Color.FromArgb(79, 142, 247);
        static readonly Color AMB = Color.FromArgb(245, 158, 11);


        //Tab 1 — Load danh sách tài khoản
        private void LoadDanhSachTaiKhoan()
        {
            var ds = _bus.GetAllTaiKhoan(txtTimKiem.Text, cboFilterTT.Text, cboFilterVT.Text);

            dgvTaiKhoan.Rows.Clear();
            dgvTaiKhoan.Columns.Clear();
            dgvTaiKhoan.Columns.Add("MaTaiKhoan", "Mã TK");
            dgvTaiKhoan.Columns.Add("TenDangNhap", "Tên đăng nhập");
            dgvTaiKhoan.Columns.Add("HoTen", "Họ tên");
            dgvTaiKhoan.Columns.Add("TenVaiTro", "Vai trò");
            dgvTaiKhoan.Columns.Add("LoaiTK", "Loại");
            dgvTaiKhoan.Columns.Add("TrangThai", "Trạng thái");
            dgvTaiKhoan.Columns.Add("NgayTao", "Ngày tạo");
            dgvTaiKhoan.Columns["MaTaiKhoan"].Visible = false;

            foreach (var t in ds)
            {
                int row = dgvTaiKhoan.Rows.Add(
                    t.MaTaiKhoan,
                    t.TenDangNhap,
                    t.HoTen,
                    t.TenVaiTro,
                    t.LoaiTaiKhoan,
                    t.TrangThai,
                    t.NgayTao.ToString("dd/MM/yyyy")
                );

                // Tô màu trạng thái
                var cell = dgvTaiKhoan.Rows[row].Cells["TrangThai"];
                cell.Style.ForeColor = t.TrangThai == "HoatDong" ? TEAL : RED;

                // Tô màu vai trò
                var cellVT = dgvTaiKhoan.Rows[row].Cells["TenVaiTro"];
                if (t.TenVaiTro == "Admin")
                    cellVT.Style.ForeColor = PURP;
                else if (t.TenVaiTro == "ThuThu")
                    cellVT.Style.ForeColor = BLUE;
                else
                    cellVT.Style.ForeColor = AMB;
            }
        }


		// Tab 1 — Sự kiện click dòng

		private void dgvTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int maTK = Convert.ToInt32(dgvTaiKhoan.Rows[e.RowIndex].Cells["MaTaiKhoan"].Value);
			_tkDangChon = _bus.GetById(maTK);
			if (_tkDangChon == null) return;

			txtTenDN.Text = _tkDangChon.TenDangNhap;
			txtHoTen.Text = _tkDangChon.HoTen;
			txtEmail.Text = _tkDangChon.Email;
			txtMaNV.Text = _tkDangChon.MaNV ?? "";
			txtMaDG.Text = _tkDangChon.MaDocGia ?? "";

			foreach (VaiTroET vt in cboVaiTro.Items)
				if (vt.MaVaiTro == _tkDangChon.MaVaiTro) { cboVaiTro.SelectedItem = vt; break; }

			btnKhoaTK.Text = _tkDangChon.TrangThai == "HoatDong" ? "Lock" : "Open";
			btnKhoaTK.ForeColor = _tkDangChon.TrangThai == "HoatDong" ? RED : TEAL;
		}
		private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboFilterTT.SelectedIndex = 0;
            cboFilterVT.SelectedIndex = 0;
            LoadDanhSachTaiKhoan();
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            _tkDangChon = null;
            txtTenDN.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMaNV.Clear();
            txtMaDG.Clear();
            btnKhoaTK.Text = "Khóa / Mở";
            btnKhoaTK.ForeColor = AMB;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan(_bus);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachTaiKhoan();
                LoadThongKe();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_tkDangChon == null)
            { MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!"); return; }

            _tkDangChon.MaVaiTro = ((VaiTroET)cboVaiTro.SelectedItem).MaVaiTro;
            _tkDangChon.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? null : txtMaNV.Text.Trim();
            _tkDangChon.MaDocGia = string.IsNullOrEmpty(txtMaDG.Text) ? null : txtMaDG.Text.Trim();

            var (ok, msg) = _bus.CapNhatTaiKhoan(_tkDangChon);
            MessageBox.Show(msg, ok ? "Thành công" : "Thất bại");
            if (ok) { LoadDanhSachTaiKhoan(); LoadThongKe(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_tkDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            if (SessionManager.TaiKhoanHienTai == null)
            {
                MessageBox.Show("Không xác định được tài khoản hiện tại!");
                return;
            }

            if (MessageBox.Show($"Xóa tài khoản '{_tkDangChon.TenDangNhap}'?\nHành động này không thể hoàn tác!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            var (ok, msg) = _bus.XoaTaiKhoan(_tkDangChon.MaTaiKhoan, SessionManager.TaiKhoanHienTai.MaTaiKhoan);
            MessageBox.Show(msg, ok ? "Thành công" : "Thất bại");

            if (ok)
            {
                LoadDanhSachTaiKhoan();
                LoadThongKe();
                LamMoiForm();
            }
        }

    

        private void btnKhoaTK_Click(object sender, EventArgs e)
        {
            if (_tkDangChon == null)
            { MessageBox.Show("Vui lòng chọn tài khoản!"); return; }

            string hanhDong = _tkDangChon.TrangThai == "HoatDong" ? "khóa" : "mở khóa";
            if (MessageBox.Show($"Bạn có chắc muốn {hanhDong} tài khoản '{_tkDangChon.TenDangNhap}'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            (bool ok, string msg) result = _tkDangChon.TrangThai == "HoatDong"
                ? _bus.KhoaTaiKhoan(_tkDangChon.MaTaiKhoan, SessionManager.TaiKhoanHienTai.MaTaiKhoan)
                : _bus.MoTaiKhoan(_tkDangChon.MaTaiKhoan);

            MessageBox.Show(result.msg, result.ok ? "Thành công" : "Thất bại");
            if (result.ok) { LoadDanhSachTaiKhoan(); LoadThongKe(); _tkDangChon = null; }
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            using (var frm = new frmResetMatKhau(_tkDangChon.TenDangNhap))
            {
                if (frm.ShowDialog() != DialogResult.OK) return;

                var (ok, msg) = _bus.ResetMatKhau(_tkDangChon.MaTaiKhoan, frm.MatKhauMoi);
                MessageBox.Show(msg, ok ? "Thành công" : "Thất bại");
            }

        }

        // ══════════════════════════════════════════════════════
        //  TAB 2 — PHÂN QUYỀN
        // ══════════════════════════════════════════════════════
        private void LoadComboVaiTroPhanQuyen()
        {
            var ds = _bus.GetAllVaiTro();
            cboVaiTroPQ.DataSource = ds;
            cboVaiTroPQ.DisplayMember = "TenVaiTro";
            cboVaiTroPQ.ValueMember = "MaVaiTro";
            if (ds.Any()) cboVaiTroPQ.SelectedIndex = 0;
        }

        private void cmbVaiTroPQ_SelectedIndexChanged(object s, EventArgs e)
        {
          
        }


        static readonly Color BG_CARD = Color.FromArgb(26, 32, 48);
        static readonly Color TEXT_PRI = Color.FromArgb(249, 250, 251);

        private void LoadPhanQuyen(int maVaiTro)
        {
            _dsQuyen = _bus.GetQuyenByVaiTro(maVaiTro);
            flpQuyen.Controls.Clear();

            foreach (var q in _dsQuyen)
            {
                // Tên hiển thị
                string tenMH = DanhSachManHinh.TatCa
                    .FirstOrDefault(m => m.Ma == q.ManHinh).Ten ?? q.ManHinh;

                var pnl = new Panel { Size = new Size(240, 40), Margin = new Padding(0, 0, 8, 8) };
                pnl.BackColor = BG_CARD;
                var tog = new Guna2ToggleSwitch
                {
                    Checked = q.CoPhep,
                    CheckedState = { FillColor = TEAL },
                    UncheckedState = { FillColor = Color.FromArgb(55, 65, 81) },
                    Dock = DockStyle.Right,
                    Width = 44,
                    Tag = q.ManHinh
                };
                var lbl = new Label
                {
                    Text = tenMH,
                    Font = new Font("Segoe UI", 10f),
                    ForeColor = TEXT_PRI,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };
                tog.CheckedChanged += (sv, ev) =>
                {
                    var quyen = _dsQuyen.FirstOrDefault(x => x.ManHinh == tog.Tag?.ToString());
                    if (quyen != null) quyen.CoPhep = tog.Checked;
                };
                pnl.Controls.AddRange(new Control[] { lbl, tog });
                flpQuyen.Controls.Add(pnl);
            }
        }


        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (_maVaiTroPhanQuyen <= 0)
            { MessageBox.Show("Vui lòng chọn vai trò!"); return; }

            if (MessageBox.Show("Lưu phân quyền cho vai trò này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var (ok, msg) = _bus.LuuPhanQuyen(_maVaiTroPhanQuyen, _dsQuyen);
            MessageBox.Show(msg, ok ? "Thành công" : "Thất bại");
        }

        private void cboVaiTroPQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vt = cboVaiTroPQ.SelectedItem as VaiTroET;
            if (vt == null) return;
            _maVaiTroPhanQuyen = vt.MaVaiTro;
            LoadPhanQuyen(_maVaiTroPhanQuyen);
        }



        // ══════════════════════════════════════════════════════
        //  TAB 3 — LỊCH SỬ ĐĂNG NHẬP
        // ══════════════════════════════════════════════════════
        private void tabMain_SelectedIndexChanged(object s, EventArgs e)
        {
            if (tabMain.SelectedTab == tabLichSu)
                LoadLichSu();
        }

        private void LoadLichSu(int? maTK = null)
        {
            var ds = _bus.GetLichSu(maTK, top: 100);

            dgvLichSu.Rows.Clear();
            dgvLichSu.Columns.Clear();
            dgvLichSu.Columns.Add("ThoiGian", "Thời gian");
            dgvLichSu.Columns.Add("TenDN", "Tài khoản");
            dgvLichSu.Columns.Add("HoTen", "Họ tên");
            dgvLichSu.Columns.Add("KetQua", "Kết quả");
            dgvLichSu.Columns.Add("GhiChu", "Ghi chú");

            foreach (var l in ds)
            {
                int row = dgvLichSu.Rows.Add(
                    l.ThoiGian.ToString("dd/MM/yyyy HH:mm"),
                    l.TenDangNhap,
                    l.HoTen,
                    l.KetQua,
                    l.GhiChu
                );
                dgvLichSu.Rows[row].Cells["KetQua"].Style.ForeColor =
                    l.KetQua == "ThanhCong" ? TEAL : RED;   
            }
        }

        private void btnXemTKLS_Click(object sender, EventArgs e)
        {
            if (_tkDangChon == null)
            { MessageBox.Show("Vui lòng chọn tài khoản ở Tab 1 trước!"); return; }
            tabMain.SelectedTab = tabLichSu;
            lblFillerLS.Text = $"Lịch sử của: {_tkDangChon.TenDangNhap}";
            LoadLichSu(_tkDangChon.MaTaiKhoan);
        }

        private void guna2Button4_Click(object sender, EventArgs e)  => LoadLichSu();


	}
}

