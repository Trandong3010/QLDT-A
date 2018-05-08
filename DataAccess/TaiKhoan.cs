using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Security.Cryptography;

namespace DataAccess
{
    public class TaiKhoan
    {
		public string TenTaiKhoan { get; set; }
		public string MatKhau { get; set; }
		public string ChucNang { get; set; }
		public string Quyen { get; set; }

		public TaiKhoan()
		{ }
		public TaiKhoan(string tenTK, string matKhau, string chucNang, string quyen)
		{
			this.TenTaiKhoan = tenTK;
			this.MatKhau = matKhau;
			this.ChucNang = chucNang;
			this.Quyen = quyen;
		}

		public TaiKhoan(string tenTK, string matKhau)
		{
			this.TenTaiKhoan = tenTK;
			this.MatKhau = matKhau;
		}

		QLTaiKhoan tk = new QLTaiKhoan();
		public DataTable DangNhap(String TK, String MK)
		{
			return tk.DangNhap(TK, MK);
		}

	}
}
