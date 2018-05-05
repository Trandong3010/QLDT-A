using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Core;

namespace QuanLyBanDienThoai
{
	public partial class FormQLCHBanDT : DevComponents.DotNetBar.Office2007RibbonForm
	{
		public FormQLCHBanDT()
		{
			InitializeComponent();
		}

		private void ribbonTabItemQuanLy_Click(object sender, EventArgs e)
		{

		}

		private void tabControlMain_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
		{
			if (MessageBox.Show("Bạn chắc chắn muốn tắt?", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				TabItem tabitem = tabControlMain.SelectedTab;
				tabControlMain.Tabs.Remove(tabitem);
			}

		}

		private void buttonItemKhachHang_Click(object sender, EventArgs e)
		{
			TabItem tabitem = tabControlMain.SelectedTab;
			tabControlMain.Tabs.Add(tabitem);
		}
		private void addNewTab(String srtTabName, String Name)
		{
			foreach (TabItem tabPage in tabControlMain.Tabs)
				if (tabPage.Text == srtTabName && tabPage.Name == Name)
				{
					tabControlMain.SelectedTab = tabPage;
					return;
				}
		}

		private void buttonItemPhanQuyen_Click(object sender, EventArgs e)
		{
			PhanQuyen fr = new PhanQuyen();
			fr.ShowDialog();
		}

		private void buttonItemNguoiDung_Click(object sender, EventArgs e)
		{
			NguoiDung fr = new NguoiDung();
			fr.ShowDialog();
		}

		private void buttonItemMatKhau_Click(object sender, EventArgs e)
		{
			ThayDoiMatKhau fr = new ThayDoiMatKhau();
			fr.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FormTinhNang fr = new FormTinhNang();
			fr.ShowDialog();
		}
	}
}
