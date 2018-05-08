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
	public partial class ThayDoiMatKhau : DevComponents.DotNetBar.OfficeForm
	{
		public ThayDoiMatKhau()
		{
			InitializeComponent();
		}
		TaiKhoan tk = new TaiKhoan();
		QLTaiKhoan qltk = new QLTaiKhoan();
		private void buttonLuu_Click(object sender, EventArgs e)
		{
			string user = textBoxTenDN.Text;
			string MKHienTai = textBoxMatKhauHienTai.Text;
			string MKMoi = textBoxMatKhauMoi.Text;
			string XNMatKhau = textBoxXacNhanMatKhauMoi.Text;
			if (textBoxMatKhauHienTai.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại!");
			else if (textBoxMatKhauMoi.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu mới!");
			else if (textBoxXacNhanMatKhauMoi.Text == "") MessageBox.Show("Bạn chưa nhập lại mật khẩu mới!");
			else if (textBoxMatKhauMoi.Text != textBoxXacNhanMatKhauMoi.Text) MessageBox.Show("Mật khẩu không khớp!"); 
			else if(textBoxMatKhauMoi.Text != textBoxXacNhanMatKhauMoi.Text) MessageBox.Show("Mật khẩu không khớp!");
			else
			{
				qltk.DoiMatKhau(user, MKMoi);
				MessageBox.Show("Đổi mật khẩu thành công");
			}
		}
	}
}