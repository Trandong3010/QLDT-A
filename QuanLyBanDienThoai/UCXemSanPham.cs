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
using System.IO;

namespace QuanLyBanDienThoai
{
	public partial class UCXemSanPham : UserControl
	{
		public UCXemSanPham()
		{
			InitializeComponent();
		}

		BaseFunctions<HangHoa> hh = new BaseFunctions<HangHoa>();

		private void HienThiHinh()
		{
			DataTable table = hh.XemSanPham();
			try
			{
					Byte[] j = (byte[])table.Rows[0][0];
					MemoryStream st = new MemoryStream(j);
				pictureBoxhinh1.Image = Image.FromStream(st);
			}
			catch (Exception)
			{
			}
			
		}
		private void tabControlPanel4_Click(object sender, EventArgs e)
		{

		}

		private void tabControlXemThongTinSanPham_Click(object sender, EventArgs e)
		{

		}


		private void UCXemSanPham_Load(object sender, EventArgs e)
		{
			HienThiHinh();
		}
	}
}
