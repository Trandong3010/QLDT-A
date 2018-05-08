namespace QuanLyBanDienThoai
{
	partial class NguoiDung
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiDung));
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTimND = new System.Windows.Forms.Button();
			this.textBoxTimKiemND = new System.Windows.Forms.TextBox();
			this.radioButtonTenNV = new System.Windows.Forms.RadioButton();
			this.radioButtonTenTK = new System.Windows.Forms.RadioButton();
			this.buttonThem = new System.Windows.Forms.Button();
			this.buttonXoa = new System.Windows.Forms.Button();
			this.buttonSua = new System.Windows.Forms.Button();
			this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTenTKND = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxMatKhauND = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxQuyen = new System.Windows.Forms.TextBox();
			this.textBoxChucNang = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 474);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Hiển thị tất cả";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTimND);
			this.groupBox1.Controls.Add(this.textBoxTimKiemND);
			this.groupBox1.Controls.Add(this.radioButtonTenNV);
			this.groupBox1.Controls.Add(this.radioButtonTenTK);
			this.groupBox1.Location = new System.Drawing.Point(22, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(514, 63);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// buttonTimND
			// 
			this.buttonTimND.Location = new System.Drawing.Point(420, 31);
			this.buttonTimND.Name = "buttonTimND";
			this.buttonTimND.Size = new System.Drawing.Size(88, 22);
			this.buttonTimND.TabIndex = 2;
			this.buttonTimND.Text = "Tìm";
			this.buttonTimND.UseVisualStyleBackColor = true;
			this.buttonTimND.Click += new System.EventHandler(this.buttonTimND_Click);
			// 
			// textBoxTimKiemND
			// 
			this.textBoxTimKiemND.Location = new System.Drawing.Point(211, 32);
			this.textBoxTimKiemND.Name = "textBoxTimKiemND";
			this.textBoxTimKiemND.Size = new System.Drawing.Size(203, 20);
			this.textBoxTimKiemND.TabIndex = 1;
			// 
			// radioButtonTenNV
			// 
			this.radioButtonTenNV.AutoSize = true;
			this.radioButtonTenNV.Location = new System.Drawing.Point(111, 32);
			this.radioButtonTenNV.Name = "radioButtonTenNV";
			this.radioButtonTenNV.Size = new System.Drawing.Size(94, 17);
			this.radioButtonTenNV.TabIndex = 0;
			this.radioButtonTenNV.TabStop = true;
			this.radioButtonTenNV.Text = "Tên nhân viên";
			this.radioButtonTenNV.UseVisualStyleBackColor = true;
			// 
			// radioButtonTenTK
			// 
			this.radioButtonTenTK.AutoSize = true;
			this.radioButtonTenTK.Location = new System.Drawing.Point(14, 32);
			this.radioButtonTenTK.Name = "radioButtonTenTK";
			this.radioButtonTenTK.Size = new System.Drawing.Size(91, 17);
			this.radioButtonTenTK.TabIndex = 0;
			this.radioButtonTenTK.TabStop = true;
			this.radioButtonTenTK.Text = "Tên tài khoản";
			this.radioButtonTenTK.UseVisualStyleBackColor = true;
			// 
			// buttonThem
			// 
			this.buttonThem.Location = new System.Drawing.Point(158, 475);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new System.Drawing.Size(105, 31);
			this.buttonThem.TabIndex = 2;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
			// 
			// buttonXoa
			// 
			this.buttonXoa.Location = new System.Drawing.Point(286, 474);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new System.Drawing.Size(105, 31);
			this.buttonXoa.TabIndex = 2;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
			// 
			// buttonSua
			// 
			this.buttonSua.Location = new System.Drawing.Point(415, 474);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new System.Drawing.Size(105, 31);
			this.buttonSua.TabIndex = 2;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
			// 
			// dataGridViewNguoiDung
			// 
			this.dataGridViewNguoiDung.AllowUserToOrderColumns = true;
			this.dataGridViewNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNguoiDung.Location = new System.Drawing.Point(22, 191);
			this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
			this.dataGridViewNguoiDung.Size = new System.Drawing.Size(498, 252);
			this.dataGridViewNguoiDung.TabIndex = 3;
			this.dataGridViewNguoiDung.SelectionChanged += new System.EventHandler(this.dataGridViewNguoiDung_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tên tài khoản";
			// 
			// textBoxTenTKND
			// 
			this.textBoxTenTKND.Location = new System.Drawing.Point(98, 88);
			this.textBoxTenTKND.Name = "textBoxTenTKND";
			this.textBoxTenTKND.Size = new System.Drawing.Size(156, 20);
			this.textBoxTenTKND.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(305, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mật khẩu";
			// 
			// textBoxMatKhauND
			// 
			this.textBoxMatKhauND.Location = new System.Drawing.Point(374, 88);
			this.textBoxMatKhauND.Name = "textBoxMatKhauND";
			this.textBoxMatKhauND.Size = new System.Drawing.Size(156, 20);
			this.textBoxMatKhauND.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Chức năng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(305, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Quyền";
			// 
			// textBoxQuyen
			// 
			this.textBoxQuyen.Location = new System.Drawing.Point(374, 131);
			this.textBoxQuyen.Name = "textBoxQuyen";
			this.textBoxQuyen.Size = new System.Drawing.Size(156, 20);
			this.textBoxQuyen.TabIndex = 5;
			// 
			// textBoxChucNang
			// 
			this.textBoxChucNang.Location = new System.Drawing.Point(98, 131);
			this.textBoxChucNang.Name = "textBoxChucNang";
			this.textBoxChucNang.Size = new System.Drawing.Size(156, 20);
			this.textBoxChucNang.TabIndex = 5;
			// 
			// NguoiDung
			// 
			this.ClientSize = new System.Drawing.Size(550, 516);
			this.Controls.Add(this.textBoxChucNang);
			this.Controls.Add(this.textBoxQuyen);
			this.Controls.Add(this.textBoxMatKhauND);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxTenTKND);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewNguoiDung);
			this.Controls.Add(this.buttonSua);
			this.Controls.Add(this.buttonXoa);
			this.Controls.Add(this.buttonThem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NguoiDung";
			this.Text = "NguoiDung";
			this.Load += new System.EventHandler(this.NguoiDung_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTimND;
		private System.Windows.Forms.TextBox textBoxTimKiemND;
		private System.Windows.Forms.RadioButton radioButtonTenNV;
		private System.Windows.Forms.RadioButton radioButtonTenTK;
		private System.Windows.Forms.Button buttonThem;
		private System.Windows.Forms.Button buttonXoa;
		private System.Windows.Forms.Button buttonSua;
		private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTenTKND;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMatKhauND;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxQuyen;
		private System.Windows.Forms.TextBox textBoxChucNang;
	}
}