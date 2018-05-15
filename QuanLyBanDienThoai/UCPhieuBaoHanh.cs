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
    public partial class UCPhieuBaoHanh : UserControl
    {

        BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();
        BaseFunctions<BaoHanh> bh = new BaseFunctions<BaoHanh>();
        BaseFunctions<Khachhang> kh = new BaseFunctions<Khachhang>();

        public UCPhieuBaoHanh()
        {
            InitializeComponent();
        }
        private void UCPhieuBaoHanh_Load(object sender, EventArgs e)
        {
            HienThiTenHH();
            HienThiTenKH();
        }
        private void HienThiTenHH()
        {
            DataTable dt = hh.ListToDataTable(hh.SelectAll());
            comboBoxTenHang.DataSource = dt;
            comboBoxTenHang.DisplayMember = "TenHH";
            comboBoxTenHang.ValueMember = "MaHH";
        }
        private void HienThiTenKH()
        {
            DataTable dt = kh.ListToDataTable(kh.SelectAll());
            comboBoxTenKhachHang.DataSource = dt;
            comboBoxTenKhachHang.DisplayMember = "TenKH";
            comboBoxTenKhachHang.ValueMember = "MaKH";
        }
        private void buttonInBaoHanh_Click(object sender, EventArgs e)
        {
            if (bh.Add(LayThongTinBaoHanh()) > 0)
                MessageBox.Show("Thêm thành công"); //Mở bản in

        }
        private BaoHanh LayThongTinBaoHanh()
        {

            int id = 0;
            BaoHanh p = new BaoHanh(id, int.Parse(comboBoxTenHang.ValueMember), textBoxSoEmei.Text, int.Parse(comboBoxTenKhachHang.ValueMember), dateTimePickerNgayMuaBH.Value, textBoxThoiGianBaoHanh.Text);
            return p;
        }
        
        
    }
}