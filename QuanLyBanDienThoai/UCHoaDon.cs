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
		//BaseFunctions<HoaDon> hd = new BaseFunctions<HoaDon>();
		//private void LayDuLieuHangHoaFormHoaDon()
		//{
		//	this.dataGridViewThongTinMatHangHD.DataSource = hd.ThongTinHangHoaHoaDon();
		//}


		//private void LoadDataHoaDon()
		//{
		//	LayDuLieuHangHoaFormHoaDon();
		//}

		private void UCHoaDon_Load(object sender, EventArgs e)
		{
			//LoadDataHoaDon();
		}
	}
}
