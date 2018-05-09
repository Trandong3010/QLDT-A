using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DataAccess;

namespace QuanLyBanDienThoai
{
	public partial class PhanQuyen : DevComponents.DotNetBar.OfficeForm
	{
		public PhanQuyen()
		{
			InitializeComponent();
		}

		BaseFunctions<TaiKhoan> tk = new BaseFunctions<TaiKhoan>();

		public void DataChucNang()
		{
			dataGridViewChucNang.DataSource = tk.PhanQuyen_Get(); 
		}

		private void dataGridViewChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void PhanQuyen_Load(object sender, EventArgs e)
		{
			DataChucNang();
		}

		private void comboBoxTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
		{
			QLPhanQuyen a = new QLPhanQuyen();
			DataTable dt = a.TenTaiKhoan();
			comboBoxTaiKhoan.DataSource = dt;
			comboBoxTaiKhoan.DisplayMember = "TenTaiKhoan";
			comboBoxTaiKhoan.ValueMember = "TenTaiKhoan";
		}
	}
}