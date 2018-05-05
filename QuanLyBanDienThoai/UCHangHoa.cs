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
		public UCHangHoa()
		{
			InitializeComponent();
		}

		//BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();

		//private void LoadDataHangHoa()
		//{
		//	this.dataGridViewHangHoa.DataSource = hh.SelectAll();
		//}

		//private HangHoa Thongtinhanghoa()
		//{
		//	int id = (this.maskedTextBoxMaHH.Text.Length == 0) ? 0 : int.Parse(this.maskedTextBoxMaHH.Text);
		//	HangHoa p = new HangHoa(id, this.textBoxTenHH.Text, int.Parse(this.textBoxSoLuongHH.Text), this.textBoxNCCHH.Text, int.Parse(this.maskedTextBoxMaLoai.Text), this.textBoxDonViTinhHH.Text, this.textBoxHinhHH.Text, this.comboBoxTinhNang.Text);
		//	return p;
		//}

		//private void buttonThemHH_Click(object sender, EventArgs e)
		//{
		//	if (hh.Add(Thongtinhanghoa()) > 0)
		//	{
		//		MessageBox.Show("Add sucessful");
		//		LoadDataHangHoa();
		//	}
		//	else
		//		MessageBox.Show("Add unsucessful");
		//}

		//private void buttonXoaHH_Click(object sender, EventArgs e)
		//{
		//	if (maskedTextBoxMaHH.Text.Length > 0 && hh.Delete(int.Parse(maskedTextBoxMaHH.Text)) > 0)
		//	{
		//		MessageBox.Show("Delete sucessful");
		//		LoadDataHangHoa();
		//	}
		//	else
		//		MessageBox.Show("Delete unsucessful ");
		//}

		//private void buttonSuaHH_Click(object sender, EventArgs e)
		//{
		//	if (hh.Update(Thongtinhanghoa()) > 0)
		//	{
		//		MessageBox.Show("Update sucessful");
		//		LoadDataHangHoa();
		//	}
		//	MessageBox.Show("Update unsucessful");
		//}

		//private void TimHangHoaTheoMa()
		//{
		//	if (this.textBoxTimHH.Text.Length > 0)
		//	{
		//		List<HangHoa> HHTim = new List<HangHoa>();
		//		int n;
		//		if (int.TryParse(this.textBoxTimHH.Text, out n))
		//			HHTim = hh.SelectByID("MaHH", n);
		//		this.dataGridViewHangHoa.DataSource = HHTim;
		//	}
		//}

		//private void TimHangHoaTheoTen()
		//{
		//	if (this.textBoxTimHH.Text.Length > 0)
		//	{
		//		List<HangHoa> HHTim = new List<HangHoa>();
		//		HHTim = hh.SelectByID("TenHH", this.buttonTimHH.Text);
		//		this.dataGridViewHangHoa.DataSource = HHTim;
		//	}
		//}

		//private void buttonTimHH_Click(object sender, EventArgs e)
		//{
		//	if (radioButtonMaHH.Checked == true)
		//		TimHangHoaTheoMa();
		//	else if (radioButtonTenHH.Checked == true)
		//		TimHangHoaTheoTen();
		//}

		//private void LayDuLieuHangHoaLen()
		//{
		//	if (dataGridViewHangHoa.SelectedRows.Count > 0)
		//	{
		//		this.maskedTextBoxMaHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[0].Value.ToString();
		//		this.textBoxTenHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[1].Value.ToString();
		//		this.textBoxSoLuongHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[2].Value.ToString();
		//		this.textBoxNCCHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[3].Value.ToString();
		//		this.maskedTextBoxMaLoai.Text = dataGridViewHangHoa.SelectedRows[0].Cells[4].Value.ToString();
		//		this.textBoxDonViTinhHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[5].Value.ToString();
		//		this.textBoxHinhHH.Text = dataGridViewHangHoa.SelectedRows[0].Cells[6].Value.ToString();
		//		this.comboBoxTinhNang.Text = dataGridViewHangHoa.SelectedRows[0].Cells[7].Value.ToString();
		//	}
		//}

		//private void dataGridViewHangHoa_SelectionChanged(object sender, EventArgs e)
		//{
		//	LayDuLieuHangHoaLen();
		//}

		private void UCHangHoa_Load(object sender, EventArgs e)
		{
			//LoadDataHangHoa();
		}
	}
}
