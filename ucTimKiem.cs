using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_ThuVien;

namespace WindowsFormsApp1
{
	public partial class ucTimKiem : UserControl
	{
		public ucTimKiem(KetQuaTimKiemET data)
		{
			InitializeComponent();
			_data = data;
			HienThi();
		}

		private KetQuaTimKiemET _data;

		private void HienThi()
		{
			lblIcon.Text = _data.Icon;
			lblTitle.Text = _data.TieuDe;
			lblSub.Text = _data.MoTa;
			lblTag.Text = _data.Loai;

			// Màu theo loại
			if (_data.Loai == "Sach") lblTag.ForeColor = Color.Blue;
			else if (_data.Loai == "DocGia") lblTag.ForeColor = Color.Green;
			else if (_data.Loai == "PhieuMuon") lblTag.ForeColor = Color.Purple;
		}

		private void ucTimKiem_Click(object sender, EventArgs e)
		{
			if (_data.Loai == "Sach")
				new frmQuanLySach().ShowDialog();
			else if (_data.Loai == "DocGia")
				new frmQuanLyDocGia().ShowDialog();
			else if (_data.Loai == "PhieuMuon")
				new MuonTra().ShowDialog();
		}

		private void lblTitle_Click(object sender, EventArgs e)
		{

		}
	}
}
