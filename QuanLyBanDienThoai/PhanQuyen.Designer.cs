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
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucNang)).BeginInit();
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
			this.dataGridViewChucNang.Location = new System.Drawing.Point(26, 77);
			this.dataGridViewChucNang.Name = "dataGridViewChucNang";
			this.dataGridViewChucNang.Size = new System.Drawing.Size(763, 334);
			this.dataGridViewChucNang.TabIndex = 2;
			this.dataGridViewChucNang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucNang_CellContentClick);
			// 
			// buttonLuu
			// 
			this.buttonLuu.Location = new System.Drawing.Point(26, 430);
			this.buttonLuu.Name = "buttonLuu";
			this.buttonLuu.Size = new System.Drawing.Size(100, 27);
			this.buttonLuu.TabIndex = 3;
			this.buttonLuu.Text = "Lưu";
			this.buttonLuu.UseVisualStyleBackColor = true;
			// 
			// PhanQuyen
			// 
			this.ClientSize = new System.Drawing.Size(818, 471);
			this.Controls.Add(this.buttonLuu);
			this.Controls.Add(this.dataGridViewChucNang);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxTaiKhoan);
			this.DoubleBuffered = true;
			this.Name = "PhanQuyen";
			this.Text = "PhanQuyen";
			this.Load += new System.EventHandler(this.PhanQuyen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucNang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxTaiKhoan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewChucNang;
		private System.Windows.Forms.Button buttonLuu;
	}
}