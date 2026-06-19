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
	public partial class frmQuanLyDocGia : Form
	{
		BUS_DocGia bs = new BUS_DocGia();
		TheThuVienBUS bus= new TheThuVienBUS();

		public frmQuanLyDocGia()
		{
			InitializeComponent();
		}

		private void frmQuanLyDocGia_Load(object sender, EventArgs e)
		{


			//Thống Kê
			var bus = new ThongKeTheBUS();
			var tk = bus.GetThongKe();

			lblTongDocGia.Text = tk.TongDocGia.ToString();
			lblTheConHan.Text = tk.TheConHan.ToString();
			lblTheHetHan.Text = tk.TheHetHan.ToString();
			lblTheBiKhoa.Text = tk.TheBiKhoa.ToString();



			//Datagird
			dgvDocGia.DataSource = bs.GetAll();

			// Cột Action

			var colEdit = new DataGridViewImageColumn();
			colEdit.Name = "Sửa Độc Giả";
			colEdit.Image = Properties.Resources.update; // ảnh bạn thêm vào Resources
			colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvDocGia.Columns.Add(colEdit);

			var colDelete = new DataGridViewImageColumn();
			colDelete.Name = "Xoá Độc Giả";
			colDelete.Image = Properties.Resources.delete;
			colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // tự co giãn vừa ô
			dgvDocGia.Columns.Add(colDelete);




		}



		private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{

				string maDocGia = dgvDocGia.Rows[e.RowIndex].Cells["MaDocGIa"].Value.ToString();

				// Nếu click vào cột Sửa
				if (dgvDocGia.Columns[e.ColumnIndex].HeaderText == "Sửa Độc Giả")
				{
					frmThemDocGia frm = new frmThemDocGia(maDocGia);
					frm.ShowDialog();
					dgvDocGia.DataSource = bs.GetAll();
				}

				// Nếu click vào cột Xóa
				else if (dgvDocGia.Columns[e.ColumnIndex].HeaderText == "Xoá Độc Giả")
				{
					DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa độc giả này?",
													  "Xác nhận", MessageBoxButtons.YesNo);
					if (dr == DialogResult.Yes)
					{
						var result = bs.Xoa(maDocGia);
						if (result.ok)
						{
							MessageBox.Show(result.msg); // "Xóa độc giả thành công!"
							dgvDocGia.DataSource = bs.GetAll();
						}
						else
						{
							MessageBox.Show(result.msg); // ví dụ: "Độc giả có thẻ thành viên nên không thể xóa!"
						}
					}
				}
		

			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmThemDocGia frm = new frmThemDocGia(); 
			frm.ShowDialog();
			dgvDocGia.DataSource = bs.GetAll();
		}

		private void btnCapThe_Click(object sender, EventArgs e)
		{
			if (dgvDocGia.CurrentRow != null)
			{
				// Lấy mã độc giả từ dòng đang chọn
				string maDocGia = dgvDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();

				// Kiểm tra xem độc giả đã có thẻ chưa
				var existing = bus.GetByDocGia(maDocGia);

				if (existing != null)
				{
					// Đã có thẻ → truyền cả mã độc giả và mã thẻ để sửa
					frmThemTheThuVien frm = new frmThemTheThuVien(maDocGia, existing.MaThe);
					frm.ShowDialog();
				}
				else
				{
					// Chưa có thẻ → chỉ truyền mã độc giả, thêm mới
					frmThemTheThuVien frm = new frmThemTheThuVien(maDocGia);
					frm.ShowDialog();
				}

				// Sau khi cấp/sửa thẻ xong, reload danh sách độc giả
				dgvDocGia.DataSource = bs.GetAll();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một độc giả trước khi cấp thẻ!");
			}
		}

		private void dgvDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvDocGia.Columns[e.ColumnIndex].Name == "TrangThaiThe" && e.Value != null)
			{
				string status = e.Value.ToString();

				if (status == "Còn hiệu lực")
				{
					e.CellStyle.ForeColor = Color.Green;  
				}
				else if (status == "Hết hạn")
				{
					e.CellStyle.ForeColor = Color.Orange;     
				}
				else if (status == "Bị khóa")
				{
					e.CellStyle.ForeColor = Color.Red;  
				}
				else if (status == "Chưa có thẻ")
				{
					e.CellStyle.ForeColor = Color.Gray;    
				}
			}
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			dgvDocGia.DataSource = bs.GetDocGia(txtTimKiem.Text.Trim());
		}
	}
}
