using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDienThoai
{
	public partial class FormTinhNang : Form
	{
		public FormTinhNang()
		{
            All = "";
			InitializeComponent();
		}
        public string All { get; set; }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            All = textBoxManHinh.Text + "," + textBoxHeDieuHanh.Text+"," + textBoxCPU.Text + "," + textBoxRAM.Text + "," + textBoxBoNhoTrong.Text + "," + textBoxDungLuongPin.Text;
            MessageBox.Show("Đã thêm");
            Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxManHinh.Text = "";
            textBoxHeDieuHanh.Text = "";
            textBoxCPU.Text = "";
            textBoxRAM.Text = "";
            textBoxBoNhoTrong.Text = "";
            textBoxDungLuongPin.Text = "";
        }
        public void DuaDuLieuLenForm(string a)
        {
            if (a.Length > 0)
            {
                string[] s = a.Split(',');
                textBoxManHinh.Text = s[0];
                textBoxHeDieuHanh.Text = s[1];
                textBoxCPU.Text = s[2];
                textBoxRAM.Text = s[3];
                textBoxBoNhoTrong.Text = s[4];
                textBoxDungLuongPin.Text = s[5];
            }
            else
                Reset();
        }
    }
}
