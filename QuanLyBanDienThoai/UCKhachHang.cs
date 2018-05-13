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
        BaseFunctions<Khachhang> kh = new BaseFunctions<Khachhang>();
        //load
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }
        private void LoadDataKhachHang()
        {
            this.dataGridViewKhachHang.DataSource = kh.SelectAll();
        }
        //them,xoa,sua
        private Khachhang GetInformation()
        {
            int id = (this.maskedTextBoxMaKH.Text.Length == 0) ? 0 : int.Parse(this.maskedTextBoxMaKH.Text);
            Khachhang p = new Khachhang(id, this.textBoxTenKH.Text, this.textBoxDiaChiKH.Text, this.textBoxMailKH.Text, this.maskedTextBoxSDTKhachhang.Text);
            return p;
        }
        private void buttonThemKH_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxMaKH.Text.Length == 0)
            {
                if ( kh.Add(GetInformation()) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataKhachHang();
                    ResetKhachHang();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Thêm không thành công");
        }
        private void buttonXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxMaKH.Text.Length > 0 && kh.Delete(int.Parse(this.maskedTextBoxMaKH.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDataKhachHang();
                    ResetKhachHang();
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            catch(Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void buttonSuaKH_Click(object sender, EventArgs e)
        {
            if (kh.Update(GetInformation()) > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDataKhachHang();
                ResetKhachHang();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }
        private void ResetKhachHang()
        {
            this.maskedTextBoxMaKH.Text = "";
            this.textBoxTenKH.Text = "";
            this.textBoxDiaChiKH.Text = "";
            this.maskedTextBoxSDTKhachhang.Text = "";
            this.textBoxMailKH.Text = "";
        }
        //Tim
        private void TimKhachHangTheoMa()
        {
            if (this.textBoxTimKH.Text.Length > 0)
            {
                List<Khachhang> KhTim = new List<Khachhang>();
                int n;
                if (int.TryParse(this.textBoxTimKH.Text, out n))
                    KhTim = kh.SelectByID("MaKH", n);
                this.dataGridViewKhachHang.DataSource = KhTim;
            }
        }
        private void TimKhachHangTheoTen()
        {
            if (this.textBoxTimKH.Text.Length > 0)
            {
                List<Khachhang> KhTim = new List<Khachhang>();
                KhTim = kh.SelectByID("TenKH", this.textBoxTimKH.Text);
                this.dataGridViewKhachHang.DataSource = KhTim;
            }
        }
        private void buttonTimKH_Click(object sender, EventArgs e)
        {
            if (this.radioButtonMaKH.Checked == true)
                TimKhachHangTheoMa();
            else if (this.radioButtonTenKH.Checked == true)
                TimKhachHangTheoTen();
        }

        //event khac
        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewKhachHang.Rows.Count)
            {
                this.maskedTextBoxMaKH.Text = this.dataGridViewKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.textBoxTenKH.Text = this.dataGridViewKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.textBoxDiaChiKH.Text = this.dataGridViewKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.maskedTextBoxSDTKhachhang.Text = this.dataGridViewKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.textBoxMailKH.Text = this.dataGridViewKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ResetKhachHang();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }
    } 
}
