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
		public static string TenTaiKhoan = "";
		public static bool Phanquyen;
		public static bool Matkhau;
		public static bool Nguoidung;
		public static bool Dangxuat;
		public static bool Hoadon;
		public static bool Xemsanpham;
		public static bool Baohanh;
		public static bool Nhaphang;
		public static bool Trahang;
		public static bool Khachhang;
		public static bool Mathang;
		public static bool Nhanvien;
		public static bool Banggia;
		public static bool TKdoanhthu;
		public static bool TKKhachhang;
		public static bool TKMathang;
		
		FormQLCHBanDT QLCHDT = new FormQLCHBanDT();

		TaiKhoan tk = new TaiKhoan();
		QLPhanQuyen a = new QLPhanQuyen();
		private void buttonDangNhap_Click(object sender, EventArgs e)
		{

			Login1();
		}
		private bool PhanQuyen(int col)
		{
			string user = textBoxTenTK.Text;
			string MK = textBoxMatKhau.Text;
			bool kiemtra = false;
			for (int i = 0; i < tk.DangNhap(user, MK).Rows.Count; i++)
			{
				if (tk.DangNhap(user, MK).Rows[i][col].ToString() == "True")
					return kiemtra = true;
			}
			return kiemtra;
		}

		private void Login1()
		{
			FormQLCHBanDT qldt = new FormQLCHBanDT();
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
					TenTaiKhoan = tk.DangNhap(user, MK).Rows[0][1].ToString();
					Phanquyen = PhanQuyen(4);
					Matkhau = PhanQuyen(5);
					Nguoidung = PhanQuyen(6);
					Dangxuat = PhanQuyen(7);
					Hoadon = PhanQuyen(8);
					Xemsanpham = PhanQuyen(9);
					Nhaphang = PhanQuyen(10);
					Trahang = PhanQuyen(11);
					Khachhang = PhanQuyen(12);
					Mathang = PhanQuyen(13);
					Nhanvien = PhanQuyen(14);
					Banggia = PhanQuyen(15);
					TKdoanhthu = PhanQuyen(16);
					TKKhachhang = PhanQuyen(17);
					TKMathang = PhanQuyen(18);
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
