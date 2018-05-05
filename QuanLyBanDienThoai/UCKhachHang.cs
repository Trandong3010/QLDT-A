using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace QuanLyBanDienThoai
{
	public partial class UCKhachHang : UserControl
	{
		public UCKhachHang()
		{
			InitializeComponent();
		}
		//BaseFunctions<Khachhang> kh = new BaseFunctions<Khachhang>();
		//private void label72_Click(object sender, EventArgs e)
		//{

		//}
		//private Khachhang GetInformation()
		//{
		//	int id = (this.maskedTextBoxMaKH.Text.Length == 0) ? 0 : int.Parse(this.maskedTextBoxMaKH.Text);
		//	Khachhang p = new Khachhang(id, this.textBoxTenKH.Text, this.textBoxDiaChiKH.Text, this.textBoxMailKH.Text, this.maskedTextBoxSDTKhachhang.Text);
		//	return p;
		//}
		//private void buttonThemKH_Click(object sender, EventArgs e)
		//{

		//}

		//private void buttonXoaKH_Click(object sender, EventArgs e)
		//{
		//	if (this.maskedTextBoxMaKH.Text.Length > 0 && kh.Delete(int.Parse(this.maskedTextBoxMaKH.Text)) > 0)
		//	{
		//		MessageBox.Show("Delete sucessful");
		//		LoadDataKhachHang();
		//		ResetKhachHang();
		//	}
		//	else
		//		MessageBox.Show("Delete unsucessful");
		//}

		//private void buttonSuaKH_Click(object sender, EventArgs e)
		//{
		//	if (kh.Update(GetInformation()) > 0)
		//	{
		//		MessageBox.Show("Update sucessful");
		//		LoadDataKhachHang();
		//		ResetKhachHang();
		//	}
		//	else
		//		MessageBox.Show("Update unsucessful");
		//}

		//private void LoadDataKhachHang()
		//{
		//	this.dataGridViewKhachHang.DataSource = kh.SelectAll();
		//}

		//private void SetDataConTrolsKhachHang()
		//{
		//	if (dataGridViewKhachHang.SelectedRows.Count > 0)
		//	{
		//		this.maskedTextBoxMaKH.Text = this.dataGridViewKhachHang.SelectedRows[0].Cells[0].Value.ToString();
		//		this.textBoxTenKH.Text = this.dataGridViewKhachHang.SelectedRows[0].Cells[1].Value.ToString();
		//		this.textBoxDiaChiKH.Text = this.dataGridViewKhachHang.SelectedRows[0].Cells[2].Value.ToString();
		//		this.maskedTextBoxSDTKhachhang.Text = this.dataGridViewKhachHang.SelectedRows[0].Cells[4].Value.ToString();
		//		this.textBoxMailKH.Text = this.dataGridViewKhachHang.SelectedRows[0].Cells[3].Value.ToString();
		//	}

		//}

		//private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
		//{
		//	SetDataConTrolsKhachHang();
		//}

		//private void ResetKhachHang()
		//{
		//	this.maskedTextBoxMaKH.Text = "";
		//	this.textBoxTenKH.Text = "";
		//	this.textBoxDiaChiKH.Text = "";
		//	this.maskedTextBoxSDTKhachhang.Text = "";
		//	this.textBoxMailKH.Text = "";
		//}

		//private void TimKhachHangTheoMa()
		//{
		//	if (this.textBoxTimKH.Text.Length > 0)
		//	{
		//		List<Khachhang> KhTim = new List<Khachhang>();
		//		int n;
		//		if (int.TryParse(this.textBoxTimKH.Text, out n))
		//			KhTim = kh.SelectByID("MaKH", n);
		//		this.dataGridViewKhachHang.DataSource = KhTim;
		//	}
		//}
		//private void TimKhachHangTheoTen()
		//{
		//	if (this.textBoxTimKH.Text.Length > 0)
		//	{
		//		List<Khachhang> KhTim = new List<Khachhang>();
		//		KhTim = kh.SelectByID("TenKH", this.textBoxTimKH.Text);
		//		this.dataGridViewKhachHang.DataSource = KhTim;
		//	}
		//}

		//private void buttonTimKH_Click(object sender, EventArgs e)
		//{
		//	if (this.radioButtonMaKH.Checked == true)
		//		TimKhachHangTheoMa();
		//	else if (this.radioButtonTenKH.Checked == true)
		//		TimKhachHangTheoTen();
		//}
	}
}
