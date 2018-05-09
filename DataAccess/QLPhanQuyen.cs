using System.Data;

namespace DataAccess
{
	public class QLPhanQuyen
	{
		KetNois qltk = new KetNois();
		public DataTable PhanQuyenChucNang_Get()
		{
			return qltk.LayDuLieu("Quyen_GetAll");
		}

		//TaiKhoanUser
		public DataTable TenTaiKhoan()
		{
            return qltk.LayDuLieu("TaiKhoanUser");
		}
	}
}
