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
	public partial class frmQuanLySach : Form
	{
		public frmQuanLySach()
		{
			InitializeComponent();
		}
		SachBUS bs = new SachBUS();
		private void frmQuanLySach_Load(object sender, EventArgs e)
		{

			var tk = bs.GetThongKe();
			lblTongSach.Text = tk.TongSach.ToString();
			lblSachCon.Text = tk.SachConTrongKho.ToString();
			lblDangMuon.Text = tk.DangMuon.ToString();
			lblTheLoai.Text = tk.SoTheLoai.ToString();


			dgvSach.DataSource = bs.GetAll();

			// Cột Action

			var colEdit = new DataGridViewImageColumn();
			colEdit.Name = "Edit";
			colEdit.Image = Properties.Resources.update; // ảnh bạn thêm vào Resources
			colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvSach.Columns.Add(colEdit);

			var colDelete = new DataGridViewImageColumn();
			colDelete.Name = "Delete";
			colDelete.Image = Properties.Resources.delete;
			colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvSach.Columns.Add(colDelete);
		}

		private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string maSach = dgvSach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();

				// Nếu click vào cột Sửa
				if (dgvSach.Columns[e.ColumnIndex].HeaderText == "Edit")
				{
					frmThemSach frm = new frmThemSach(maSach); // truyền mã kệ để sửa
					frm.ShowDialog();
					dgvSach.DataSource = bs.GetAll(); // refresh lại
				}

				// Nếu click vào cột Xóa
				else if (dgvSach.Columns[e.ColumnIndex].HeaderText == "Delete")
				{
					DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa kệ này?", "Xác nhận", MessageBoxButtons.YesNo);
					if (dr == DialogResult.Yes)
					{
						var result = bs.Xoa(maSach);	
						if (result.ok)
						{
							MessageBox.Show("Xóa kệ thành công!");
							dgvSach.DataSource = bs.GetAll();
						}
						else
						{
							MessageBox.Show("Xóa kệ thất bại!");
						}
					}
				}
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmThemSach frm = new frmThemSach();
			frm.ShowDialog();
			dgvSach.DataSource = bs.GetAll(); 
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			dgvSach.DataSource = bs.GetSach(txtTimKiem.Text.Trim());
		}

		private void dgvTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnKhoaTK_Click(object sender, EventArgs e)
		{

		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnSua_Click(object sender, EventArgs e)
		{

		}
	}
}
