namespace GUI_PolyCafe
{
    partial class frmCachSuDung
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmHuongDan_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHuongDan_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHuongDan = new System.Windows.Forms.Panel();
            this.tsmHuonDan_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHuonDan_1,
            this.tsmHuongDan_2,
            this.tsmHuongDan_3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmHuongDan_2
            // 
            this.tsmHuongDan_2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmHuongDan_2.Image = global::GUI_PolyCafe.Properties.Resources.question_mark1;
            this.tsmHuongDan_2.Name = "tsmHuongDan_2";
            this.tsmHuongDan_2.Size = new System.Drawing.Size(316, 23);
            this.tsmHuongDan_2.Text = "HƯỚNG DẪN SỬ DỤNG CÁC CHỨC NĂNG";
            this.tsmHuongDan_2.Click += new System.EventHandler(this.tsmHuongDan_2_Click);
            // 
            // tsmHuongDan_3
            // 
            this.tsmHuongDan_3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmHuongDan_3.Image = global::GUI_PolyCafe.Properties.Resources.question_mark1;
            this.tsmHuongDan_3.Name = "tsmHuongDan_3";
            this.tsmHuongDan_3.Size = new System.Drawing.Size(221, 23);
            this.tsmHuongDan_3.Text = "CÔNG DỤNG CỦA CÁC NÚT";
            this.tsmHuongDan_3.Click += new System.EventHandler(this.tsmHuongDan_3_Click);
            // 
            // panelHuongDan
            // 
            this.panelHuongDan.Location = new System.Drawing.Point(2, 31);
            this.panelHuongDan.Name = "panelHuongDan";
            this.panelHuongDan.Size = new System.Drawing.Size(1258, 734);
            this.panelHuongDan.TabIndex = 1;
            // 
            // tsmHuonDan_1
            // 
            this.tsmHuonDan_1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsmHuonDan_1.Image = global::GUI_PolyCafe.Properties.Resources.question_mark1;
            this.tsmHuonDan_1.Name = "tsmHuonDan_1";
            this.tsmHuonDan_1.Size = new System.Drawing.Size(303, 23);
            this.tsmHuonDan_1.Text = "HƯỚNG DẪN SỬ DỤNG Ở TRANG MAIN";
            this.tsmHuonDan_1.Click += new System.EventHandler(this.tsmHuonDan_1_Click);
            // 
            // frmCachSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 766);
            this.Controls.Add(this.panelHuongDan);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCachSuDung";
            this.Text = "frmCachSuDung";
            this.Load += new System.EventHandler(this.frmCachSuDung_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmHuonDan_1;
        private System.Windows.Forms.ToolStripMenuItem tsmHuongDan_2;
        private System.Windows.Forms.ToolStripMenuItem tsmHuongDan_3;
        private System.Windows.Forms.Panel panelHuongDan;
    }
}