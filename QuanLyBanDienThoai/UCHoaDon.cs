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
    public partial class UCHoaDon : UserControl
    {
        public UCHoaDon()
        {
            InitializeComponent();
        }
        BaseFunctions<HoaDon> hd = new BaseFunctions<HoaDon>();
        BaseFunctions<BangGia> bg = new BaseFunctions<BangGia>();
        BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();
        BaseFunctions<NhanVien> nv = new BaseFunctions<NhanVien>();

        private void LayDuLieuHangHoaFormHoaDon()
        {
            this.dataGridViewThongTinMatHangHD.DataSource = hd.ThongTinHangHoaHoaDon();
        }


        private void LoadDataHoaDon()
        {
            LayDuLieuHangHoaFormHoaDon();
        }

        private void UCHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();
            HienThiTenNV();
            HienThiTenHH();
        }

        private void HienThiTenNV()
        {
            DataTable dt = nv.ListToDataTable(nv.SelectAll());
            comboBoxTenNhanVien.DataSource = dt;
            comboBoxTenNhanVien.DisplayMember = "TenNV";
            comboBoxTenNhanVien.ValueMember = "MaNV";
        }
        private void HienThiTenHH()
        {
            DataTable dt = hh.ListToDataTable(hh.SelectAll());
            comboBoxTenHang.DataSource = dt;
            comboBoxTenHang.DisplayMember = "TenHH";
            comboBoxTenHang.ValueMember = "MaHH";
        }
        private int LayGiaBan(string cot, string s)
        {
            List<BangGia> lbg = bg.SelectByID("MaHH", s);
            if (lbg != null)
                for (int i = 0; i < lbg.Count; i++)
                    if (lbg[i].NgayApDung.CompareTo(DateTime.Now) == -1 || lbg[i].NgayApDung.CompareTo(DateTime.Now) == 0)
                        if (lbg[i].NgayKetThuc.CompareTo(DateTime.Now) == 1 || lbg[i].NgayKetThuc.CompareTo(DateTime.Now) == 0)
                            return lbg[i].GiaBan;
            return 0;
        }

        private void numericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
        }

        private void buttonThemHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow(); //Khai bao row
            DataGridViewCell cell;                     //khai bao cells
            cell = new DataGridViewTextBoxCell();      //Khai bao kieu cua cell
            cell.Value = dataGridViewHoaDon.Rows.Count;  // gan gia tri textBox          
            row.Cells.Add(cell);                        // add cell to row
            cell = new DataGridViewTextBoxCell();
            cell.Value = comboBoxTenHang.SelectedValue;
            row.Cells.Add(cell);
            cell = new DataGridViewTextBoxCell();
            cell.Value = comboBoxTenHang.Text;
            row.Cells.Add(cell);
            cell = new DataGridViewTextBoxCell();
            cell.Value = numericUpDownSoLuong.Value;
            row.Cells.Add(cell);
            cell = new DataGridViewTextBoxCell();
            cell.Value = textBoxDonViTinh.Text;
            row.Cells.Add(cell);
            cell = new DataGridViewTextBoxCell();
            cell.Value = textBoxDonGia.Text;
            row.Cells.Add(cell);
            cell = new DataGridViewTextBoxCell();
            cell.Value = textBoxThanhTien.Text;
            row.Cells.Add(cell);
            dataGridViewHoaDon.Rows.Add(row);

        }




      

        private void dataGridViewThongTinMatHangHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewThongTinMatHangHD.Rows.Count - 1)
            {
                string s = dataGridViewThongTinMatHangHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<HangHoa> a = hh.SelectByID("MaHH", s);
                if (a != null)
                {
                    comboBoxTenHang.Text = a[0].TenHH;
                    textBoxDonViTinh.Text = a[0].DonViTinh;
                    textBoxDonGia.Text = LayGiaBan("MaHH", s).ToString();
                    textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
                }
            }
        }


        private void comboBoxTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBoxTenHang.SelectedValue.ToString();
            if (s != "System.Data.DataRowView")
            {
                List<HangHoa> a = hh.SelectByID("MaHH", s);
                if (a != null)
                {
                    textBoxDonViTinh.Text = a[0].DonViTinh;
                    textBoxDonGia.Text = LayGiaBan("MaHH", s).ToString();
                    textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
                }
            }
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&e.RowIndex< dataGridViewHoaDon.Rows.Count-1)
            {
                comboBoxTenHang.Text=dataGridViewHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericUpDownSoLuong.Value =int.Parse(dataGridViewHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString());
                textBoxDonViTinh.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxDonGia.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxThanhTien.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
                
            }
        }

        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {
            textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
        }

        private void buttonSuaHoaDon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[2].Value != null)
                    if (dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString().CompareTo(comboBoxTenHang.Text) == 0)
                    {
                        dataGridViewHoaDon.Rows[i].Cells[2].Value = comboBoxTenHang.Text;
                        dataGridViewHoaDon.Rows[i].Cells[3].Value = numericUpDownSoLuong.Value;
                        dataGridViewHoaDon.Rows[i].Cells[4].Value = textBoxDonViTinh.Text;
                        dataGridViewHoaDon.Rows[i].Cells[5].Value = textBoxDonGia.Text;
                        dataGridViewHoaDon.Rows[i].Cells[6].Value = textBoxThanhTien.Text;
                        break;
                    }
            }
        }

        private void buttonXoaHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[2].Value != null)
                    if (dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString().CompareTo(comboBoxTenHang.Text) == 0)
                        dataGridViewHoaDon.Rows.Remove(dataGridViewHoaDon.Rows[i]);
            }
        }
    }
}