using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS_ThuVien;
using DAl_ThuVien;

namespace WindowsFormsApp1  
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        QuanLyThuVIenDataContext db = new QuanLyThuVIenDataContext();
        BUS_DocGia busDocGia = new BUS_DocGia();
        BUS_PhieuMuon bs = new BUS_PhieuMuon();

		private ThongKeBUS bus;


		public void LoadDashboard()
		{
			var ds = bs.LayPhieuMuonGanDay(10); 
			dgvMuon.DataSource = ds;
            LoadLuotMuon7Ngay();


		}


		private void Form1_Load(object sender, EventArgs e)
        {

			// Khởi tạo BUS
			bus = new ThongKeBUS(DBConnect.conn);

			// Lấy thống kê
			var tk = bus.LayThongKe();
			lblTongSach.Text = tk.TongSoSach.ToString();
			lblDocGia.Text = tk.TongDocGia.ToString();
			lblDangMuon.Text = tk.SachDangMuon.ToString();
			lblQuaHan.Text = tk.QuaHan.ToString();

			LoadDashboard();


			dgvMuon.DataSource = bs.LayPhieuMuonGanDay(10);

            dgvMuon.Columns["MaPhieuMuon"].HeaderText = "Mã phiếu";
            dgvMuon.Columns["TenDocGia"].HeaderText = "Độc giả";
            dgvMuon.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dgvMuon.Columns["NgayMuon"].HeaderText = "Ngày mượn";
            dgvMuon.Columns["HanTra"].HeaderText = "Hạn trả";
            dgvMuon.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvMuon.Columns["SoSachMuon"].HeaderText = "Số sách mượn";
            dgvMuon.Columns["SoNgayTre"].HeaderText = "Số ngày trễ";


            LoadDocGiaMoi();

            LoadLuotMuon7Ngay();

        }



		private void LoadFormToPanel(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        private void btnMain_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
        }


        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new MuonTra());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmQuanLyTaiKhoan());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmThongKe());
        }

		private void btnKeSach_Click(object sender, EventArgs e)
		{
            LoadFormToPanel(new frmQuanLyKeSach());
		}



		private void LoadDocGiaMoi()
        {
            flpDocGia.Controls.Clear();

            // Lấy danh sách độc giả mới từ BUS (ví dụ 5 người gần nhất)
            var dsDocGia = busDocGia.LayDocGiaMoi(5);

            foreach (var dg in dsDocGia)
            {
                Panel pnlItem = new Panel
                {
                    Width = 180,
                    Height = 100,
                    BackColor = Color.FromArgb(30, 30, 45),
                    Margin = new Padding(6)
                };

                // Avatar mặc định, căn giữa theo chiều ngang
                PictureBox pic = new PictureBox
                {
                    Size = new Size(36, 36),
                    Location = new Point((pnlItem.Width - 36) / 2, 8),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Properties.Resources.circle_user_solid1 // ảnh mặc định bạn đã chèn sẵn
                };

                // Label tên độc giả, căn giữa dưới avatar
                Label lblName = new Label
                {
                    Text = dg.HoTen,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true
                };
                lblName.Location = new Point((pnlItem.Width - lblName.PreferredWidth) / 2, 50);


                Label lblRole = new Label
                {
                    Text = dg.DiaChi,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    AutoSize = true
                };
                lblRole.Location = new Point((pnlItem.Width - lblRole.PreferredWidth) / 2, 68);

                // Thêm control vào panel con
                pnlItem.Controls.Add(pic);
                pnlItem.Controls.Add(lblName);
                pnlItem.Controls.Add(lblRole);

                // Thêm panel con vào FlowLayoutPanel
                flpDocGia.Controls.Add(pnlItem);
            }
        }

        public void LoadLuotMuon7Ngay()
        {
            chartLuotMuon.Series.Clear();
            Series series = new Series("Lượt mượn");
            series.ChartType = SeriesChartType.Column;
            series["DrawingStyle"] = "Cylinder";

            // Lấy dữ liệu 7 ngày gần nhất
            var ds = bs.LayLuotMuon7Ngay();

            string[] colors = { "#4e79a7", "#f28e2b", "#e15759", "#76b7b2", "#59a14f", "#edc949", "#af7aa1" };
            int idx = 0;

			foreach (var record in ds)
			{
				string nhan = record.Ngay.ToString("dd/MM");
				series.Points.AddXY(nhan, record.SoLuong);
				series.Points[idx].Color = ColorTranslator.FromHtml(colors[idx % colors.Length]);
				idx++;
			}


			chartLuotMuon.Series.Add(series);
        }




        private void btnXuLyTraSach_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmPhieuTra());
        }

        private void btnChuong_Click(object sender, EventArgs e)
        {
            var frm = new frmThongBao();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;

            // lấy vị trí nút chuông trên màn hình
            Point viTriNut = btnChuong.PointToScreen(Point.Empty);

            // đặt form ngay dưới nút
            frm.Location = new Point(viTriNut.X, viTriNut.Y + btnChuong.Height);

            frm.Deactivate += (s, ev) => frm.Close();
            frm.TopMost = true;
            frm.Show();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            var frm = new frmCaiDat();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;

            Point viTriNut = btnCaiDat.PointToScreen(Point.Empty);

            frm.Location = new Point(viTriNut.X, viTriNut.Y + btnCaiDat.Height);

            frm.Deactivate += (s, ev) => frm.Close();
            frm.TopMost = true;
            frm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
			var frm = new frmUser();
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.StartPosition = FormStartPosition.Manual;

			var rect = btnUser.RectangleToScreen(btnUser.ClientRectangle);

			frm.Location = new Point(rect.Left - 80, rect.Bottom + 10);

			frm.Show();
		}

		TimKiemNhanhBUS _timKiemBUS = new TimKiemNhanhBUS();


		private Panel _popupSearch;



		private void HienSearchDropdown(string keyword)
		{
			TimKiemNhanhBUS bus = new TimKiemNhanhBUS();
			var ketQua = bus.TimKiem(keyword);

			if (ketQua.Any())
			{
				FlowLayoutPanel pnl = new FlowLayoutPanel();
				pnl.AutoScroll = true;
				pnl.FlowDirection = FlowDirection.TopDown;
				pnl.WrapContents = false;
				pnl.Dock = DockStyle.Fill;

				foreach (var item in ketQua)
				{
					ucTimKiem uc = new ucTimKiem(item);
					pnl.Controls.Add(uc);
				}

				// Nếu panel đã tồn tại thì xóa trước
				_popupSearch?.Dispose();

				// Gán panel vào biến _popupSearch
				_popupSearch = new Panel();
				_popupSearch.BorderStyle = BorderStyle.FixedSingle;
				_popupSearch.Location = new Point(txtSearch.Left, txtSearch.Bottom);
				_popupSearch.Size = new Size(300, 200);
				_popupSearch.Controls.Add(pnl);

				this.Controls.Add(_popupSearch);
				_popupSearch.BringToFront();

			}
		}

	    





		private void MoFormTheoTen(string tenForm)
		{
			Form frm;

			switch (tenForm)
			{
                case "frmQuanLySach":
                    frm = new frmQuanLySach();
                break;
                case "frmQuanLyDocGia":
                frm = new frmQuanLyDocGia();
                break;

                case "frmMuonTra":
					frm = new MuonTra();
					break;

				default:
					frm = new Main();
					break;
			}

			LoadFormToPanel(frm);
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(keyword))
                {
                    HienSearchDropdown(keyword);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }


		}

		private void btnThemPhieuMuon_Click(object sender, EventArgs e)
		{
            LoadFormToPanel(new MuonTra());
		}

		private void btnSachQuaHan_Click(object sender, EventArgs e)
		{
            LoadFormToPanel(new frmQuaHan());
		}

		private void btnQLSach_Click(object sender, EventArgs e)
		{
			LoadFormToPanel(new frmQuanLySach());
		}

		private void btnDocGia_Click(object sender, EventArgs e)
		{
			LoadFormToPanel(new frmQuanLyDocGia());
		}

		private void btnKho_Click(object sender, EventArgs e)
		{
			LoadFormToPanel(new frmQuanLyKho());
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			LoadFormToPanel(new frmXuatHoaDon());
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtSearch.Text))
			{
				// Nếu panel đang hiển thị thì ẩn/Dispose
				if (_popupSearch != null)
				{
					_popupSearch.Dispose();
					_popupSearch = null;
				}
			}
			else
			{
				// Gọi lại hàm hiển thị dropdown
				HienSearchDropdown(txtSearch.Text);
			}
		}

		private void btnThemDocGia_Click(object sender, EventArgs e)
		{
            frmThemDocGia frm = new frmThemDocGia();
            frm.ShowDialog();
		}





















		//B202A-PC41\SQLEXPRESS
	}
}
