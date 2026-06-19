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
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmCaiDat : Form
    {

        private readonly CaiDatBUS _bus = new CaiDatBUS();
        private CaiDatET _caiDat;
        public frmCaiDat()
        {
            InitializeComponent();
            LoadCaiDat();
        }


        private void LoadCaiDat()
        {
            _caiDat = _bus.Load();

            flpCaiDat.Controls.Clear();

            // Toggle: Giao diện sáng
            flpCaiDat.Controls.Add(TaoToggleRow("Giao diện sáng", _caiDat.IsGiaoDienSang,
                v => { _caiDat.GiaoDienSang = v ? "true" : "false"; _bus.Save(_caiDat); }));

            // Toggle: Âm thanh thông báo
            flpCaiDat.Controls.Add(TaoToggleRow("Âm thanh thông báo", _caiDat.IsAmThanhThongBao,
                v => { _caiDat.AmThanhThongBao = v ? "true" : "false"; _bus.Save(_caiDat); }));

            // Toggle: Tự động làm mới
            flpCaiDat.Controls.Add(TaoToggleRow("Tự động làm mới", _caiDat.IsTuDongLamMoi,
                v => { _caiDat.TuDongLamMoi = v ? "true" : "false"; _bus.Save(_caiDat); }));

            // Separator
            flpCaiDat.Controls.Add(new Panel { Size = new Size(260, 1), BackColor = Color.Gray, Margin = new Padding(0, 4, 0, 4) });

            // Info rows
            flpCaiDat.Controls.Add(TaoInfoRow("Làm mới mỗi", $"{_caiDat.ThoiGianLamMoi} giây"));
            flpCaiDat.Controls.Add(TaoInfoRow("Trang mặc định", _caiDat.TrangMacDinh));

            // Separator
            flpCaiDat.Controls.Add(new Panel { Size = new Size(260, 1), BackColor = Color.Gray, Margin = new Padding(0, 4, 0, 4) });

            // Action row: Sao lưu DB
            flpCaiDat.Controls.Add(TaoActionRow("💾  Sao lưu database", () => SaoluuDatabase()));
        }

        private Guna2Panel TaoToggleRow(string label, bool isOn, Action<bool> onChange)
        {
            var row = new Guna2Panel
            {
                Size = new Size(260, 42),
                BorderColor = Color.FromArgb(79, 142, 247),
                BorderThickness = 1,
                BorderRadius = 6,
                BackColor = Color.FromArgb(26, 32, 48),
                Margin = new Padding(4)
            };

            var lbl = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.White,
                Location = new Point(12, 12),
                AutoSize = true
            };

            var tog = new Guna2ToggleSwitch
            {
                Checked = isOn,
                CheckedState = { FillColor = Color.Teal },
                UncheckedState = { FillColor = Color.FromArgb(55, 65, 81) },
                Location = new Point(190, 10),
                Size = new Size(46, 22)
            };
            tog.CheckedChanged += (s, e) => onChange(tog.Checked);

            row.Controls.AddRange(new Control[] { lbl, tog });
            return row;
        }

        private Guna2Panel TaoInfoRow(string key, string val)
        {
            var row = new Guna2Panel
            {
                Size = new Size(260, 36),
                BorderColor = Color.Gray,
                BorderThickness = 1,
                BorderRadius = 6,
                BackColor = Color.FromArgb(26, 32, 48),
                Margin = new Padding(4)
            };

            var lK = new Label { Text = key, Font = new Font("Segoe UI", 9f), ForeColor = Color.Gray, Location = new Point(12, 10), AutoSize = true };
            var lV = new Label { Text = val, Font = new Font("Segoe UI Semibold", 9f), ForeColor = Color.White, Location = new Point(160, 10), AutoSize = true };

            row.Controls.AddRange(new Control[] { lK, lV });
            return row;
        }

        private Guna2Panel TaoActionRow(string text, Action onClick)
        {
            var row = new Guna2Panel
            {
                Size = new Size(260, 38),
                BorderColor = Color.FromArgb(79, 142, 247),
                BorderThickness = 1,
                BorderRadius = 6,
                BackColor = Color.FromArgb(26, 32, 48),
                Margin = new Padding(4),
                Cursor = Cursors.Hand
            };

            var lbl = new Label { Text = text, Font = new Font("Segoe UI", 10f), ForeColor = Color.DodgerBlue, Location = new Point(12, 10), AutoSize = true };
            row.Controls.Add(lbl);

            row.Click += (s, e) => onClick();
            lbl.Click += (s, e) => onClick();

            return row;
        }

        private void SaoluuDatabase()
        {
            // C# 7.3 trở xuống không dùng được "using var"
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Sao lưu database";
                sfd.Filter = "SQL Backup (*.bak)|*.bak";
                sfd.FileName = $"ThuVien_{DateTime.Today:yyyyMMdd}.bak";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Đã sao lưu: {sfd.FileName}", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sao lưu đã bị hủy.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

