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
using System.IO;

namespace WindowsFormsApp1
{
	public partial class frmQuanLyKeSach : Form
	{
		BUS_KeSach ks = new BUS_KeSach();
		public frmQuanLyKeSach()
		{
			InitializeComponent();
		}

		private void frmQuanLyKeSach_Load(object sender, EventArgs e)
		{


			dgvKeSach.DataSource = ks.LayDanhSachKe();

			// Cột Action

			var colEdit = new DataGridViewImageColumn();
			colEdit.Name = "Edit";
			colEdit.Image = Properties.Resources.update; // ảnh bạn thêm vào Resources
			colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvKeSach.Columns.Add(colEdit);

			var colDelete = new DataGridViewImageColumn();
			colDelete.Name = "Delete";
			colDelete.Image = Properties.Resources.delete;
			colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvKeSach.Columns.Add(colDelete);


		}



		private void btnThem_Click(object sender, EventArgs e)
		{
			frmThemKeSach frm = new frmThemKeSach(); // mở form thêm mới
			frm.ShowDialog();
			dgvKeSach.DataSource = ks.LayDanhSachKe(); // refresh lại sau khi thêm
		}

		private void dgvKeSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string maKe = dgvKeSach.Rows[e.RowIndex].Cells["MaKe"].Value.ToString();

				// Nếu click vào cột Sửa
				if (dgvKeSach.Columns[e.ColumnIndex].HeaderText == "Edit")
				{
					frmThemKeSach frm = new frmThemKeSach(maKe); // truyền mã kệ để sửa
					frm.ShowDialog();
					dgvKeSach.DataSource = ks.LayDanhSachKe(); // refresh lại
				}

				// Nếu click vào cột Xóa
				else if (dgvKeSach.Columns[e.ColumnIndex].HeaderText == "Delete")
				{
					DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa kệ này?", "Xác nhận", MessageBoxButtons.YesNo);
					if (dr == DialogResult.Yes)
					{
						if (ks.XoaKe(maKe))
						{
							MessageBox.Show("Xóa kệ thành công!");
							dgvKeSach.DataSource = ks.LayDanhSachKe();
						}
						else
						{
							MessageBox.Show("Xóa kệ thất bại!");
						}
					}
				}
				else
				{
					// Nếu click vào dòng bất kỳ → hiển thị ảnh/map
					string imageName = dgvKeSach.Rows[e.RowIndex].Cells["HinhAnh"].Value?.ToString();
					if (!string.IsNullOrEmpty(imageName))
					{
						var img = (Image)Properties.Resources.ResourceManager.GetObject(imageName.Trim());
						picKeSach.Image = img ?? null;
					}

				}
			}
		}

		
		
	}
}
