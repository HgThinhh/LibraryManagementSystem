using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frmXuatHoaDon : Form
	{
		public frmXuatHoaDon()
		{
			InitializeComponent();
		}

		private void btnSachTheoTL_Click(object sender, EventArgs e)
		{
			frmInDanhSachSachTheoTheLoai frm = new frmInDanhSachSachTheoTheLoai(); 
			frm.ShowDialog();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			frmInDanhSachPhieuMuon frm = new frmInDanhSachPhieuMuon();
			frm.ShowDialog();
		}

		private void brnSachTheoTacGia_Click(object sender, EventArgs e)
		{
			frmInDanhSachSachTheoTenTacGia frm = new frmInDanhSachSachTheoTenTacGia();
			frm.ShowDialog();
		}

		private void btnXuatTheThuVien_Click(object sender, EventArgs e)
		{
			frmInDanhSachTheThuVien frm = new frmInDanhSachTheThuVien();
			frm.ShowDialog();
		}

		private void btnSachNgonNgu_Click(object sender, EventArgs e)
		{
			frmInDanhSachTheoNgonNgu frm = new frmInDanhSachTheoNgonNgu();
			frm.ShowDialog();
		}

		private void btnPhiPhat_Click(object sender, EventArgs e)
		{
			frmInDanhSachPhieuPhat frm = new frmInDanhSachPhieuPhat();
			frm.ShowDialog();
		}
	}
}
