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
using Guna.UI2.WinForms;
using XuatExcelPDF;



namespace WindowsFormsApp1
{
    public partial class frmThongKe : Form
    {

        BaoCaoBUS _bus = new BaoCaoBUS();

        private int _thang = DateTime.Today.Month;
        private int _nam = DateTime.Today.Year;

        static readonly Color BG_CARD = Color.FromArgb(26, 32, 48);
        static readonly Color BLUE = Color.FromArgb(79, 142, 247);
        static readonly Color TEAL = Color.FromArgb(16, 185, 129);
        static readonly Color RED = Color.FromArgb(239, 68, 68);
        static readonly Color TEXT_PRI = Color.FromArgb(249, 250, 251);
        public frmThongKe()
        {
            InitializeComponent();

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadComboThang();
            LoadTatCa();
        }


        private void LoadComboThang()
        {
            cboThang.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                var d = DateTime.Today.AddMonths(-i);
                cboThang.Items.Add(new { Display = d.ToString("M/yyyy"), Thang = d.Month, Nam = d.Year });
            }
            cboThang.DisplayMember = "Display";
            cboThang.SelectedIndex = 0;
        }


        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic sel = cboThang.SelectedItem;
            _thang = sel.Thang; _nam = sel.Nam;
            LoadTatCa();
        }


        private void LoadTatCa()
        {
            // Tab 1: Tổng quan
            LoadThongKe();
            LoadBieuDoThang();
            LoadBieuDoTheLoai();
            LoadTopSach();
            LoadTopDocGia();

            // Tab 2: Chi tiết mượn/trả
            LoadChiTietPhieuTra();

            // Tab 3: Nhật ký
            LoadNhatKy();

            // Tab 4: Xuất báo cáo
            LoadDanhSachBaoCao();
        }


        private void LoadThongKe()
        {
            var tk = _bus.GetTongQuan(_thang, _nam);
            lblLuotMuon.Text =  tk.LuotMuonThang.ToString("N0");
            lblTraDung.Text = $"{tk.TraDungHan:N0} ({tk.TiLeDungHan}%)";
            lblTraTre.Text = tk.TraTreHan.ToString("N0");
            lblTienPhat.Text = FormatVND(tk.TongPhatThang);
        }

		private void LoadBieuDoThang()
		{
			var ds = _bus.GetThongKe7Thang();
			chartThang.Series.Clear();

			chartThang.ChartAreas[0].BackColor = Color.Transparent;
			chartThang.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 80);
			chartThang.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 80);
			chartThang.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
			chartThang.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
			chartThang.ChartAreas[0].AxisX.LineColor = Color.White;
			chartThang.ChartAreas[0].AxisY.LineColor = Color.White;

			var sMuon = new Series("Mượn")
			{
				ChartType = SeriesChartType.Column,
				Color = Color.FromArgb(100, 150, 255),
				BorderWidth = 2
			};
			var sTra = new Series("Trả")
			{
				ChartType = SeriesChartType.Column,
				Color = Color.FromArgb(0, 200, 150),
				BorderWidth = 2
			};
			var sTre = new Series("Trễ")
			{
				ChartType = SeriesChartType.Column,
				Color = Color.FromArgb(255, 80, 80),
				BorderWidth = 2
			};

			foreach (var d in ds)
			{
				sMuon.Points.AddXY(d.NhanThang, d.SoMuon);
				sTra.Points.AddXY(d.NhanThang, d.SoTra);
				sTre.Points.AddXY(d.NhanThang, d.SoTre);
			}

			chartThang.Series.Add(sMuon);
			chartThang.Series.Add(sTra);
			chartThang.Series.Add(sTre);

			chartThang.Legends[0].BackColor = Color.Transparent;
			chartThang.Legends[0].ForeColor = Color.White;
			chartThang.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

			chartThang.ChartAreas[0].AxisX.Interval = 1;
			chartThang.ChartAreas[0].AxisY.Maximum = ds.Max(x => Math.Max(x.SoMuon, Math.Max(x.SoTra, x.SoTre))) + 5;
			chartThang.ChartAreas[0].AxisY.Minimum = 0;
		}


		private void LoadBieuDoTheLoai()
		{
			var ds = _bus.GetThongKeTheLoai(_thang, _nam);
			chartTheLoai.Series.Clear();

			chartTheLoai.ChartAreas[0].BackColor = Color.Transparent;
			chartTheLoai.Legends[0].BackColor = Color.Transparent;
			chartTheLoai.Legends[0].ForeColor = Color.White;
			chartTheLoai.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

			var s = new Series
			{
				ChartType = SeriesChartType.Doughnut,
				Font = new Font("Segoe UI", 9, FontStyle.Bold),
				LabelForeColor = Color.White
			};

			foreach (var d in ds)
			{
				int idx = s.Points.AddXY(d.TenTheLoai, d.SoLuotMuon);
				s.Points[idx].Label = $"{d.TiLe}%";
			}

			var colors = new[]
			{
		        Color.FromArgb(100, 150, 255), 
                Color.FromArgb(255, 180, 80), 
                Color.FromArgb(255, 80, 80),   
                Color.FromArgb(0, 200, 150),   
                Color.FromArgb(180, 100, 255)  
    };

			for (int i = 0; i < s.Points.Count; i++)
			{
				s.Points[i].Color = colors[i % colors.Length];
			}

			chartTheLoai.Series.Add(s);

			chartTheLoai.ChartAreas[0].Area3DStyle.Enable3D = false;
			chartTheLoai.ChartAreas[0].InnerPlotPosition.Auto = false;
			chartTheLoai.ChartAreas[0].InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
		}


		private void LoadTopSach()
        {
            var ds = _bus.GetTopSach(_thang, _nam);
            dgvTopSach.DataSource = null;

            dgvTopSach.Columns.Clear();
            dgvTopSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TieuDe", HeaderText = "Tiêu đề", Width = 250 });
            dgvTopSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenTheLoai", HeaderText = "Thể loại", Width = 120 });
            dgvTopSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuotMuon", HeaderText = "Lượt mượn", Width = 90 });

            dgvTopSach.DataSource = ds;
        }

        private void LoadTopDocGia()
        {
            var ds = _bus.GetTopDocGia1(_thang, _nam);
            dgvTopDG.DataSource = null;

            dgvTopDG.Columns.Clear();
            dgvTopDG.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên", Width = 200 });
            dgvTopDG.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLanMuon", HeaderText = "Số lần", Width = 80 });
            dgvTopDG.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLanTre", HeaderText = "Lần trễ", Width = 70 });

            dgvTopDG.DataSource = ds;
        }



        private void LoadChiTietPhieuTra()
        {
            var ds = _bus.GetChiTietPhieuTra(_thang, _nam, txtTimKiemTra.Text);

			dgvPhieuTra.Columns.Clear();
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPhieuTra", HeaderText = "Mã phiếu trả", Width = 100 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPhieuMuon", HeaderText = "Mã mượn", Width = 100 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDocGia", HeaderText = "Độc giả", Width = 150 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayTra", HeaderText = "Ngày trả", Width = 100 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TinhTrangSach", HeaderText = "Tình trạng", Width = 120 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoTien", HeaderText = "Tiền phạt", Width = 90 });
            dgvPhieuTra.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoNgayTre", HeaderText = "Ngày trễ", Width = 80 });

            dgvPhieuTra.DataSource = ds;
        }


		private void txtTimKiemTra_TextChanged(object sender, EventArgs e)
		{

			LoadChiTietPhieuTra();
		}


		private void LoadNhatKy()
        {
            var ds = _bus.GetNhatKy(100);
            dgvNhatKy.DataSource = null;
            dgvNhatKy.AutoGenerateColumns = false;

            dgvNhatKy.Columns.Clear();
            dgvNhatKy.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThoiGian", HeaderText = "Thời gian", Width = 150 });
            dgvNhatKy.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoaiHanhDong", HeaderText = "Loại", Width = 100 });
            dgvNhatKy.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MoTa", HeaderText = "Mô tả", Width = 200 });
            dgvNhatKy.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NguoiThucHien", HeaderText = "Người thực hiện", Width = 150 });

            dgvNhatKy.DataSource = ds;
        }




        private void LoadDanhSachBaoCao()
        {
            var ds = _bus.GetDanhSachBaoCao();
            flpBaoCao.Controls.Clear();
            foreach (var bc in ds)
            {
                var btn = new Guna2Button
                {
                    Text = $"{bc.TenBaoCao} ({bc.LoaiFile})",
                    Tag = bc,
                    Width = 220,
                    Height = 50,
                    BorderRadius = 8,
                    Margin = new Padding(8),
                    FillColor = BG_CARD,
                    ForeColor = TEXT_PRI
                };


				btn.Click += (s, e) =>
				{
					SaveFileDialog sfd;

					switch (bc.TenBaoCao)
					{
						case "Báo cáo mượn/trả tháng":
							var tk = _bus.GetTongQuan(_thang, _nam);
							sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"BaoCaoTongQuan_{_thang}_{_nam}.pdf" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatPDFBaoCao(tk, _thang, _nam, sfd.FileName);
							break;

						case "Chi tiết phiếu mượn":
							var dsPhieu = _bus.GetDanhSachPhieuMuon();
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"ChiTietPhieuMuon_{_thang}_{_nam}.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelPhieuMuon(dsPhieu, sfd.FileName);
							break;

						case "Danh sách quá hạn":
							var dsQuaHan = _bus.GetDanhSachQuaHan();
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"QuaHan_{_thang}_{_nam}.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelQuaHan(dsQuaHan, sfd.FileName);
							break;

						case "Danh sách độc giả":
							var dsDG = _bus.GetDanhSachDocGia();
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"DocGia.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelDocGia(dsDG, sfd.FileName);
							break;
						case "Thẻ sắp hết hạn":
							var dsThe = _bus.GetTheSapHetHan();
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"TheSapHetHan.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelTheSapHetHan(dsThe, sfd.FileName);
							break;

						case "Top độc giả tích cực":
							var dsTopDG = _bus.GetTopDocGia(_thang, _nam);
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"TopDocGia.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelTopDocGia(dsTopDG, sfd.FileName);
							break;

						case "Top sách":
							var dsTopSach = _bus.GetTopSach(_thang, _nam);
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"TopSach.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelTopSach(dsTopSach, sfd.FileName);
							break;
						case "Tồn kho sách":
							var dsTonKho = _bus.GetTonKhoSach();
							sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = $"TonKhoSach.xlsx" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatExcelTonKho(dsTonKho, sfd.FileName);
							break;

						case "Báo cáo phạt & thu phí":
							var tongPhat = _bus.GetTongPhat(_thang, _nam);
							sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"BaoCaoPhat_{_thang}_{_nam}.pdf" };
							if (sfd.ShowDialog() == DialogResult.OK)
								ExportHelper.XuatPDFPhat(tongPhat, _thang, _nam, sfd.FileName);
							break;

					}
				};



				flpBaoCao.Controls.Add(btn);
            }
        }



        // ── HELPER ───────────────────────────────────────────
        static string FormatVND(decimal v)
        {
            if (v >= 1_000_000) return $"{v / 1_000_000:0.#}tr";
            if (v >= 1_000) return $"{v / 1_000:0}k";
            return $"{v:N0}đ";
        }   

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: // Tổng quan
                    LoadThongKe();
                    LoadBieuDoThang();
                    LoadBieuDoTheLoai();
                    LoadTopSach();
                    LoadTopDocGia();
                    break;
                case 1: // Chi tiết mượn/trả
                    LoadChiTietPhieuTra();
                    break;
                case 2: // Nhật ký
                    LoadNhatKy();
                    break;
                case 3: // Xuất báo cáo
                    LoadDanhSachBaoCao();
                    break;
            }
        }

    




		
		private void btnXuatPDF_Click(object sender, EventArgs e)
        {
			// Lấy dữ liệu thống kê tổng quan
			var tk = _bus.GetThongKe(_thang,_nam);

			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "PDF Files|*.pdf",
				FileName = $"BaoCaoTongQuan_{_thang}_{_nam}.pdf"
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				ExportHelper.XuatPDFBaoCao(tk, _thang, _nam, sfd.FileName);
				MessageBox.Show("Xuất PDF thành công!");
			}
		}

		private void btnXuatExcelBaoCao_Click(object sender, EventArgs e)
		{
			// Lấy dữ liệu thống kê tổng quan
			var tk = _bus.GetThongKe(_thang,_nam);

			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "Excel Files|*.xlsx",
				FileName = $"BaoCaoTongQuan_{_thang}_{_nam}.xlsx"
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				ExportHelper.XuatExcelBaoCao(tk, _thang, _nam, sfd.FileName);
				MessageBox.Show("Xuất Excel thành công!");
			}
		}

		private void guna2Panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		
	}
}
