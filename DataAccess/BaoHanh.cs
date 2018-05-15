using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaoHanh
    {
        public int SoPhieu { get; set; }
        public int MaHH { get; set; }
        public string SoEmei { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayMua { get; set; }
        public string ThoiGianBaoHanh { get; set; }

        public BaoHanh()
        {
        }
        public BaoHanh(int soPhieu, int maHH, string soEmei, int maKH, DateTime ngayMua, string thoiGianBaoHanh)
        {
            this.SoPhieu = soPhieu;
            this.MaHH = maHH;
            this.SoEmei = soEmei;
            this.MaKH = maKH;
            this.NgayMua = ngayMua;
            this.ThoiGianBaoHanh = thoiGianBaoHanh;
        }
    }
}
