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
	public partial class UCBangGia : UserControl
	{
		public UCBangGia()
		{
			InitializeComponent();
		}

        BaseFunctions<BangGia> bg = new BaseFunctions<BangGia>();
        BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();
        private void UCBangGia_Load(object sender, EventArgs e)
        {
            LoadDataBangGia();
            HienThiTenHH();
        }
        //load
        private void LoadDataBangGia()
        {
            this.dataGridViewThongTinBangGia.DataSource = bg.SelectAll();
        }
        private void HienThiTenHH()
        {
            DataTable dt = hh.ListToDataTable(hh.SelectAll());
            comboBoxTenHang.DataSource = dt;
            comboBoxTenHang.DisplayMember = "TenHH";
            comboBoxTenHang.ValueMember = "MaHH";
        }
        //them,xoa,sua
        private BangGia GetInformation()
        {
            int id = (this.maskedTextBoxSoBG.Text.Length == 0) ? 0 : int.Parse(this.maskedTextBoxSoBG.Text);
            BangGia p = new BangGia(id, int.Parse(comboBoxTenHang.SelectedValue.ToString()), int.Parse(textBoxGiaBan.Text), dateTimePickerNgayApDung.Value,dateTimePickerNgayKetThuc.Value,int.Parse(textBoxGiamGia.Text));
            return p;
        }
        private void buttonThembg_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxSoBG.Text.Length == 0)
            {
                if (bg.Add(GetInformation()) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataBangGia();
                    ResetBangGia();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Thêm không thành công");
        }
        private void buttonXoabg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxSoBG.Text.Length > 0 && bg.Delete(int.Parse(this.maskedTextBoxSoBG.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDataBangGia();
                    ResetBangGia();
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void buttonSuabg_Click(object sender, EventArgs e)
        {
            if (bg.Update(GetInformation()) > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDataBangGia();
                ResetBangGia();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }
        private void ResetBangGia()
        {
            this.maskedTextBoxSoBG.Text = "";
            this.comboBoxTenHang.Text = "";
            this.textBoxGiaBan.Text = "";
            this.textBoxGiamGia.Text = "";
            dateTimePickerNgayApDung.Value = DateTime.Now;
            dateTimePickerNgayKetThuc.Value = DateTime.Now;
        }
        //Tim
        private void TimBangGiaTheoMa()
        {
            if (this.textBoxTimBG.Text.Length > 0)
            {
                List<BangGia> bgTim = new List<BangGia>();
                int n;
                if (int.TryParse(this.textBoxTimBG.Text, out n))
                    bgTim = bg.SelectByID("SoBangGia", n);
                this.dataGridViewThongTinBangGia.DataSource = bgTim;
            }
        }
        private void TimBangGiaTheoMaHH()
        {
            if (this.textBoxTimBG.Text.Length > 0)
            {
                List<BangGia> bgTim = new List<BangGia>();
                bgTim = bg.SelectByID("MaHH", this.textBoxTimBG.Text);
                this.dataGridViewThongTinBangGia.DataSource = bgTim;
            }
        }
        private void buttonTimbg_Click(object sender, EventArgs e)
        {
            if (this.radioButtonSoBangGia.Checked == true)
                TimBangGiaTheoMa();
            else if (this.radioButtonMaHangHoa.Checked == true)
                TimBangGiaTheoMaHH();
        }

        //event khac
        private void dataGridViewBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.maskedTextBoxSoBG.Text = this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.comboBoxTenHang.SelectedValue = this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.textBoxGiaBan.Text = this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePickerNgayApDung.Value = DateTime.Parse( this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateTimePickerNgayKetThuc.Value = DateTime.Parse(this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.textBoxGiamGia.Text = this.dataGridViewThongTinBangGia.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ResetBangGia();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDataBangGia();
        }
    }
}
