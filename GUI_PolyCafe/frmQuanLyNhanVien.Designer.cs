namespace GUI_PolyCafe
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkKhongHoatDong = new System.Windows.Forms.CheckBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkQuanLy = new System.Windows.Forms.CheckBox();
            this.chkNhanVien = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDanhSachNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(567, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(9, 20);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(593, 563);
            this.dgvDanhSachNhanVien.TabIndex = 0;
            this.dgvDanhSachNhanVien.SelectionChanged += new System.EventHandler(this.dgvDanhSachNhanVien_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtEmail.Location = new System.Drawing.Point(146, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMatKhau.Location = new System.Drawing.Point(148, 217);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(369, 26);
            this.txtMatKhau.TabIndex = 14;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtHoVaTen.Location = new System.Drawing.Point(146, 113);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(371, 26);
            this.txtHoVaTen.TabIndex = 11;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(146, 56);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(371, 26);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.chkKhongHoatDong);
            this.groupBox5.Controls.Add(this.chkHoatDong);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox5.Location = new System.Drawing.Point(20, 523);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(540, 71);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trạng Thái";
            // 
            // chkKhongHoatDong
            // 
            this.chkKhongHoatDong.AutoSize = true;
            this.chkKhongHoatDong.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkKhongHoatDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkKhongHoatDong.Location = new System.Drawing.Point(320, 31);
            this.chkKhongHoatDong.Name = "chkKhongHoatDong";
            this.chkKhongHoatDong.Size = new System.Drawing.Size(154, 23);
            this.chkKhongHoatDong.TabIndex = 2;
            this.chkKhongHoatDong.Text = "Không Hoạt động";
            this.chkKhongHoatDong.UseVisualStyleBackColor = true;
            this.chkKhongHoatDong.CheckedChanged += new System.EventHandler(this.chkKhongHoatDong_CheckedChanged);
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.AutoSize = true;
            this.chkHoatDong.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkHoatDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkHoatDong.Location = new System.Drawing.Point(90, 31);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(104, 23);
            this.chkHoatDong.TabIndex = 1;
            this.chkHoatDong.Text = "Hoạt động";
            this.chkHoatDong.UseVisualStyleBackColor = true;
            this.chkHoatDong.CheckedChanged += new System.EventHandler(this.chkHoatDong_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.chkQuanLy);
            this.groupBox3.Controls.Add(this.chkNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(20, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vai Trò";
            // 
            // chkQuanLy
            // 
            this.chkQuanLy.AutoSize = true;
            this.chkQuanLy.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkQuanLy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkQuanLy.Location = new System.Drawing.Point(320, 30);
            this.chkQuanLy.Name = "chkQuanLy";
            this.chkQuanLy.Size = new System.Drawing.Size(86, 23);
            this.chkQuanLy.TabIndex = 1;
            this.chkQuanLy.Text = "Quản Lý";
            this.chkQuanLy.UseVisualStyleBackColor = true;
            this.chkQuanLy.CheckedChanged += new System.EventHandler(this.chkQuanLy_CheckedChanged);
            // 
            // chkNhanVien
            // 
            this.chkNhanVien.AutoSize = true;
            this.chkNhanVien.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkNhanVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkNhanVien.Location = new System.Drawing.Point(93, 30);
            this.chkNhanVien.Name = "chkNhanVien";
            this.chkNhanVien.Size = new System.Drawing.Size(101, 23);
            this.chkNhanVien.TabIndex = 0;
            this.chkNhanVien.Text = "Nhân Viên";
            this.chkNhanVien.UseVisualStyleBackColor = true;
            this.chkNhanVien.CheckedChanged += new System.EventHandler(this.chkNhanVien_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnLamMoi);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(20, 600);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 105);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = global::GUI_PolyCafe.Properties.Resources.Thêm_2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(8, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(15, 0, 28, 0);
            this.btnThem.Size = new System.Drawing.Size(118, 52);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLamMoi.Image = global::GUI_PolyCafe.Properties.Resources.Làm_mới_2;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(414, 34);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnLamMoi.Size = new System.Drawing.Size(118, 52);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSua.Image = global::GUI_PolyCafe.Properties.Resources.sửa_2;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(147, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnSua.Size = new System.Drawing.Size(118, 52);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = global::GUI_PolyCafe.Properties.Resources.xoá_2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(280, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnXoa.Size = new System.Drawing.Size(118, 52);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.txtMatKhau);
            this.groupBox7.Controls.Add(this.txtEmail);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txtHoVaTen);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtMaNhanVien);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox7.Location = new System.Drawing.Point(20, 192);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(540, 248);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nhập Thông Tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(19, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật Khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(19, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ Và Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(19, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.txtTimKiem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox6.Location = new System.Drawing.Point(20, 116);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(540, 70);
            this.groupBox6.TabIndex = 27;
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTimKiem.Location = new System.Drawing.Point(161, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(356, 27);
            this.txtTimKiem.TabIndex = 16;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.BACKGROUD_Poly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 710);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkQuanLy;
        private System.Windows.Forms.CheckBox chkNhanVien;
        private System.Windows.Forms.CheckBox chkKhongHoatDong;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}