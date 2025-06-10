namespace GUI_PolyCafe
{
    partial class frmQuanLySanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDanhSachSP = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rdbNgungBan = new System.Windows.Forms.CheckBox();
            this.rdbHoatDong = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadSanPham = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.MaskedTextBox();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachSP)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgrDanhSachSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(569, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 612);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dgrDanhSachSP
            // 
            this.dgrDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachSP.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgrDanhSachSP.Location = new System.Drawing.Point(9, 23);
            this.dgrDanhSachSP.Name = "dgrDanhSachSP";
            this.dgrDanhSachSP.Size = new System.Drawing.Size(596, 575);
            this.dgrDanhSachSP.TabIndex = 8;
            this.dgrDanhSachSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachSP_CellDoubleClick);
            this.dgrDanhSachSP.SelectionChanged += new System.EventHandler(this.dgrDanhSachSP_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(32, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(32, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox7.Controls.Add(this.rdbNgungBan);
            this.groupBox7.Controls.Add(this.rdbHoatDong);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox7.Location = new System.Drawing.Point(13, 557);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(550, 65);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Trạng Thái";
            // 
            // rdbNgungBan
            // 
            this.rdbNgungBan.AutoSize = true;
            this.rdbNgungBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbNgungBan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbNgungBan.Location = new System.Drawing.Point(331, 25);
            this.rdbNgungBan.Name = "rdbNgungBan";
            this.rdbNgungBan.Size = new System.Drawing.Size(103, 23);
            this.rdbNgungBan.TabIndex = 2;
            this.rdbNgungBan.Text = "Ngừng bán";
            this.rdbNgungBan.UseVisualStyleBackColor = true;
            // 
            // rdbHoatDong
            // 
            this.rdbHoatDong.AutoSize = true;
            this.rdbHoatDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbHoatDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbHoatDong.Location = new System.Drawing.Point(134, 25);
            this.rdbHoatDong.Name = "rdbHoatDong";
            this.rdbHoatDong.Size = new System.Drawing.Size(100, 23);
            this.rdbHoatDong.TabIndex = 1;
            this.rdbHoatDong.Text = "Hoạt động";
            this.rdbHoatDong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnUploadSanPham);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.pbHinhAnh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.cboLoaiSanPham);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 387);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Thông Tin";
            // 
            // btnUploadSanPham
            // 
            this.btnUploadSanPham.BackColor = System.Drawing.SystemColors.Window;
            this.btnUploadSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUploadSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnUploadSanPham.Image = global::GUI_PolyCafe.Properties.Resources.gallery;
            this.btnUploadSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadSanPham.Location = new System.Drawing.Point(22, 239);
            this.btnUploadSanPham.Name = "btnUploadSanPham";
            this.btnUploadSanPham.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnUploadSanPham.Size = new System.Drawing.Size(131, 41);
            this.btnUploadSanPham.TabIndex = 19;
            this.btnUploadSanPham.Text = "Chọn ảnh";
            this.btnUploadSanPham.UseVisualStyleBackColor = false;
            this.btnUploadSanPham.Click += new System.EventHandler(this.btnUploadSanPham_Click_1);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDonGia.Location = new System.Drawing.Point(167, 143);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(364, 26);
            this.txtDonGia.TabIndex = 20;
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.BackColor = System.Drawing.Color.White;
            this.pbHinhAnh.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.th;
            this.pbHinhAnh.Image = global::GUI_PolyCafe.Properties.Resources.th;
            this.pbHinhAnh.Location = new System.Drawing.Point(259, 239);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(179, 128);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 17;
            this.pbHinhAnh.TabStop = false;
            this.pbHinhAnh.Click += new System.EventHandler(this.pbHinhAnh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaSanPham.Location = new System.Drawing.Point(167, 30);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(364, 26);
            this.txtMaSanPham.TabIndex = 5;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(167, 196);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(364, 28);
            this.cboLoaiSanPham.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đơn giá";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTenSanPham.Location = new System.Drawing.Point(167, 84);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(364, 26);
            this.txtTenSanPham.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(18, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại Sản Phẩm";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox5.Location = new System.Drawing.Point(12, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 70);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = global::GUI_PolyCafe.Properties.Resources.searching;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(11, 20);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.Location = new System.Drawing.Point(161, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 27);
            this.textBox1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(12, 619);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 105);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = global::GUI_PolyCafe.Properties.Resources.Thêm_2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(18, 39);
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
            this.btnLamMoi.Location = new System.Drawing.Point(424, 39);
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
            this.btnSua.Location = new System.Drawing.Point(157, 39);
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
            this.btnXoa.Location = new System.Drawing.Point(290, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnXoa.Size = new System.Drawing.Size(118, 52);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.BACKGROUD_Poly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 727);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmQuanLySanPham";
            this.Text = "frmQuanLySanPham";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachSP)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrDanhSachSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox rdbNgungBan;
        private System.Windows.Forms.CheckBox rdbHoatDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUploadSanPham;
        private System.Windows.Forms.MaskedTextBox txtDonGia;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}