namespace QuanLyBanDienThoai
{
	partial class PhanQuyen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxTaiKhoan = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewChucNang = new System.Windows.Forms.DataGridView();
			this.buttonLuu = new System.Windows.Forms.Button();
			this.groupBoxQuyen = new System.Windows.Forms.GroupBox();
			this.checkBoxPhanquyen = new System.Windows.Forms.CheckBox();
			this.checkBoxMatkhau = new System.Windows.Forms.CheckBox();
			this.checkBoxNguoidung = new System.Windows.Forms.CheckBox();
			this.checkBoxDangxuat = new System.Windows.Forms.CheckBox();
			this.checkBoxHoadon = new System.Windows.Forms.CheckBox();
			this.checkBoxXemsanpham = new System.Windows.Forms.CheckBox();
			this.checkBoxBaohanh = new System.Windows.Forms.CheckBox();
			this.checkBoxNhaphang = new System.Windows.Forms.CheckBox();
			this.checkBoxTrahang = new System.Windows.Forms.CheckBox();
			this.checkBoxKhachhang = new System.Windows.Forms.CheckBox();
			this.checkBoxMathang = new System.Windows.Forms.CheckBox();
			this.checkBoxThongtinnhanvien = new System.Windows.Forms.CheckBox();
			this.checkBoxBanggia = new System.Windows.Forms.CheckBox();
			this.checkBoxThongkedoanhthu = new System.Windows.Forms.CheckBox();
			this.checkBoxThongkekhachhang = new System.Windows.Forms.CheckBox();
			this.checkBoxThongkemathang = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucNang)).BeginInit();
			this.groupBoxQuyen.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxTaiKhoan
			// 
			this.comboBoxTaiKhoan.FormattingEnabled = true;
			this.comboBoxTaiKhoan.Location = new System.Drawing.Point(109, 16);
			this.comboBoxTaiKhoan.Name = "comboBoxTaiKhoan";
			this.comboBoxTaiKhoan.Size = new System.Drawing.Size(164, 21);
			this.comboBoxTaiKhoan.TabIndex = 0;
			this.comboBoxTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaiKhoan_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tài khoản";
			// 
			// dataGridViewChucNang
			// 
			this.dataGridViewChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewChucNang.Location = new System.Drawing.Point(26, 136);
			this.dataGridViewChucNang.Name = "dataGridViewChucNang";
			this.dataGridViewChucNang.Size = new System.Drawing.Size(763, 275);
			this.dataGridViewChucNang.TabIndex = 2;
			this.dataGridViewChucNang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucNang_CellContentClick);
			this.dataGridViewChucNang.SelectionChanged += new System.EventHandler(this.dataGridViewChucNang_SelectionChanged);
			// 
			// buttonLuu
			// 
			this.buttonLuu.Location = new System.Drawing.Point(26, 430);
			this.buttonLuu.Name = "buttonLuu";
			this.buttonLuu.Size = new System.Drawing.Size(100, 27);
			this.buttonLuu.TabIndex = 3;
			this.buttonLuu.Text = "Lưu";
			this.buttonLuu.UseVisualStyleBackColor = true;
			this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
			// 
			// groupBoxQuyen
			// 
			this.groupBoxQuyen.Controls.Add(this.checkBoxThongkemathang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxThongtinnhanvien);
			this.groupBoxQuyen.Controls.Add(this.checkBoxNhaphang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxDangxuat);
			this.groupBoxQuyen.Controls.Add(this.checkBoxThongkekhachhang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxMathang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxBaohanh);
			this.groupBoxQuyen.Controls.Add(this.checkBoxNguoidung);
			this.groupBoxQuyen.Controls.Add(this.checkBoxThongkedoanhthu);
			this.groupBoxQuyen.Controls.Add(this.checkBoxBanggia);
			this.groupBoxQuyen.Controls.Add(this.checkBoxKhachhang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxTrahang);
			this.groupBoxQuyen.Controls.Add(this.checkBoxXemsanpham);
			this.groupBoxQuyen.Controls.Add(this.checkBoxHoadon);
			this.groupBoxQuyen.Controls.Add(this.checkBoxMatkhau);
			this.groupBoxQuyen.Controls.Add(this.checkBoxPhanquyen);
			this.groupBoxQuyen.Location = new System.Drawing.Point(296, 14);
			this.groupBoxQuyen.Name = "groupBoxQuyen";
			this.groupBoxQuyen.Size = new System.Drawing.Size(493, 116);
			this.groupBoxQuyen.TabIndex = 4;
			this.groupBoxQuyen.TabStop = false;
			this.groupBoxQuyen.Text = "Quyền";
			// 
			// checkBoxPhanquyen
			// 
			this.checkBoxPhanquyen.AutoSize = true;
			this.checkBoxPhanquyen.Location = new System.Drawing.Point(15, 19);
			this.checkBoxPhanquyen.Name = "checkBoxPhanquyen";
			this.checkBoxPhanquyen.Size = new System.Drawing.Size(83, 17);
			this.checkBoxPhanquyen.TabIndex = 0;
			this.checkBoxPhanquyen.Text = "Phân quyền";
			this.checkBoxPhanquyen.UseVisualStyleBackColor = true;
			// 
			// checkBoxMatkhau
			// 
			this.checkBoxMatkhau.AutoSize = true;
			this.checkBoxMatkhau.Location = new System.Drawing.Point(15, 42);
			this.checkBoxMatkhau.Name = "checkBoxMatkhau";
			this.checkBoxMatkhau.Size = new System.Drawing.Size(71, 17);
			this.checkBoxMatkhau.TabIndex = 0;
			this.checkBoxMatkhau.Text = "Mật khẩu";
			this.checkBoxMatkhau.UseVisualStyleBackColor = true;
			// 
			// checkBoxNguoidung
			// 
			this.checkBoxNguoidung.AutoSize = true;
			this.checkBoxNguoidung.Location = new System.Drawing.Point(15, 65);
			this.checkBoxNguoidung.Name = "checkBoxNguoidung";
			this.checkBoxNguoidung.Size = new System.Drawing.Size(81, 17);
			this.checkBoxNguoidung.TabIndex = 0;
			this.checkBoxNguoidung.Text = "Người dùng";
			this.checkBoxNguoidung.UseVisualStyleBackColor = true;
			// 
			// checkBoxDangxuat
			// 
			this.checkBoxDangxuat.AutoSize = true;
			this.checkBoxDangxuat.Location = new System.Drawing.Point(15, 88);
			this.checkBoxDangxuat.Name = "checkBoxDangxuat";
			this.checkBoxDangxuat.Size = new System.Drawing.Size(75, 17);
			this.checkBoxDangxuat.TabIndex = 0;
			this.checkBoxDangxuat.Text = "Đăng xuất";
			this.checkBoxDangxuat.UseVisualStyleBackColor = true;
			// 
			// checkBoxHoadon
			// 
			this.checkBoxHoadon.AutoSize = true;
			this.checkBoxHoadon.Location = new System.Drawing.Point(131, 19);
			this.checkBoxHoadon.Name = "checkBoxHoadon";
			this.checkBoxHoadon.Size = new System.Drawing.Size(68, 17);
			this.checkBoxHoadon.TabIndex = 0;
			this.checkBoxHoadon.Text = "Hóa đơn";
			this.checkBoxHoadon.UseVisualStyleBackColor = true;
			// 
			// checkBoxXemsanpham
			// 
			this.checkBoxXemsanpham.AutoSize = true;
			this.checkBoxXemsanpham.Location = new System.Drawing.Point(131, 42);
			this.checkBoxXemsanpham.Name = "checkBoxXemsanpham";
			this.checkBoxXemsanpham.Size = new System.Drawing.Size(96, 17);
			this.checkBoxXemsanpham.TabIndex = 0;
			this.checkBoxXemsanpham.Text = "Xem sản phẩm";
			this.checkBoxXemsanpham.UseVisualStyleBackColor = true;
			// 
			// checkBoxBaohanh
			// 
			this.checkBoxBaohanh.AutoSize = true;
			this.checkBoxBaohanh.Location = new System.Drawing.Point(131, 65);
			this.checkBoxBaohanh.Name = "checkBoxBaohanh";
			this.checkBoxBaohanh.Size = new System.Drawing.Size(72, 17);
			this.checkBoxBaohanh.TabIndex = 0;
			this.checkBoxBaohanh.Text = "Bảo hành";
			this.checkBoxBaohanh.UseVisualStyleBackColor = true;
			// 
			// checkBoxNhaphang
			// 
			this.checkBoxNhaphang.AutoSize = true;
			this.checkBoxNhaphang.Location = new System.Drawing.Point(131, 88);
			this.checkBoxNhaphang.Name = "checkBoxNhaphang";
			this.checkBoxNhaphang.Size = new System.Drawing.Size(79, 17);
			this.checkBoxNhaphang.TabIndex = 0;
			this.checkBoxNhaphang.Text = "Nhập hàng";
			this.checkBoxNhaphang.UseVisualStyleBackColor = true;
			// 
			// checkBoxTrahang
			// 
			this.checkBoxTrahang.AutoSize = true;
			this.checkBoxTrahang.Location = new System.Drawing.Point(237, 19);
			this.checkBoxTrahang.Name = "checkBoxTrahang";
			this.checkBoxTrahang.Size = new System.Drawing.Size(69, 17);
			this.checkBoxTrahang.TabIndex = 0;
			this.checkBoxTrahang.Text = "Trả hàng";
			this.checkBoxTrahang.UseVisualStyleBackColor = true;
			// 
			// checkBoxKhachhang
			// 
			this.checkBoxKhachhang.AutoSize = true;
			this.checkBoxKhachhang.Location = new System.Drawing.Point(237, 42);
			this.checkBoxKhachhang.Name = "checkBoxKhachhang";
			this.checkBoxKhachhang.Size = new System.Drawing.Size(84, 17);
			this.checkBoxKhachhang.TabIndex = 0;
			this.checkBoxKhachhang.Text = "Khách hàng";
			this.checkBoxKhachhang.UseVisualStyleBackColor = true;
			// 
			// checkBoxMathang
			// 
			this.checkBoxMathang.AutoSize = true;
			this.checkBoxMathang.Location = new System.Drawing.Point(237, 65);
			this.checkBoxMathang.Name = "checkBoxMathang";
			this.checkBoxMathang.Size = new System.Drawing.Size(71, 17);
			this.checkBoxMathang.TabIndex = 0;
			this.checkBoxMathang.Text = "Mặt hàng";
			this.checkBoxMathang.UseVisualStyleBackColor = true;
			// 
			// checkBoxThongtinnhanvien
			// 
			this.checkBoxThongtinnhanvien.AutoSize = true;
			this.checkBoxThongtinnhanvien.Location = new System.Drawing.Point(237, 88);
			this.checkBoxThongtinnhanvien.Name = "checkBoxThongtinnhanvien";
			this.checkBoxThongtinnhanvien.Size = new System.Drawing.Size(121, 17);
			this.checkBoxThongtinnhanvien.TabIndex = 0;
			this.checkBoxThongtinnhanvien.Text = "Thông tin nhân viên";
			this.checkBoxThongtinnhanvien.UseVisualStyleBackColor = true;
			// 
			// checkBoxBanggia
			// 
			this.checkBoxBanggia.AutoSize = true;
			this.checkBoxBanggia.Location = new System.Drawing.Point(363, 19);
			this.checkBoxBanggia.Name = "checkBoxBanggia";
			this.checkBoxBanggia.Size = new System.Drawing.Size(68, 17);
			this.checkBoxBanggia.TabIndex = 0;
			this.checkBoxBanggia.Text = "Bảng giá";
			this.checkBoxBanggia.UseVisualStyleBackColor = true;
			// 
			// checkBoxThongkedoanhthu
			// 
			this.checkBoxThongkedoanhthu.AutoSize = true;
			this.checkBoxThongkedoanhthu.Location = new System.Drawing.Point(363, 42);
			this.checkBoxThongkedoanhthu.Name = "checkBoxThongkedoanhthu";
			this.checkBoxThongkedoanhthu.Size = new System.Drawing.Size(123, 17);
			this.checkBoxThongkedoanhthu.TabIndex = 0;
			this.checkBoxThongkedoanhthu.Text = "Thống kê doanh thu";
			this.checkBoxThongkedoanhthu.UseVisualStyleBackColor = true;
			// 
			// checkBoxThongkekhachhang
			// 
			this.checkBoxThongkekhachhang.AutoSize = true;
			this.checkBoxThongkekhachhang.Location = new System.Drawing.Point(363, 65);
			this.checkBoxThongkekhachhang.Name = "checkBoxThongkekhachhang";
			this.checkBoxThongkekhachhang.Size = new System.Drawing.Size(132, 17);
			this.checkBoxThongkekhachhang.TabIndex = 0;
			this.checkBoxThongkekhachhang.Text = "Thống kê khách hàng";
			this.checkBoxThongkekhachhang.UseVisualStyleBackColor = true;
			// 
			// checkBoxThongkemathang
			// 
			this.checkBoxThongkemathang.AutoSize = true;
			this.checkBoxThongkemathang.Location = new System.Drawing.Point(363, 88);
			this.checkBoxThongkemathang.Name = "checkBoxThongkemathang";
			this.checkBoxThongkemathang.Size = new System.Drawing.Size(119, 17);
			this.checkBoxThongkemathang.TabIndex = 0;
			this.checkBoxThongkemathang.Text = "Thống kê mặt hàng";
			this.checkBoxThongkemathang.UseVisualStyleBackColor = true;
			// 
			// PhanQuyen
			// 
			this.ClientSize = new System.Drawing.Size(818, 471);
			this.Controls.Add(this.groupBoxQuyen);
			this.Controls.Add(this.buttonLuu);
			this.Controls.Add(this.dataGridViewChucNang);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxTaiKhoan);
			this.DoubleBuffered = true;
			this.Name = "PhanQuyen";
			this.Text = "PhanQuyen";
			this.Load += new System.EventHandler(this.PhanQuyen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucNang)).EndInit();
			this.groupBoxQuyen.ResumeLayout(false);
			this.groupBoxQuyen.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxTaiKhoan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewChucNang;
		private System.Windows.Forms.Button buttonLuu;
		private System.Windows.Forms.GroupBox groupBoxQuyen;
		private System.Windows.Forms.CheckBox checkBoxThongkemathang;
		private System.Windows.Forms.CheckBox checkBoxThongtinnhanvien;
		private System.Windows.Forms.CheckBox checkBoxNhaphang;
		private System.Windows.Forms.CheckBox checkBoxDangxuat;
		private System.Windows.Forms.CheckBox checkBoxThongkekhachhang;
		private System.Windows.Forms.CheckBox checkBoxMathang;
		private System.Windows.Forms.CheckBox checkBoxBaohanh;
		private System.Windows.Forms.CheckBox checkBoxNguoidung;
		private System.Windows.Forms.CheckBox checkBoxThongkedoanhthu;
		private System.Windows.Forms.CheckBox checkBoxBanggia;
		private System.Windows.Forms.CheckBox checkBoxKhachhang;
		private System.Windows.Forms.CheckBox checkBoxTrahang;
		private System.Windows.Forms.CheckBox checkBoxXemsanpham;
		private System.Windows.Forms.CheckBox checkBoxHoadon;
		private System.Windows.Forms.CheckBox checkBoxMatkhau;
		private System.Windows.Forms.CheckBox checkBoxPhanquyen;
	}
}