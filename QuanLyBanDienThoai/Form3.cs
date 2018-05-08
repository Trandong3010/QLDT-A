using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace QuanLyBanDienThoai
{
	public partial class FormDangNhap : Form
	{
		public FormDangNhap()
		{
			InitializeComponent();
			textBoxMatKhau.PasswordChar = '*';
		}
		
		FormQLCHBanDT QLCHDT = new FormQLCHBanDT();

		TaiKhoan tk = new TaiKhoan();

		private void buttonDangNhap_Click(object sender, EventArgs e)
		{

			Login1();
		}
		//private void Login()
		//{
		//	FormQLCHBanDT qldt = new FormQLCHBanDT();

		//	string user = textBoxTenTK.Text;
		//	string MK = textBoxMatKhau.Text;
		//	if (textBoxTenTK.Text.Length == 0 || textBoxMatKhau.Text.Length == 0)
		//	{
		//		MessageBox.Show("Bạn chưa nhập tên hoặc mật khẩu");
		//	}
		//	else
		//	{
		//		int n = tk.DangNhap(user, MK).Rows.Count;
		//		if (n!=0)
		//		{
		//			//tk.DangNhap(textBoxTenTK.Text, textBoxMatKhau.Text).ToString();
		//			//MessageBox.Show("Bạn đã đăng nhập thành công!");
		//			this.Hide();
		//			qldt.ShowDialog();
		//			this.Show();
					
		//		}
		//		else
		//			MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
		//	}

		//}

		private void Login1()
		{
			
			BaseFunctions<TaiKhoan> tk1 = new BaseFunctions<TaiKhoan>();
			DataTable dt = tk1.ChucNang();
			string user = textBoxTenTK.Text;
			string MK = textBoxMatKhau.Text;
			int KQ = tk.DangNhap(user, MK).Rows.Count;
			if (textBoxTenTK.Text.Length == 0 || textBoxMatKhau.Text.Length == 0)
			{
				MessageBox.Show("Bạn chưa nhập tên hoặc mật khẩu");
			}
			switch (KQ)
			{
				case 0:
					MessageBox.Show("mật khẩu không đúng!");
					break;
				case 1:
					this.Hide();
							FormQLCHBanDT qldt = new FormQLCHBanDT(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
							qldt.ShowDialog();
					
					
					this.Show();
					break;
			}
		}

		private void FormDangNhap_Load(object sender, EventArgs e)
		{
			textBoxTenTK.Focus();
		}

		private void textBoxTenTK_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) textBoxMatKhau.Focus();
		}

		private void textBoxMatKhau_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) buttonDangNhap_Click(sender, e);
		}

		private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void buttonHuy_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
