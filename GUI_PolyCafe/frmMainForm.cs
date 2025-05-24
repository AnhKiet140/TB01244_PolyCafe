using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            CheckPermission();
        }

        private void tsmDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau reset = new frmDoiMatKhau();
            reset.ShowDialog();
        }

        private Form currentFromChild;

        private void OpenChildFromForm(Form child)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            panel1.Tag = child;
            child.BringToFront();
            child.Show();
        }
        //+-----------------+
        // Quan Ly Nhan Vien
        //+-----------------+
        private void tsmQuanLyNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmQuanLyNhanVien());
        }

        private void tsmThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn thoát không?",
             "Xác nhận thoát",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //+-----------------+
        //    Danh Mục
        //+-----------------+
        private void tsmThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmSanPham_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmQuanLySanPham());
        }

        private void tsmLoaiSanPham_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmQuanLyLoaiSanPham());
        }

        private void tsmTheLuuDong_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmQuanLyTheLuuDong());
        }

        //+-----------------+
        //    Bán Hàng
        //+-----------------+
        private void tsmPhieuBanHang_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmQuanLyPhieuBanHang());
        }

        private void tsmMenuBanHang_Click(object sender, EventArgs e)
        {

        }
        //+-----------------+
        //    Hướng Dẫn
        //+-----------------+
        private void tsmCachSuDung_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmCachSuDung());
        }

        private void tsmGioiThieu_Click(object sender, EventArgs e)
        {
            OpenChildFromForm(new frmCachSuDung());
        }

        //+-----------------+
        //    Thống kê
        //+-----------------+

        private void tsmThongKeTheoSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmThongKeTheoNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void CheckPermission()
        {
            if (AuthUtil.IsLogin())
            {
                tsmHeThong.Visible = true;
                tsmDanhMuc.Visible = true;
                tsmBanHang.Visible = true;
                tsmNhanVien.Visible = true;
                tsmHuongDan.Visible = true;
                tsmDoanhThu.Visible = true;
                if(AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                tsmHeThong.Visible=true;
                tsmDangXuat.Enabled = false;
                tsmThongTinTaiKhoan.Enabled = false;
                tsmDanhMuc.Visible=false;
                tsmBanHang.Visible=false;
                tsmNhanVien.Visible=false;
                tsmDoanhThu.Visible=false;
            }
        }

        private void VaiTroNhanVien()
        {
            tsmDanhMuc.Visible = false;
            tsmNhanVien.Visible = false;
            tsmDoanhThu.Visible = false ;
        }
    }
}
