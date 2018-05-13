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
	public partial class UCHangHoa : UserControl
    {
        FormTinhNang fm = new FormTinhNang();
        public UCHangHoa()
		{
			InitializeComponent();
		}

        BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();
        BaseFunctions<Loai> loai = new BaseFunctions<Loai>();
        string tinhnang="";
        //Hien thi,them loai
        private void HienThiTenLoai()
        {
            DataTable dt = loai.ListToDataTable(loai.SelectAll());
            comboBoxTenLoai.DataSource = dt;
            comboBoxTenLoai.DisplayMember = "TenLoai";
            comboBoxTenLoai.ValueMember = "MaLoai";
        }
        private void buttonThemLoai_Click(object sender, EventArgs e)
        {
            foreach (var item in loai.SelectAll())
                if (item.TenLoai == comboBoxTenLoai.Text)
                {
                    MessageBox.Show("Đã tồn tại");
                    return;
                }
            if (comboBoxTenLoai.Text.Length > 0)
            {
                Loai p = new Loai(0, comboBoxTenLoai.Text);
                int a = loai.Insert(p, "@MaLoai");
                comboBoxTenLoai.SelectedValue = a;
            }
            else
                MessageBox.Show("Tên loại trống");

        }
        //Load
        private void LoadDataHangHoa()
        {
            this.dataGridViewHangHoa.DataSource = hh.SelectAll();
            HienThiTenLoai();
        }
        private void UCHangHoa_Load(object sender, EventArgs e)
        {
            LoadDataHangHoa();
        }
        private void buttonTinhNang_Click(object sender, EventArgs e)
        {
            fm.ShowDialog();
            tinhnang = fm.All;
            labelTinhNang.Text = "Đã thêm tính năng";
        }
        private void buttonMoHinh_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK== openFileDialog1.ShowDialog())
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                textBoxHinhHH.Text = openFileDialog1.FileName;
            }
        }
        private void buttonLamMoiHangHoa_Click(object sender, EventArgs e)
        {
            maskedTextBoxMaHH.Text = "";
            textBoxTenHH.Text = "";
            textBoxSoLuongHH.Text = "";
            textBoxNCCHH.Text = "";
            comboBoxTenLoai.Text = "";
            textBoxDonViTinhHH.Text = "";
            textBoxHinhHH.Text = "";
            pictureBox1.ImageLocation = "";
            labelTinhNang.Text = "Chưa nhập tính năng";
            fm.Reset();
        }
        private void dataGridViewHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maskedTextBoxMaHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxTenHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxSoLuongHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxNCCHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxTenLoai.SelectedValue = dataGridViewHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxDonViTinhHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxHinhHH.Text = dataGridViewHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
                pictureBox1.ImageLocation= dataGridViewHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
                pictureBox1.ImageLocation = dataGridViewHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
                fm.DuaDuLieuLenForm(dataGridViewHangHoa.Rows[e.RowIndex].Cells[7].Value.ToString());
                labelTinhNang.Text = "Đã thêm tính năng";
            }
        }
        //Them, xoa, sua hang hoa
        private HangHoa Thongtinhanghoa()
        {
            try
            {
                int id = this.maskedTextBoxMaHH.Text.Length == 0 ? 0 : int.Parse(this.maskedTextBoxMaHH.Text);
                HangHoa p = new HangHoa(id, this.textBoxTenHH.Text, int.Parse(this.textBoxSoLuongHH.Text), this.textBoxNCCHH.Text, int.Parse(this.comboBoxTenLoai.SelectedValue.ToString()), this.textBoxDonViTinhHH.Text, this.textBoxHinhHH.Text, tinhnang);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void buttonThemHH_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (labelTinhNang.Text == "Chưa nhập tính năng")
                    MessageBox.Show("Chưa nhập tính năng");
                else
                {
                    if (maskedTextBoxMaHH.Text == "")
                    {
                        if (hh.Add(Thongtinhanghoa()) > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadDataHangHoa();
                        }
                        else
                            MessageBox.Show("Thêm không thành công");
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        private void buttonSuaHH_Click_1(object sender, EventArgs e)
        {
            if (hh.Update(Thongtinhanghoa()) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadDataHangHoa();
            }
            else
                MessageBox.Show("Cập nhật không thành công");
        }
        private void buttonXoaHH_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBoxMaHH.Text.Length > 0 && hh.Delete(int.Parse(maskedTextBoxMaHH.Text)) > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadDataHangHoa();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }
       //Tim kiem
        private void buttonTimHH_Click_1(object sender, EventArgs e)
        {
            if (radioButtonMaHH.Checked == true)
                TimHangHoaTheoMa();
            else if (radioButtonTenHH.Checked == true)
                TimHangHoaTheoTen();
        }
        private void TimHangHoaTheoMa()
        {
            if (this.textBoxTimHH.Text.Length > 0)
            {
                List<HangHoa> HHTim = new List<HangHoa>();
                int n;
                if (int.TryParse(this.textBoxTimHH.Text, out n))
                    HHTim = hh.SelectByID("MaHH", n);
                this.dataGridViewHangHoa.DataSource = HHTim;
            }
        }
        private void TimHangHoaTheoTen()
        {
            if (this.textBoxTimHH.Text.Length > 0)
            {
                List<HangHoa> HHTim = new List<HangHoa>();
                HHTim = hh.SelectByID("TenHH", textBoxTimHH.Text);
                this.dataGridViewHangHoa.DataSource = HHTim;
            }
        }

    }
}
