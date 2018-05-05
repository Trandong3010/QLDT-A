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
		///BaseFunctions<NhanVien> nv = new BaseFunctions<NhanVien>();

		private void UCQLThongTinNhanVien_Load(object sender, EventArgs e)
		{
			//LoadDataNhanVien();
		}
		//private void LoadDataNhanVien()
		//{
		//	this.dataGridViewNhanVien.DataSource = nv.SelectAll();
		//}
	}
}
