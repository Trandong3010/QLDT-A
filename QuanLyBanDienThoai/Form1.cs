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
		string TenTaiKhoan = "";
		string MatKhau = "";
		string ChucNang = "";
		string Quyen = "";

		public FormQLCHBanDT()
		{
			InitializeComponent();
		}
		public FormQLCHBanDT(string tenTaiKhoan, string matKhau, string chucNang, string quyen)
		{
			InitializeComponent();
			this.TenTaiKhoan = tenTaiKhoan;
			this.MatKhau = matKhau;
			this.ChucNang = chucNang;
			this.Quyen = quyen;
		}

		private void FormQLCHBanDT_Load(object sender, EventArgs e)
		{
			CapQuyen(ChucNang);
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

		private void tabControlMain_TabItemOpen(object sender, EventArgs e)
		{
			TabItem tabitem = tabControlMain.SelectedTab;
			tabControlMain.Tabs.Add(tabitem);
		}

		private void buttonItemDangXuat_Click(object sender, EventArgs e)
		{
			Disable();
		}

		private void CapQuyen(string a)
		{
			switch (a)
			{
				case "Quản lý":
					Admin();
					break;
				case "Nhân viên":
					NhanVien();
					break;
				case "Thủ kho":
					ThuKho();
					break;

			}
		}

		private void Disable()
		{
			ribbonTabItemHeThong.Enabled = false;
			//----
			buttonItemPhanQuyen.Enabled = false;
			buttonItemMatKhau.Enabled = false;
			buttonItemNguoiDung.Enabled = false;
			buttonItemDangXuat.Enabled = false;
			//-----
			ribbonTabItemNghiepVu.Enabled = false;
			//----
			buttonItemHoaDon.Enabled = false;
			buttonItemXemSanPham.Enabled = false;
			buttonItemNhapHang.Enabled = false;
			buttonItemBaoHanh.Enabled = false;
			buttonItemTraHang.Enabled = false;
			//----
			ribbonTabItemDanhMuc.Enabled = false;
			//----
			buttonItemKhachHang.Enabled = false;
			buttonItemMatHang.Enabled = false;
			buttonItemThongTinNV.Enabled = false;
			buttonItemBangGia.Enabled = false;
			//----
			ribbonTabItemBaoCao.Enabled = false;
			buttonItemThongKeDoanhThu.Enabled = false;
			buttonItemThongKeKhachHang.Enabled = false;
			buttonItemThongKeMatHang.Enabled = false;
		}
		public void NhanVien()
		{
			ribbonTabItemHeThong.Enabled = true;
			//----
			buttonItemPhanQuyen.Enabled = false;
			buttonItemMatKhau.Enabled = false;
			buttonItemNguoiDung.Enabled = false;
			buttonItemDangXuat.Enabled = true;
			//-----
			ribbonTabItemNghiepVu.Enabled = true;
			//----
			buttonItemHoaDon.Enabled = true;
			buttonItemXemSanPham.Enabled = true;
			buttonItemNhapHang.Enabled = false;
			buttonItemBaoHanh.Enabled = true;
			buttonItemTraHang.Enabled = false;
			//----
			ribbonTabItemDanhMuc.Enabled = false;
			//----
			buttonItemKhachHang.Enabled = false;
			buttonItemMatHang.Enabled = false;
			buttonItemThongTinNV.Enabled = false;
			buttonItemBangGia.Enabled = false;
			//----
			ribbonTabItemBaoCao.Enabled = false;
			buttonItemThongKeDoanhThu.Enabled = false;
			buttonItemThongKeKhachHang.Enabled = false;
			buttonItemThongKeMatHang.Enabled = false;
		}

		public void ThuKho()
		{
			ribbonTabItemHeThong.Enabled = true;
			//----
			buttonItemPhanQuyen.Enabled = false;
			buttonItemMatKhau.Enabled = false;
			buttonItemNguoiDung.Enabled = false;
			buttonItemDangXuat.Enabled = true;
			//-----
			ribbonTabItemNghiepVu.Enabled = true;
			//----
			buttonItemHoaDon.Enabled = false;
			buttonItemXemSanPham.Enabled = false;
			buttonItemNhapHang.Enabled = true;
			buttonItemBaoHanh.Enabled = false;
			buttonItemTraHang.Enabled = true;
			//----
			ribbonTabItemDanhMuc.Enabled = false;
			//----
			buttonItemKhachHang.Enabled = false;
			buttonItemMatHang.Enabled = false;
			buttonItemThongTinNV.Enabled = false;
			buttonItemBangGia.Enabled = false;
			//----
			ribbonTabItemBaoCao.Enabled = false;
			buttonItemThongKeDoanhThu.Enabled = false;
			buttonItemThongKeKhachHang.Enabled = false;
			buttonItemThongKeMatHang.Enabled = false;
		}
		public void Admin()
		{
			ribbonTabItemHeThong.Enabled = true;
			//----
			buttonItemPhanQuyen.Enabled = true;
			buttonItemMatKhau.Enabled = true;
			buttonItemNguoiDung.Enabled = true;
			buttonItemDangXuat.Enabled = true;
			//-----
			ribbonTabItemNghiepVu.Enabled = true;
			//----
			buttonItemHoaDon.Enabled = true;
			buttonItemXemSanPham.Enabled = true;
			buttonItemNhapHang.Enabled = true;
			buttonItemBaoHanh.Enabled = true;
			buttonItemTraHang.Enabled = true;
			//----
			ribbonTabItemDanhMuc.Enabled = true;
			//----
			buttonItemKhachHang.Enabled = true;
			buttonItemMatHang.Enabled = true;
			buttonItemThongTinNV.Enabled = true;
			buttonItemBangGia.Enabled = true;
			//----
			ribbonTabItemBaoCao.Enabled = true;
			buttonItemThongKeDoanhThu.Enabled = true;
			buttonItemThongKeKhachHang.Enabled = true;
			buttonItemThongKeMatHang.Enabled = true;
		}

		private void ribbonControl1_Click(object sender, EventArgs e)
		{

		}

		
	}
}
