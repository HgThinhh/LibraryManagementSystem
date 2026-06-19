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
    public partial class frmThemTaiKhoan : Form
    {
        TaiKhoanBUS _bus = new TaiKhoanBUS();
        public frmThemTaiKhoan(TaiKhoanBUS bus)
        {
            InitializeComponent();
            _bus = bus;
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboVaiTro();
        }
        private void LoadComboVaiTro()
        {
            var dsVaiTro = _bus.GetAllVaiTro(); // giả sử BUS có hàm này
            cboVaiTro.DataSource = dsVaiTro;
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "MaVaiTro";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            var vaiTro = ((VaiTroET)cboVaiTro.SelectedItem).TenVaiTro;

            // Kiểm tra ràng buộc nhập liệu theo vai trò
            if ((vaiTro == "Admin" || vaiTro == "ThuThu") && string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Admin/Thủ thư bắt buộc phải nhập Mã Nhân Viên!");
                return;
            }
            if ((vaiTro == "Admin" || vaiTro == "ThuThu") && !string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Admin/Thủ thư không được nhập Mã Độc Giả!");
                return;
            }
            if (vaiTro == "DocGia" && string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Độc giả bắt buộc phải nhập Mã Độc Giả!");
                return;
            }
            if (vaiTro == "DocGia" && !string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Độc giả không được nhập Mã Nhân Viên!");
                return;
            }

            var tk = new TaiKhoanET
            {
                TenDangNhap = txtTenDN.Text.Trim(),
                MatKhau = txtMK.Text,
                MaVaiTro = ((VaiTroET)cboVaiTro.SelectedItem).MaVaiTro,
                TenVaiTro = ((VaiTroET)cboVaiTro.SelectedItem).TenVaiTro,
                MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? null : txtMaNV.Text.Trim(),
                MaDocGia = string.IsNullOrEmpty(txtMaDG.Text) ? null : txtMaDG.Text.Trim(),
            };

            var (ok, msg) = _bus.ThemTaiKhoan(tk, txtXN.Text);
            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

   
    }
}
