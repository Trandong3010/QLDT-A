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
	public partial class UCQLThongTinNhanVien : UserControl
	{
		public UCQLThongTinNhanVien()
		{
            InitializeComponent();
        }
		BaseFunctions<NhanVien> nv = new BaseFunctions<NhanVien>();
        //Load
        private void UCQLThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }
        private void LoadDataNhanVien()
        {
            this.dataGridViewNhanVien.DataSource = nv.SelectAll();
        }
        private void buttonHinhNV_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pictureBoxHinhNV.ImageLocation = openFileDialog1.FileName;
                textBoxHinhNV.Text = openFileDialog1.FileName;
            }
        }
        //Them,xoa,sua
        private NhanVien LayThongTinNhanVien()
        {
            int id = maskedTextBoxMaNV.Text.Length == 0 ? 0 : int.Parse(maskedTextBoxMaNV.Text);
            bool gt = false;
            if (radioButtonNam.Checked == true)
                gt = true;
            string tinhtrang = "Đang đi làm";
            if (radioButtonNghiluon.Checked == true)
                tinhtrang = "Nghỉ luôn";
            if (radioButtonNghiphep.Checked == true)
                tinhtrang = "Nghỉ phép";
            NhanVien p = new NhanVien(id, textBoxTenNV.Text, gt, dateTimePickerNgaySinhNV.Value, maskedTextBoxSDTNhanVien.Text, textBoxDiaChiNV.Text, textBoxMailNV.Text, textBoxCMNDNV.Text, textBoxHinhNV.Text, tinhtrang, textBoxTaiKhoan.Text);
            return p;
        }
        private void buttonThemNV_Click(object sender, EventArgs e)
        {
                if (maskedTextBoxMaNV.Text == "")
                {
                    if (nv.Add(LayThongTinNhanVien()) > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadDataNhanVien();
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else
                    MessageBox.Show("Thêm không thành công");
           
        }
        private void buttonSuaNV_Click(object sender, EventArgs e)
        {
            if (nv.Update(LayThongTinNhanVien()) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadDataNhanVien();
            }
            else
                MessageBox.Show("Cập nhật không thành công");
        }
        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxMaNV.Text.Length > 0 && nv.Delete(int.Parse(maskedTextBoxMaNV.Text)) > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadDataNhanVien();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }
        //Tim
        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (radioButtonMaNV.Checked == true)
                TimNhanVienTheoMa();
            else if (radioButtonTenNV.Checked == true)
                TimNhanVienTheoTen();
        }
        private void TimNhanVienTheoMa()
        {
            if (this.textBoxTim.Text.Length > 0)
            {
                List<NhanVien> Tim = new List<NhanVien>();
                int n;
                if (int.TryParse(this.textBoxTim.Text, out n))
                    Tim = nv.SelectByID("MaNV", n);
                this.dataGridViewNhanVien.DataSource = Tim;
            }
        }
        private void TimNhanVienTheoTen()
        {
            if (this.textBoxTim.Text.Length > 0)
            {
                List<NhanVien> Tim = new List<NhanVien>();
                Tim = nv.SelectByID("TenNV", textBoxTim.Text);
                this.dataGridViewNhanVien.DataSource = Tim;
            }
        }
        //Event khac
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            maskedTextBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            radioButtonNam.Checked = true;
            dateTimePickerNgaySinhNV.Value = DateTime.Now;
            maskedTextBoxSDTNhanVien.Text = "";
            textBoxDiaChiNV.Text = "";
            textBoxMailNV.Text = "";
            textBoxCMNDNV.Text = "";
            textBoxHinhNV.Text = "";
            radioButtonDangdilam.Checked = true;
            textBoxTaiKhoan.Text = "";
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }
        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                maskedTextBoxMaNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                if(dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString()=="True")
                    radioButtonNam.Checked = true;
                else
                radioButtonNu.Checked = true;
                dateTimePickerNgaySinhNV.Value = DateTime.Parse(dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                maskedTextBoxSDTNhanVien.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxDiaChiNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxMailNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxCMNDNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBoxHinhNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                pictureBoxHinhNV.ImageLocation =dataGridViewNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Đang đi làm")
                    radioButtonDangdilam.Checked = true;
                else if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Nghỉ phép")
                    radioButtonNghiphep.Checked = true;
                else
                    radioButtonNghiluon.Checked = true;
                textBoxTaiKhoan.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }
    }
}
