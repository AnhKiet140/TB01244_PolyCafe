namespace GUI_PolyCafe
{
    partial class frmQuanLyPhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhieuBanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVienBH = new System.Windows.Forms.ComboBox();
            this.cboMaTheLuuDong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbDaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdbChoThanhToan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachPhieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Phiếu Bán Hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgrDanhSachPhieu);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(580, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 589);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách";
            // 
            // dgrDanhSachPhieu
            // 
            this.dgrDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachPhieu.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgrDanhSachPhieu.Location = new System.Drawing.Point(9, 24);
            this.dgrDanhSachPhieu.Name = "dgrDanhSachPhieu";
            this.dgrDanhSachPhieu.Size = new System.Drawing.Size(593, 559);
            this.dgrDanhSachPhieu.TabIndex = 8;
            this.dgrDanhSachPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachPhieu_CellClick);
            this.dgrDanhSachPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachPhieu_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(32, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(32, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtpNgayTao);
            this.groupBox2.Controls.Add(this.cboNhanVienBH);
            this.groupBox2.Controls.Add(this.cboMaTheLuuDong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaPhieu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 254);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Thông Tin";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(150, 206);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(380, 26);
            this.dtpNgayTao.TabIndex = 15;
            // 
            // cboNhanVienBH
            // 
            this.cboNhanVienBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cboNhanVienBH.FormattingEnabled = true;
            this.cboNhanVienBH.Location = new System.Drawing.Point(150, 145);
            this.cboNhanVienBH.Name = "cboNhanVienBH";
            this.cboNhanVienBH.Size = new System.Drawing.Size(381, 28);
            this.cboNhanVienBH.TabIndex = 14;
            // 
            // cboMaTheLuuDong
            // 
            this.cboMaTheLuuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cboMaTheLuuDong.FormattingEnabled = true;
            this.cboMaTheLuuDong.Location = new System.Drawing.Point(150, 37);
            this.cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            this.cboMaTheLuuDong.Size = new System.Drawing.Size(381, 28);
            this.cboMaTheLuuDong.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(32, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày Tạo";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaPhieu.Location = new System.Drawing.Point(150, 91);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(381, 26);
            this.txtMaPhieu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thẻ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.rdbDaThanhToan);
            this.groupBox5.Controls.Add(this.rdbChoThanhToan);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox5.Location = new System.Drawing.Point(12, 436);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 71);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trạng Thái";
            // 
            // rdbDaThanhToan
            // 
            this.rdbDaThanhToan.AutoSize = true;
            this.rdbDaThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbDaThanhToan.Location = new System.Drawing.Point(300, 33);
            this.rdbDaThanhToan.Name = "rdbDaThanhToan";
            this.rdbDaThanhToan.Size = new System.Drawing.Size(123, 19);
            this.rdbDaThanhToan.TabIndex = 1;
            this.rdbDaThanhToan.TabStop = true;
            this.rdbDaThanhToan.Text = "Đã Thanh Toán";
            this.rdbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbChoThanhToan
            // 
            this.rdbChoThanhToan.AutoSize = true;
            this.rdbChoThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbChoThanhToan.Location = new System.Drawing.Point(80, 33);
            this.rdbChoThanhToan.Name = "rdbChoThanhToan";
            this.rdbChoThanhToan.Size = new System.Drawing.Size(130, 19);
            this.rdbChoThanhToan.TabIndex = 0;
            this.rdbChoThanhToan.TabStop = true;
            this.rdbChoThanhToan.Text = "Chờ Thanh Toán";
            this.rdbChoThanhToan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 105);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = global::GUI_PolyCafe.Properties.Resources.Thêm_2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(13, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(15, 0, 28, 0);
            this.btnThem.Size = new System.Drawing.Size(118, 52);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLamMoi.Image = global::GUI_PolyCafe.Properties.Resources.Làm_mới_2;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(418, 34);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnLamMoi.Size = new System.Drawing.Size(118, 52);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSua.Image = global::GUI_PolyCafe.Properties.Resources.sửa_2;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(149, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnSua.Size = new System.Drawing.Size(118, 52);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = global::GUI_PolyCafe.Properties.Resources.xoá_2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(283, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnXoa.Size = new System.Drawing.Size(118, 52);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.txtTimKiem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox6.Location = new System.Drawing.Point(12, 105);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(550, 70);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Image = global::GUI_PolyCafe.Properties.Resources.searching;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(144, 35);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTimKiem.Location = new System.Drawing.Point(161, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(370, 27);
            this.txtTimKiem.TabIndex = 16;
            // 
            // frmQuanLyPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.BACKGROUD_Poly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 704);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyPhieuBanHang";
            this.Text = "Quản Lý Phiếu Bán Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuBanHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachPhieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgrDanhSachPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.ComboBox cboNhanVienBH;
        private System.Windows.Forms.ComboBox cboMaTheLuuDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdbDaThanhToan;
        private System.Windows.Forms.RadioButton rdbChoThanhToan;
    }
}