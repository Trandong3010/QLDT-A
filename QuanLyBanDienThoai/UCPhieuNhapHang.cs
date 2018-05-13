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
    public partial class UCPhieuNhapHang : UserControl
    {

        BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();
        BaseFunctions<NhapHang> nh = new BaseFunctions<NhapHang>();
        BaseFunctions<BangGia> bg = new BaseFunctions<BangGia>();
        BaseFunctions<NhanVien> nv = new BaseFunctions<NhanVien>();
        BaseFunctions<ChiTietNhapHang> ctnh = new BaseFunctions<ChiTietNhapHang>();

        public UCPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void UCPhieuNhapHang_Load(object sender, EventArgs e)
        {
            LayDuLieuHangHoaForm();
            HienThiTenNV();
        }
        private void LayDuLieuHangHoaForm()
        {
            this.dataGridViewThongTinHangHoaNhap.DataSource = hh.ThongTinHangHoaHoaDon();
        }
        private void HienThiTenNV()
        {
            DataTable dt = nv.ListToDataTable(nv.SelectAll());
            comboBoxTenNhanVien.DataSource = dt;
            comboBoxTenNhanVien.DisplayMember = "TenNV";
            comboBoxTenNhanVien.ValueMember = "MaNV";
        }

        private void dataGridViewThongTinHangHoaNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewThongTinHangHoaNhap.Rows.Count - 1)
            {
                string s = dataGridViewThongTinHangHoaNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<HangHoa> a = hh.SelectByMA("MaHH", s);
                if (a != null)
                {
                    maskedTextBoxMaHangNhap.Text = a[0].MaHH.ToString();
                    textBoxTenHangNhap.Text = a[0].TenHH;
                    textBoxGiaNhap.Text = "-1";
                }
            }
        }

        private void buttonTangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxGiaNhap.Text == "-1")
                MessageBox.Show("Không có giá nhập hiện tại");
            else if (KiemTraTang(maskedTextBoxMaHangNhap.Text) == 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell;
                cell = new DataGridViewTextBoxCell();
                cell.Value = maskedTextBoxMaHangNhap.Text;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = numericUpDownTangNhap.Value;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = textBoxGiaNhap.Text;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = int.Parse(textBoxGiaNhap.Text) * numericUpDownTangNhap.Value;
                row.Cells.Add(cell);
                dataGridViewThongTinHoaDonNhapHang.Rows.Add(row);

            }
            CapNhatTongTien();
            CapNhatTongSanPham();
        }
        private int KiemTraTang(string Ma)
        {
            for (int i = 0; i < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value != null)
                    if (Ma.CompareTo(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value.ToString()) == 0)
                    {
                        dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value = int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()) + numericUpDownTangNhap.Value;
                        dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value = int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()) * int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[2].Value.ToString());
                        return 1;
                    }
            }
            return 0;
        }
        private void buttonTaoPhieuMoi_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxMaPhieuNhap.Text.Length > 0)
                MessageBox.Show("Đã tạo phiếu nhập");
            else
            {
                int a;
                if ((a = nh.Insert(LayDuLieuPhieuNhap(), "@MaPhieuNhap")) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    maskedTextBoxMaPhieuNhap.Text = a.ToString();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }

        }
        private NhapHang LayDuLieuPhieuNhap()
        {
            int id = maskedTextBoxMaPhieuNhap.Text.Length == 0 ? 0 : int.Parse(maskedTextBoxMaPhieuNhap.Text.ToString());
            NhapHang p = new NhapHang(id, int.Parse(comboBoxTenNhanVien.SelectedValue.ToString()),dateTimePickerNgayNhapHang.Value,textBoxNhaCungCap.Text,textBoxSDTNhaCungCap.Text,textBoxDiaChiNhaCungCap.Text);
            return p;

        }
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            maskedTextBoxMaPhieuNhap.Text = "";
            comboBoxTenNhanVien.SelectedValue = 1;
            dateTimePickerNgayNhapHang.Value = DateTime.Now;
            textBoxNhaCungCap.Text = "";
            textBoxSDTNhaCungCap.Text = "";
            textBoxDiaChiNhaCungCap.Text = "";
        }

        private void buttonGiamNhap_Click(object sender, EventArgs e)
        {
            KiemTraGiam(maskedTextBoxMaHangNhap.Text);
            CapNhatTongTien();
            CapNhatTongSanPham();
        }
        private int KiemTraGiam(string Ma)
        {
            for (int i = 0; i < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value != null)
                    if (Ma.CompareTo(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value.ToString()) == 0)
                    {
                        if (int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()) <= numericUpDownGiamNhap.Value)
                            dataGridViewThongTinHoaDonNhapHang.Rows.Remove(dataGridViewThongTinHoaDonNhapHang.Rows[i]);
                        else
                        {
                            dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value = int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()) - numericUpDownGiamNhap.Value;
                            dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value = int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()) * int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[2].Value.ToString());
                        }
                        return 1;
                    }
            }
            return 0;
        }

        private void dataGridViewThongTinHoaDonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1)
            {
                string s = dataGridViewThongTinHoaDonNhapHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                List<HangHoa> a = hh.SelectByMA("MaHH", s);
                if (a != null)
                {
                    maskedTextBoxMaHangNhap.Text = a[0].MaHH.ToString();
                    textBoxTenHangNhap.Text = a[0].TenHH;
                    textBoxGiaNhap.Text = dataGridViewThongTinHoaDonNhapHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
        }

        private void CapNhatTongTien()
        {
            int tong = 0;
            for (int i = 0; i < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value != null && dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value.ToString().Length > 0)
                    tong += int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value.ToString());
            }
            textBoxTongTienNhapHang.Text = tong.ToString();
        }
        private void CapNhatTongSanPham()
        {
            int tong = 0;
            for (int i = 0; i < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1; i++)
            {
                if (dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value != null && dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString().Length > 0)
                    tong += int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString());
            }
            textBoxTongSanPhamNhap.Text = tong.ToString();
        }

        private void buttonThanhToanNhapHang_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxMaPhieuNhap.Text.Length == 0)
                MessageBox.Show("Chưa tạo phiếu nhập");
            else
                for (int i = 0; i < dataGridViewThongTinHoaDonNhapHang.Rows.Count - 1; i++)
                {
                    ChiTietNhapHang a = new ChiTietNhapHang(int.Parse(maskedTextBoxMaPhieuNhap.Text), int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()), int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[2].Value.ToString()), int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[3].Value.ToString()));
                    ctnh.Add(a);
                    hh.CapNhatThemSoLuong(int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridViewThongTinHoaDonNhapHang.Rows[i].Cells[1].Value.ToString()));
                }
        }
    }
}
