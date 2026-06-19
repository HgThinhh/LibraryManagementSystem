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

namespace WindowsFormsApp1
{
	public partial class frmThemKho : Form
	{

		KhoBUS bus = new KhoBUS();
		private string _maKho;

		public frmThemKho(string maKho = null)
		{
			InitializeComponent();
			_maKho = maKho;
		}

		private void frmThemKho_Load(object sender, EventArgs e)
		{
			if (_maKho != null) 
			{
				var et = bus.GetByMa(_maKho);
				if (et != null)
				{
					txtMaKho.Text = et.MaKho;
					txtTenKho.Text = et.TenKho;
					txtViTri.Text = et.ViTri;
					numTang.Value = et.Tang;
					txtPhong.Text = et.Phong;
					txtMaKho.Enabled = false;
				}
			}
			else
			{
				txtMaKho.Text = bus.SinhMaMoi();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var et = new KhoET
			{
				MaKho = txtMaKho.Text.Trim(),
				TenKho = txtTenKho.Text.Trim(),
				ViTri = txtViTri.Text.Trim(),
				Tang = (int)numTang.Value,
				Phong = txtPhong.Text.Trim()
			};

			(bool ok, string msg) result;
			if (_maKho == null)
				result = bus.Them(et);
			else
				result = bus.CapNhat(et);

			MessageBox.Show(result.msg);
			if (result.ok)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnRefeshQH_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
