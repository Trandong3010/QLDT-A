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
        BaseFunctions<Khachhang> kh = new BaseFunctions<Khachhang>();
        BaseFunctions<ChiTietHoaDon> cthd = new BaseFunctions<ChiTietHoaDon>();
        //load
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
            comboBoxTenHang.Text = "";
        }
        private int LayGiaBan(string cot, string s)
        {
            List<BangGia> lbg = bg.SelectByMA("MaHH", s);
            if (lbg != null)
                for (int i = 0; i < lbg.Count; i++)
                    if (lbg[i].NgayApDung.CompareTo(DateTime.Now) == -1 || lbg[i].NgayApDung.CompareTo(DateTime.Now) == 0)
                        if (lbg[i].NgayKetThuc.CompareTo(DateTime.Now) == 1 || lbg[i].NgayKetThuc.CompareTo(DateTime.Now) == 0)
                            return lbg[i].GiaBan;
            return -1;
        }
        private void CapNhatTongTien()
        {
            int tong = 0;
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count - 1; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[5].Value != null && dataGridViewHoaDon.Rows[i].Cells[5].Value.ToString().Length > 0)
                    tong += int.Parse(dataGridViewHoaDon.Rows[i].Cells[5].Value.ToString());
            }
            labelTongTien.Text = tong.ToString();
        }
        //Them,xoa,Sua
        private void buttonThemHang_Click(object sender, EventArgs e)
        {
            if (textBoxDonGia.Text == "-1")
                MessageBox.Show("Không có giá bán hiện tại");
            else if (KiemTra(comboBoxTenHang.SelectedValue.ToString()) == 0 && comboBoxTenHang.Text.Length > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell;
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
            CapNhatTongTien();
        }
        private int KiemTra(string Ma)
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count - 1; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[0].Value != null)
                    if (Ma.CompareTo(dataGridViewHoaDon.Rows[i].Cells[0].Value.ToString()) == 0)
                    {
                        dataGridViewHoaDon.Rows[i].Cells[2].Value = int.Parse(dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString()) + numericUpDownSoLuong.Value;
                        dataGridViewHoaDon.Rows[i].Cells[5].Value = int.Parse(dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridViewHoaDon.Rows[i].Cells[4].Value.ToString());
                        return 1;
                    }
            }
            return 0;
        }
        private void buttonSuaHoaDon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count - 1; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[1].Value != null)
                    if (dataGridViewHoaDon.Rows[i].Cells[1].Value.ToString().CompareTo(comboBoxTenHang.Text) == 0)
                    {
                        dataGridViewHoaDon.Rows[i].Cells[1].Value = comboBoxTenHang.Text;
                        dataGridViewHoaDon.Rows[i].Cells[2].Value = numericUpDownSoLuong.Value;
                        dataGridViewHoaDon.Rows[i].Cells[3].Value = textBoxDonViTinh.Text;
                        dataGridViewHoaDon.Rows[i].Cells[4].Value = textBoxDonGia.Text;
                        dataGridViewHoaDon.Rows[i].Cells[5].Value = textBoxThanhTien.Text;
                        break;
                    }
            }
            CapNhatTongTien();
        }
        private void buttonXoaHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                if (dataGridViewHoaDon.Rows[i].Cells[1].Value != null)
                    if (dataGridViewHoaDon.Rows[i].Cells[1].Value.ToString().CompareTo(comboBoxTenHang.Text) == 0)
                    {
                        dataGridViewHoaDon.Rows.Remove(dataGridViewHoaDon.Rows[i]);
                        break;
                    }
            }
            CapNhatTongTien();
        }
        private HoaDon LayThongTinHoaDon()
        {
            if (comboBoxTenNhanVien.Text != "" && txtIDkh.Text != "")
            {
                int id = (this.maskedTextBoxMaHD.Text.Length == 0) ? 0 : int.Parse(this.maskedTextBoxMaHD.Text);
                HoaDon p = new HoaDon(id, int.Parse(this.comboBoxTenNhanVien.SelectedValue.ToString()), int.Parse(txtIDkh.Text), DateTime.Now.ToString());
                return p;
            }
            return null;
        }
        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                if ((a = kh.Insert(LayThongTinKhach(), "@MaKH")) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    txtIDkh.Text = a.ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception)
            {
                if(txtIDkh.Text.Length > 0)
                    MessageBox.Show("Đã thêm khách hàng trước đó");
                else
                MessageBox.Show("Thêm thất bại");
            }
        }
        private Khachhang LayThongTinKhach()
        {
            if (txtIDkh.Text.Length > 0)
                return null;
            int id = 0;
            Khachhang p = new Khachhang(id, this.textBoxTenKhach.Text, textBoxDiaChiNguoiMua.Text, this.maskedTextBoxSDTNguoiMua.Text, textBoxMail.Text);
            return p;
        }

        //event khac
        private void numericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (textBoxDonGia.Text != "")
                textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
        }
        private void dataGridViewThongTinMatHangHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewThongTinMatHangHD.Rows.Count - 1)
            {
                string s = dataGridViewThongTinMatHangHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<HangHoa> a = hh.SelectByMA("MaHH", s);
                if (a != null)
                {
                    comboBoxTenHang.Text = a[0].TenHH;
                    textBoxDonViTinh.Text = a[0].DonViTinh;
                    textBoxDonGia.Text = LayGiaBan("MaHH", s).ToString();
                    if (textBoxDonGia.Text == "-1")
                        MessageBox.Show("Không có giá bán hiện tại");
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
                    if (textBoxDonGia.Text == "-1")
                        MessageBox.Show("Không có giá bán hiện tại");
                    textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
                }
            }
        }
        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewHoaDon.Rows.Count - 1)
            {
                comboBoxTenHang.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                numericUpDownSoLuong.Value = int.Parse(dataGridViewHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                textBoxDonViTinh.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxDonGia.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxThanhTien.Text = dataGridViewHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }
        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDonGia.Text != "")
                textBoxThanhTien.Text = (int.Parse(textBoxDonGia.Text) * int.Parse(numericUpDownSoLuong.Value.ToString())).ToString();
        }
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxMaHD.Text.Length == 0)
                MessageBox.Show("Chưa tạo hóa đơn", "Thông báo");
            else
                for (int i = 0; i < dataGridViewHoaDon.Rows.Count - 1; i++)
                {
                    ChiTietHoaDon a = new ChiTietHoaDon(int.Parse(maskedTextBoxMaHD.Text),
                        int.Parse(dataGridViewHoaDon.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString()), int.Parse(dataGridViewHoaDon.Rows[i].Cells[4].Value.ToString()));
                    cthd.Add(a);
                    hh.CapNhatSoLuongHH(int.Parse(dataGridViewHoaDon.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridViewHoaDon.Rows[i].Cells[2].Value.ToString()));
                }
        }
        private void buttonLamMoiKH_Click(object sender, EventArgs e)
        {
            txtIDkh.Text = "";
            textBoxTenKhach.Text = "";
            textBoxDiaChiNguoiMua.Text = "";
            maskedTextBoxSDTNguoiMua.Text = "";
            textBoxMail.Text = "";
        }
        private void buttonTaoHoaDonMoi_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                if ((a = hd.Insert(LayThongTinHoaDon(), "@SoHoaDon")) > 0)
                {
                    this.maskedTextBoxMaHD.Text = a.ToString();
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void groupPanelHoaDonBanHang_Click(object sender, EventArgs e)
        {
            comboBoxTenNhanVien.Focus();
        }
    }
}