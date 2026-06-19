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
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmThongBao : Form
    {
        ThongBaoBUS _bus = new ThongBaoBUS();
        public frmThongBao()
        {
            InitializeComponent();
            LoadThongBao("Tất cả");
        }
        private void LoadThongBao(string loai)
        {
            flpThongBao.Controls.Clear();
       
            var ds = _bus.GetAll(loai);

            if (ds.Count == 0)
            {
                flpThongBao.Controls.Add(new Label
                {
                    Text = "Không có thông báo",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top
                });
                return;
            }

            foreach (var tb in ds)
            {
                flpThongBao.Controls.Add(TaoThongBaoItem(tb));
            }
        }

        private Guna2Panel TaoThongBaoItem(ThongBaoET tb)
        {
            Color borderColor;
            string icon;

            switch (tb.LoaiTB)
            {
                case "QuaHan":
                    borderColor = Color.Red;
                    icon = "⚠";
                    break;

                case "DocGiaMoi":
                    borderColor = Color.DodgerBlue;
                    icon = "👤";
                    break;

                case "KeSapDay":
                    borderColor = Color.Goldenrod;
                    icon = "📦";
                    break;

                default:
                    borderColor = Color.Teal;
                    icon = "ℹ";
                    break;
            }


            var pnl = new Guna2Panel
            {
                Width = 500,
                Height = 60,
                BorderColor = borderColor,
                BorderThickness = 1,
                BorderRadius = 6,
                BackColor = tb.DaDoc ? Color.FromArgb(26, 32, 48) : Color.FromArgb(8, 79, 142, 247),
                Margin = new Padding(4),
                Cursor = Cursors.Hand
            };

            var lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 14f),
                Location = new Point(10, 15),
                AutoSize = true,
                ForeColor = borderColor
            };

            var lblTitle = new Label
            {
                Text = tb.TieuDe,
                Font = new Font("Segoe UI Semibold", 10f),
                Location = new Point(50, 10),
                AutoSize = true,
                ForeColor = Color.White
            };

            var lblSub = new Label
            {
                Text = $"{tb.NoiDung} · {tb.ThoiGianHienThi}",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.Gray,
                Location = new Point(50, 30),
                AutoSize = true
            };

            pnl.Controls.AddRange(new Control[] { lblIcon, lblTitle, lblSub });

            // click → đánh dấu đã đọc
            pnl.Click += (s, e) =>
            {
                _bus.DanhDauDaDoc(tb.MaThongBao);
                LoadThongBao("Tất cả");
            };

            return pnl;
        }

        // Sự kiện cho các tab
        private void btnTatCa_Click(object sender, EventArgs e) => LoadThongBao("Tất cả");
        private void btnChuaDoc_Click(object sender, EventArgs e) => LoadThongBao("Chưa đọc");
        private void btnHeThong_Click(object sender, EventArgs e) => LoadThongBao("Hệ thống");

        private void btnDaDoc_Click(object sender, EventArgs e)
        {
            _bus.DanhDauDaDoc();
            LoadThongBao("Tất cả");
        }
    
    }
}
