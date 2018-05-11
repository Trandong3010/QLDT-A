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
			//CapQuyen(ChucNang);
			//FormDangNhap frmDN = new FormDangNhap();
			//frmDN.ShowDialog();
			if(FormDangNhap.Phanquyen) buttonItemPhanQuyen.Enabled = true; else buttonItemPhanQuyen.Enabled = false;
			if(FormDangNhap.Matkhau) buttonItemMatKhau.Enabled = true; else buttonItemMatKhau.Enabled = false;
			if(FormDangNhap.Nguoidung) buttonItemNguoiDung.Enabled = true; else buttonItemNguoiDung.Enabled = false;
			if (FormDangNhap.Dangxuat) buttonItemDangXuat.Enabled = true; else buttonItemDangXuat.Enabled = false;
			if (FormDangNhap.Hoadon) buttonItemHoaDon.Enabled = true; else buttonItemHoaDon.Enabled = false;
			if (FormDangNhap.Xemsanpham) buttonItemXemSanPham.Enabled = true; else buttonItemXemSanPham.Enabled = false;
			if (FormDangNhap.Baohanh) buttonItemBaoHanh.Enabled = true; else buttonItemBaoHanh.Enabled = false;
			if (FormDangNhap.Nhaphang) buttonItemNhapHang.Enabled = true; else buttonItemNhapHang.Enabled = false;
			if (FormDangNhap.Trahang) buttonItemTraHang.Enabled = true; else buttonItemTraHang.Enabled = false;
			if (FormDangNhap.Khachhang) buttonItemKhachHang.Enabled = true; else buttonItemKhachHang.Enabled = false;
			if (FormDangNhap.Mathang) buttonItemMatHang.Enabled = true; else buttonItemMatHang.Enabled = false;
			if (FormDangNhap.Nhanvien) buttonItemThongTinNV.Enabled = true; else buttonItemThongTinNV.Enabled = false;
			if (FormDangNhap.Banggia) buttonItemBangGia.Enabled = true; else buttonItemBangGia.Enabled = false;
			if (FormDangNhap.TKdoanhthu) buttonItemThongKeDoanhThu.Enabled = true; else buttonItemThongKeDoanhThu.Enabled = false;
			if (FormDangNhap.TKKhachhang) buttonItemThongKeKhachHang.Enabled = true; else buttonItemThongKeKhachHang.Enabled = false;
			if (FormDangNhap.TKMathang) buttonItemThongKeMatHang.Enabled = true; else buttonItemThongKeMatHang.Enabled = false;
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


		private void buttonItemDangXuat_Click(object sender, EventArgs e)
		{
			Disable();
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


		private void buttonItemHoaDon_Click(object sender, EventArgs e)
		{

			UCHoaDon uc = new UCHoaDon();
			addtab("Hóa đơn", uc);
		}

		private void addtab(string tabname, UserControl control)
		{
			foreach (TabItem tabPage in tabControlMain.Tabs)
				if (tabPage.Text == tabname)
				{
					tabControlMain.SelectedTab = tabPage;
					return;
				}
			TabControlPanel newtabpannel = new DevComponents.DotNetBar.TabControlPanel();
			TabItem newtab = new TabItem(this.components);
			newtabpannel.Dock = System.Windows.Forms.DockStyle.Fill;
			newtabpannel.Location = new System.Drawing.Point(0, 26);
			newtabpannel.Name = tabname;
			newtabpannel.Padding = new System.Windows.Forms.Padding(1);
			newtabpannel.Size = new System.Drawing.Size(1230, 384);
			newtabpannel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			newtabpannel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			newtabpannel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			newtabpannel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
			newtabpannel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
										| DevComponents.DotNetBar.eBorderSide.Bottom)));
			newtabpannel.Style.GradientAngle = 90;
			newtabpannel.TabIndex = 2;
			newtabpannel.TabItem = newtab;
			Random ran = new Random();
			newtab.Name = tabname + ran.Next(100000) + ran.Next(22342);

			newtab.AttachedControl = newtabpannel;
			newtab.Text = tabname;
			newtab.CloseButtonVisible = true;
			control.Dock = DockStyle.Fill;
			newtabpannel.Controls.Add(control);
			tabControlMain.Controls.Add(newtabpannel);
			tabControlMain.Tabs.Add(newtab);
			tabControlMain.SelectedTab = newtab;

		}

		private void buttonItemXemSanPham_Click(object sender, EventArgs e)
		{
			UCXemSanPham uc = new UCXemSanPham();
			addtab("Xem thông tin sản phẩm", uc);
		}

		private void buttonItemBaoHanh_Click(object sender, EventArgs e)
		{
			UCPhieuBaoHanh uc = new UCPhieuBaoHanh();
			addtab("Phiếu bảo hành", uc);
		}

		private void buttonItemNhapHang_Click(object sender, EventArgs e)
		{
			UCPhieuNhapHang uc = new UCPhieuNhapHang();
			addtab("Phiếu nhập hàng", uc);
		}

		private void buttonItemTraHang_Click(object sender, EventArgs e)
		{
			UCPhieuTraHang uc = new UCPhieuTraHang();
			addtab("Phiếu trả hàng", uc);
		}

		private void buttonItemMatHang_Click(object sender, EventArgs e)
		{
			UCHangHoa uc = new UCHangHoa();
			addtab("Hàng hóa", uc);
		}

		private void buttonItemThongTinNV_Click(object sender, EventArgs e)
		{
			UCQLThongTinNhanVien uc = new UCQLThongTinNhanVien();
			addtab("Quản lý thông tin nhân viên", uc);
		}

		private void buttonItemBangGia_Click(object sender, EventArgs e)
		{
			UCBangGia uc = new UCBangGia();
			addtab("Bảng giá", uc);
		}

		private void buttonItemThongKeDoanhThu_Click(object sender, EventArgs e)
		{

		}

		private void buttonItemThongKeKhachHang_Click(object sender, EventArgs e)
		{

		}

		private void buttonItemThongKeMatHang_Click(object sender, EventArgs e)
		{

		}
	}
}
