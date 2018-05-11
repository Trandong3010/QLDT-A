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
			if (dialogresult == DialogResult.Yes)
			{
				try
				{
					if (tk.Update(Control1()) > 0)
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
			CheckBox MatKhau = new CheckBox();
			CheckBox ChucNang = new CheckBox();
			TaiKhoan a = new TaiKhoan(comboBoxTaiKhoan.Text, MatKhau.Text, ChucNang.Text, checkBoxPhanquyen.Checked, checkBoxMatkhau.Checked, checkBoxNguoidung.Checked, checkBoxDangxuat.Checked, checkBoxHoadon.Checked, checkBoxXemsanpham.Checked, checkBoxBaohanh.Checked, checkBoxNhaphang.Checked, checkBoxTrahang.Checked, checkBoxKhachhang.Checked, checkBoxMathang.Checked, checkBoxThongtinnhanvien.Checked, checkBoxBanggia.Checked, checkBoxThongkedoanhthu.Checked, checkBoxThongkekhachhang.Checked, checkBoxThongkemathang.Checked);
			return a;
		}

		private void dataGridViewChucNang_SelectionChanged(object sender, EventArgs e)
		{
			HienThiLenConTrol();
		}

		private void HienThiLenConTrol()
		{
			CheckBox MatKhau = new CheckBox();
			CheckBox ChucNang = new CheckBox();
			if(dataGridViewChucNang.SelectedRows.Count > 0)
			{
				comboBoxTaiKhoan.Text = dataGridViewChucNang.SelectedRows[0].Cells[0].Value.ToString();
				MatKhau.Text = dataGridViewChucNang.SelectedRows[0].Cells[1].Value.ToString();
				ChucNang.Text = dataGridViewChucNang.SelectedRows[0].Cells[2].Value.ToString();
				checkBoxPhanquyen.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[3].Value.ToString());
				checkBoxMatkhau.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[4].Value.ToString());
				checkBoxNguoidung.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[5].Value.ToString());
				checkBoxDangxuat.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[6].Value.ToString());
				checkBoxHoadon.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[7].Value.ToString());
				checkBoxXemsanpham.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[8].Value.ToString());
				checkBoxBaohanh.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[9].Value.ToString());
				checkBoxNhaphang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[10].Value.ToString());
				checkBoxTrahang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[11].Value.ToString());
				checkBoxKhachhang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[12].Value.ToString());
				checkBoxMathang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[13].Value.ToString());
				checkBoxThongtinnhanvien.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[14].Value.ToString());
				checkBoxBanggia.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[15].Value.ToString());
				checkBoxThongkedoanhthu.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[16].Value.ToString());
				checkBoxThongkekhachhang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[17].Value.ToString());
				checkBoxThongkemathang.Checked = bool.Parse(dataGridViewChucNang.SelectedRows[0].Cells[18].Value.ToString());
			}
		}
	}
}