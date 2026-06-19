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

namespace WindowsFormsApp1
{
    public partial class frmQuaHan : Form
    {
        private BUS_PhieuMuon _bus = new BUS_PhieuMuon();
        public frmQuaHan()
        {
            InitializeComponent();
        }


        private void frmQuaHan_Load(object sender, EventArgs e)
        {
            LoadDanhSachQuaHan();
        }

        private void LoadDanhSachQuaHan()
        {
            var ds = _bus.GetDanhSachPhieuMuon("Quá hạn");
            dgvQuaHan.Rows.Clear();
            dgvQuaHan.Columns.Clear();

            dgvQuaHan.Columns.Add("MaPhieuMuon", "Mã phiếu");
            dgvQuaHan.Columns.Add("TenDocGia", "Độc giả");
            dgvQuaHan.Columns.Add("HanTra", "Hạn trả");
            dgvQuaHan.Columns.Add("SoNgayTre", "Số ngày trễ");
            dgvQuaHan.Columns.Add("TienPhat", "Tiền phạt TT");
            dgvQuaHan.Columns.Add("SoSach", "Số sách");
            dgvQuaHan.Columns.Add("LoaiPhieu", "Loại phiếu"); // thêm cột phân biệt

            foreach (var pm in ds)
            {
                decimal phat = pm.SoNgayTre * BUS_PhieuMuon.PHI_TRE_MOI_NGAY;
                string loai = pm.TrangThai == "Đang mượn" ? "Chưa trả" : "Đã trả trễ";

                int row = dgvQuaHan.Rows.Add(
                    pm.MaPhieuMuon,
                    pm.TenDocGia,
                    pm.HanTra.HasValue ? pm.HanTra.Value.ToString("dd/MM/yyyy") : "",
                    $"{pm.SoNgayTre} ngày",
                    $"{phat:N0}đ",
                    pm.SoSachMuon,
                    loai
                );

                // Tô màu đỏ cho dễ nhận biết
                dgvQuaHan.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
            }
        }


        private void btnRefeshQH_Click_1(object sender, EventArgs e)
        {
            LoadDanhSachQuaHan();
            this.Close();
        }

        private void btnXuLyQuaHan_Click_1(object sender, EventArgs e)
        {
            if (dgvQuaHan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu quá hạn cần xử lý!");
                return;
            }

            string maPhieu = dgvQuaHan.SelectedRows[0].Cells["MaPhieuMuon"].Value?.ToString() ?? "";

            // Mở frmPhieuTra và truyền mã phiếu
            frmPhieuTra frm = new frmPhieuTra(maPhieu); // dùng constructor nhận mã phiếu
            frm.Show();
        }
    }
}
