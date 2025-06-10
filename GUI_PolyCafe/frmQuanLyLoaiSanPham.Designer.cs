namespace GUI_PolyCafe
{
    partial class frmQuanLyLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLoaiSanPham));
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChuSP = new System.Windows.Forms.RichTextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(6, 20);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(596, 533);
            this.dgvLoaiSanPham.TabIndex = 8;
            this.dgvLoaiSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellContentClick);
            this.dgvLoaiSanPham.SelectionChanged += new System.EventHandler(this.dgvLoaiSanPham_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvLoaiSanPham);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(568, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 567);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách";
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
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.txtTimKiem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox6.Location = new System.Drawing.Point(12, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(550, 70);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTimKiem.Location = new System.Drawing.Point(161, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(371, 27);
            this.txtTimKiem.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtGhiChuSP);
            this.groupBox2.Controls.Add(this.txtTenLoai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaLoai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 248);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Thông Tin";
            // 
            // txtGhiChuSP
            // 
            this.txtGhiChuSP.Location = new System.Drawing.Point(150, 144);
            this.txtGhiChuSP.Name = "txtGhiChuSP";
            this.txtGhiChuSP.Size = new System.Drawing.Size(382, 86);
            this.txtGhiChuSP.TabIndex = 12;
            this.txtGhiChuSP.Text = "";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTenLoai.Location = new System.Drawing.Point(150, 88);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(382, 26);
            this.txtTenLoai.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi Chú";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaLoai.Location = new System.Drawing.Point(150, 36);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(382, 26);
            this.txtMaLoai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Loại";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 481);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 105);
            this.groupBox3.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(313, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 54);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quản Lý Theo Loại Sản Phẩm";
            // 
            // frmQuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.BACKGROUD_Poly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyLoaiSanPham";
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiSanPham_Load);
            this.Resize += new System.EventHandler(this.frmQuanLyLoaiSanPham_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtGhiChuSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
    }
}