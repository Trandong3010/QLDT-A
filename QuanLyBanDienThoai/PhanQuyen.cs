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

		private void buttonLuu_Click(object sender, EventArgs e)
		{
			DialogResult dialogresult = MessageBox.Show("Bạn có thật sự muốn cập nhật?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(dialogresult == DialogResult.Yes)
			{
				try
				{
					if(tk.Update(Control1()) > 0)
					{
						MessageBox.Show("Cập nhật thành công!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Cập nhật thất bại!");
				}
			}

		}

		private TaiKhoan Control1()
		{
			TaiKhoan a = new TaiKhoan(comboBoxTaiKhoan.Text, "", "", checkBoxPhanquyen.Checked, checkBoxMatkhau.Checked, checkBoxNguoidung.Checked, checkBoxDangxuat.Checked, checkBoxHoadon.Checked, checkBoxXemsanpham.Checked, checkBoxBaohanh.Checked, checkBoxNhaphang.Checked, checkBoxTrahang.Checked, checkBoxKhachhang.Checked, checkBoxMathang.Checked, checkBoxThongtinnhanvien.Checked, checkBoxBanggia.Checked, checkBoxThongkedoanhthu.Checked, checkBoxThongkekhachhang.Checked, checkBoxThongkemathang.Checked);
			return a;
		}

		private void dataGridViewChucNang_SelectionChanged(object sender, EventArgs e)
		{
			HienThiLenConTrol();
		}

		private void HienThiLenConTrol()
		{
			if(dataGridViewChucNang.SelectedRows.Count > 0)
			{
				comboBoxTaiKhoan.Text = dataGridViewChucNang.SelectedRows[0].Cells[0].Value.ToString();
			}
		}
	}
}