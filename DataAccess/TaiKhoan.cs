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
		public bool Phanquyen { get; set; }
		public bool MK { get; set; }
		public bool Nguoidung { get; set; }
		public bool Dangxuat { get; set; }
		public bool Hoadon { get; set; }
		public bool Xemsanpham { get; set; }
		public bool Baohanh { get; set; }
		public bool Nhaphang { get; set; }
		public bool Trahang { get; set; }
		public bool Khachhang { get; set; }
		public bool Mathang { get; set; }
		public bool Thongtinnhanvien { get; set; }
		public bool Banggia { get; set; }
		public bool Thongkedoanhthu { get; set; }
		public bool Thongkekhachhang { get; set; }
		public bool Thongkemathang { get; set; }

		public TaiKhoan()
		{ }
		public TaiKhoan(string tenTK, string matKhau, string chucNang)
		{
			this.TenTaiKhoan = tenTK;
			this.MatKhau = matKhau;
			this.ChucNang = chucNang;
		}

		public TaiKhoan(string tenTK, string matKhau)
		{
			this.TenTaiKhoan = tenTK;
			this.MatKhau = matKhau;
		}
		public TaiKhoan(string tenTaiKhoan, string matKhau, string chucNang, bool phanquyen, bool mK, bool nguoidung, bool dangxuat, bool hoadon, bool xemsanpham, bool baohanh, bool nhaphang, bool trahang, bool khachhang, bool mathang, bool thongtinnhanvien, bool banggia, bool thongkedoanhthu, bool thongkekhachhang, bool thongkemathang)
		{
			this.TenTaiKhoan = tenTaiKhoan;
			this.MatKhau = matKhau;
			this.ChucNang = chucNang;
			this.Phanquyen = phanquyen;
			this.MK = mK;
			this.Nguoidung = nguoidung;
			this.Dangxuat = dangxuat;
			this.Hoadon = hoadon;
			this.Xemsanpham = xemsanpham;
			this.Baohanh = baohanh;
			this.Nhaphang = nhaphang;
			this.Trahang = trahang;
			this.Khachhang = khachhang;
			this.Mathang = mathang;
			this.Thongtinnhanvien = thongtinnhanvien;
			this.Banggia = banggia;
			this.Thongkedoanhthu = thongkedoanhthu;
			this.Thongkekhachhang = Thongkekhachhang;
			this.Thongkemathang = thongkemathang;
		}


		QLTaiKhoan tk = new QLTaiKhoan();
		//private string text;

		public DataTable DangNhap(String TK, String MK)
		{
			return tk.DangNhap(TK, MK);
		}


	}
}
