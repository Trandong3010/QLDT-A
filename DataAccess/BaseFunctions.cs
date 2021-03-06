using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

using System.Reflection;

namespace DataAccess
{
    public class BaseFunctions<T> where T : class, new()
    {
        private string GetTypeT()
        {
            return typeof(T).Name;
        }

        /// <summary>
        /// H�m l?y danh s�ch c�c gi� tr? c�c thu?c t�nh c?a m?t ??i t??ng
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private List<object> GetInsertUpdateValues(T item)
        {
            //L�y danh s�ch c�c thu?c t�nh c?a m?t ?t
            object[] props = item.GetType().GetProperties();

            //Danh s�ch gi� tr? c�c thu?c t�nh
            List<object> objvalue = new List<object>();

            //Duy?t danh s�ch c�c thu?c t�nh
            foreach (PropertyInfo prop in props)
            {
                //L?y gi� tr? c?a m?t thu?c t�nh v� add v� danh s�ch gi� tr? c�c thu?c t�nh
                objvalue.Add(prop.GetValue(item, null));
            }

            return objvalue;
        }

        public List<T> SelectAll()
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_GetAll"));
        }

        public List<T> SelectPage(object From, object To)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_SelectPage", From, To));
        }

		public int Insert(T obj, String output)
        {
            object rs = DataProvider.Instance.ExecuteNonQueryWithOutput(output, this.GetTypeT() + "_Insert", this.GetInsertUpdateValues(obj).ToArray());
            int identity = rs != null ? Convert.ToInt32(rs) : 0;
            return identity;     
        }

		public int Add(T obj)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Insert", this.GetInsertUpdateValues(obj).ToArray());
        }

        public int Update(T obj)
        {

            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Update", this.GetInsertUpdateValues(obj).ToArray());
        }

        public int Delete(object ID)
        {

            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_Delete", ID);
        }

        public List<T> SelectByMA(object Colum, object ID)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("SelectByMa", this.GetTypeT(), Colum, ID));
        }

        public List<T> SelectByID(object Colum,object ID)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader("Find", this.GetTypeT(),Colum, ID));
        }

        public List<T> FindKeyWord(object item)
        {
            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(this.GetTypeT() + "_FindKeyWord", item));
        }

        public DataTable SelectTables(string SPName, params object[] parameterValues)
        {
            return null;
        }
		//------------------------------ Ri�ng ----------------------------//
		public DataTable PhanQuyen_Get()
		{
			QLPhanQuyen qlpq = new QLPhanQuyen();
			return qlpq.PhanQuyenChucNang_Get();
		}
		public DataTable LayMatKhau()
		{
			KetNois a = new KetNois();
			return a.LayDuLieu("layThongTinMatKhau_GetAll");
		}

		public DataTable XoaTaiKhoan()
		{
			KetNois a = new KetNois();
			return a.LayDuLieu("TaiKhoan_Delete");
		}

		public DataTable ChucNang()
		{
			KetNois a = new KetNois();
			return a.LayDuLieu("TaiKhoan_GetAll");
		}

		public DataTable ThongTinMuaHang()
        {
            KetNois a = new KetNois();
            return a.LayDuLieu("ThongTinMuaHang");
        }
        public DataTable ThongTinHangHoaHoaDon()
        {
            KetNois a = new KetNois();
            return a.LayDuLieu("LayHH_HoaDon");
        }

		public DataTable XemSanPham()
		{
			KetNois a = new KetNois();
			return a.LayDuLieu("HienThiSanPham_GetAll");
		}
        public int CapNhatSoLuongHH(object s,object a)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_SoLuong", s,a);
        }
        public int CapNhatThemSoLuong(object s, object a)
        {
            return DataProvider.Instance.ExecuteNonQuery(this.GetTypeT() + "_ThemSoLuong", s, a);
        }
        public DataTable ListToDataTable(List<T> data)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
