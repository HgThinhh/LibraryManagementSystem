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
	public partial class frmQuanLyKho : Form
	{
		KhoBUS bus = new KhoBUS();
		public frmQuanLyKho()
		{
			InitializeComponent();
		}

		private void frmQuanLyKho_Load(object sender, EventArgs e)
		{
			LoadThongKe();
			LoadData();
			AddActionColumns();
		}

		private void LoadThongKe()
		{
			var tk = bus.GetThongKe();
			lblTongSach.Text = tk.TongSach.ToString();
			lblTongKho.Text = tk.TongKho.ToString();
			lblTongKe.Text = tk.TongKe.ToString();
			lblCongSuat.Text = tk.CongSuatTB + "%";
		}

		private void LoadData(string keyword = "")
		{
			dgvKho.DataSource = bus.GetAll(keyword);
			if (dgvKho.Columns["SoKe"] != null)
				dgvKho.Columns["SoKe"].Visible = false;

			if (dgvKho.Columns["CongSuat"] != null)
				dgvKho.Columns["CongSuat"].Visible = false;
		}

		private void AddActionColumns()
		{
			if (!dgvKho.Columns.Contains("Edit"))
			{
				var colEdit = new DataGridViewImageColumn();
				colEdit.Name = "Edit";
				colEdit.HeaderText = "Sửa";
				colEdit.Image = Properties.Resources.update;
				colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
				dgvKho.Columns.Add(colEdit);
			}

			if (!dgvKho.Columns.Contains("Delete"))
			{
				var colDelete = new DataGridViewImageColumn();
				colDelete.Name = "Delete";
				colDelete.HeaderText = "Xóa";
				colDelete.Image = Properties.Resources.delete;
				colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
				dgvKho.Columns.Add(colDelete);
			}
		}

		private void btnThemKho_Click(object sender, EventArgs e)
		{
			frmThemKho f = new frmThemKho();
			if (f.ShowDialog() == DialogResult.OK)
			{
				LoadData();
				LoadThongKe();
			}
		}

		private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string maKho = dgvKho.Rows[e.RowIndex].Cells["MaKho"].Value.ToString();

				if (dgvKho.Columns[e.ColumnIndex].Name == "Edit")
				{
					frmThemKho f = new frmThemKho(maKho);
					if (f.ShowDialog() == DialogResult.OK)
					{
						LoadData();
						LoadThongKe();
					}
				}
				else if (dgvKho.Columns[e.ColumnIndex].Name == "Delete")
				{
					var (ok, msg) = bus.Xoa(maKho);
					MessageBox.Show(msg);
					if (ok)
					{
						LoadData();
						LoadThongKe();
					}
				}
			}
		}
		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			dgvKho.DataSource = bus.GetKho(txtTimKiem.Text.Trim());
		}

		private void lblTongSach_Click(object sender, EventArgs e)
		{

		}
	}
}
