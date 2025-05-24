namespace GUI_PolyCafe
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTheLuuDong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhieuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCachSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKeTheoSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKeTheoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHeThong,
            this.tsmDanhMuc,
            this.tsmBanHang,
            this.tsmNhanVien,
            this.tsmHuongDan,
            this.tsmDoanhThu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1488, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmHeThong
            // 
            this.tsmHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDoiMatKhau,
            this.tsmThongTinTaiKhoan,
            this.tsmDangXuat,
            this.tsmThoat});
            this.tsmHeThong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmHeThong.Name = "tsmHeThong";
            this.tsmHeThong.Size = new System.Drawing.Size(94, 23);
            this.tsmHeThong.Text = "HỆ THỐNG";
            // 
            // tsmDoiMatKhau
            // 
            this.tsmDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmDoiMatKhau.Name = "tsmDoiMatKhau";
            this.tsmDoiMatKhau.Size = new System.Drawing.Size(213, 24);
            this.tsmDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.tsmDoiMatKhau.Click += new System.EventHandler(this.tsmDoiMatKhau_Click);
            // 
            // tsmThongTinTaiKhoan
            // 
            this.tsmThongTinTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmThongTinTaiKhoan.Name = "tsmThongTinTaiKhoan";
            this.tsmThongTinTaiKhoan.Size = new System.Drawing.Size(213, 24);
            this.tsmThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.tsmThongTinTaiKhoan.Click += new System.EventHandler(this.tsmThongTinTaiKhoan_Click);
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.Size = new System.Drawing.Size(213, 24);
            this.tsmDangXuat.Text = "Đăng Xuất";
            // 
            // tsmThoat
            // 
            this.tsmThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(213, 24);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsmThoat_Click);
            // 
            // tsmDanhMuc
            // 
            this.tsmDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSanPham,
            this.tsmLoaiSanPham,
            this.tsmTheLuuDong});
            this.tsmDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmDanhMuc.Name = "tsmDanhMuc";
            this.tsmDanhMuc.Size = new System.Drawing.Size(99, 23);
            this.tsmDanhMuc.Text = "DANH MỤC";
            // 
            // tsmSanPham
            // 
            this.tsmSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmSanPham.Name = "tsmSanPham";
            this.tsmSanPham.Size = new System.Drawing.Size(176, 24);
            this.tsmSanPham.Text = "Sản Phẩm";
            this.tsmSanPham.Click += new System.EventHandler(this.tsmSanPham_Click);
            // 
            // tsmLoaiSanPham
            // 
            this.tsmLoaiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmLoaiSanPham.Name = "tsmLoaiSanPham";
            this.tsmLoaiSanPham.Size = new System.Drawing.Size(176, 24);
            this.tsmLoaiSanPham.Text = "Loại Sản Phẩm";
            this.tsmLoaiSanPham.Click += new System.EventHandler(this.tsmLoaiSanPham_Click);
            // 
            // tsmTheLuuDong
            // 
            this.tsmTheLuuDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmTheLuuDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmTheLuuDong.Name = "tsmTheLuuDong";
            this.tsmTheLuuDong.Size = new System.Drawing.Size(176, 24);
            this.tsmTheLuuDong.Text = "Thẻ Lưu Động";
            this.tsmTheLuuDong.Click += new System.EventHandler(this.tsmTheLuuDong_Click);
            // 
            // tsmBanHang
            // 
            this.tsmBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmBanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPhieuBanHang,
            this.tsmMenuBanHang});
            this.tsmBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmBanHang.Name = "tsmBanHang";
            this.tsmBanHang.Size = new System.Drawing.Size(97, 23);
            this.tsmBanHang.Text = "BÁN HÀNG";
            // 
            // tsmPhieuBanHang
            // 
            this.tsmPhieuBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmPhieuBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmPhieuBanHang.Name = "tsmPhieuBanHang";
            this.tsmPhieuBanHang.Size = new System.Drawing.Size(184, 24);
            this.tsmPhieuBanHang.Text = "Phiếu Bán Hàng";
            this.tsmPhieuBanHang.Click += new System.EventHandler(this.tsmPhieuBanHang_Click);
            // 
            // tsmMenuBanHang
            // 
            this.tsmMenuBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmMenuBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmMenuBanHang.Name = "tsmMenuBanHang";
            this.tsmMenuBanHang.Size = new System.Drawing.Size(184, 24);
            this.tsmMenuBanHang.Text = "Menu Bán Hàng";
            this.tsmMenuBanHang.Click += new System.EventHandler(this.tsmMenuBanHang_Click);
            // 
            // tsmNhanVien
            // 
            this.tsmNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanLyNhanVien});
            this.tsmNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmNhanVien.Name = "tsmNhanVien";
            this.tsmNhanVien.Size = new System.Drawing.Size(99, 23);
            this.tsmNhanVien.Text = "NHÂN VIÊN";
            // 
            // tsmQuanLyNhanVien
            // 
            this.tsmQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmQuanLyNhanVien.Name = "tsmQuanLyNhanVien";
            this.tsmQuanLyNhanVien.Size = new System.Drawing.Size(204, 24);
            this.tsmQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.tsmQuanLyNhanVien.Click += new System.EventHandler(this.tsmQuanLyNhanVien_Click_1);
            // 
            // tsmHuongDan
            // 
            this.tsmHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmHuongDan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCachSuDung,
            this.tsmGioiThieu});
            this.tsmHuongDan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmHuongDan.Name = "tsmHuongDan";
            this.tsmHuongDan.Size = new System.Drawing.Size(110, 23);
            this.tsmHuongDan.Text = "HƯỚNG DẪN";
            // 
            // tsmCachSuDung
            // 
            this.tsmCachSuDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmCachSuDung.Name = "tsmCachSuDung";
            this.tsmCachSuDung.Size = new System.Drawing.Size(170, 24);
            this.tsmCachSuDung.Text = "Cách Sử Dụng";
            this.tsmCachSuDung.Click += new System.EventHandler(this.tsmCachSuDung_Click);
            // 
            // tsmGioiThieu
            // 
            this.tsmGioiThieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmGioiThieu.Name = "tsmGioiThieu";
            this.tsmGioiThieu.Size = new System.Drawing.Size(170, 24);
            this.tsmGioiThieu.Text = "Giới Thiệu";
            this.tsmGioiThieu.Click += new System.EventHandler(this.tsmGioiThieu_Click);
            // 
            // tsmDoanhThu
            // 
            this.tsmDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmDoanhThu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThongKeTheoSanPham,
            this.tsmThongKeTheoNhanVien});
            this.tsmDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmDoanhThu.Name = "tsmDoanhThu";
            this.tsmDoanhThu.Size = new System.Drawing.Size(107, 23);
            this.tsmDoanhThu.Text = "DOANH THU";
            // 
            // tsmThongKeTheoSanPham
            // 
            this.tsmThongKeTheoSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmThongKeTheoSanPham.Name = "tsmThongKeTheoSanPham";
            this.tsmThongKeTheoSanPham.Size = new System.Drawing.Size(250, 24);
            this.tsmThongKeTheoSanPham.Text = "Thống Kê Theo Sản Phẩm";
            this.tsmThongKeTheoSanPham.Click += new System.EventHandler(this.tsmThongKeTheoSanPham_Click);
            // 
            // tsmThongKeTheoNhanVien
            // 
            this.tsmThongKeTheoNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.tsmThongKeTheoNhanVien.Name = "tsmThongKeTheoNhanVien";
            this.tsmThongKeTheoNhanVien.Size = new System.Drawing.Size(250, 24);
            this.tsmThongKeTheoNhanVien.Text = "Thống Kê Theo Nhân Viên";
            this.tsmThongKeTheoNhanVien.Click += new System.EventHandler(this.tsmThongKeTheoNhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.Main_PoLy;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 855);
            this.panel1.TabIndex = 2;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1488, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1504, 897);
            this.MinimumSize = new System.Drawing.Size(1504, 897);
            this.Name = "frmMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsmDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsmThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmTheLuuDong;
        private System.Windows.Forms.ToolStripMenuItem tsmDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem tsmHuongDan;
        private System.Windows.Forms.ToolStripMenuItem tsmPhieuBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmCachSuDung;
        private System.Windows.Forms.ToolStripMenuItem tsmGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKeTheoSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKeTheoNhanVien;
        private System.Windows.Forms.Panel panel1;
    }
}