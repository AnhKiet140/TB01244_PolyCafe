using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMainForm1 : Form
    {
        public frmMainForm1()
        {
            InitializeComponent();
            CheckPermission();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelHeThongSubMenu.Visible = false;
            panelDanhMucSubMenu.Visible = false;
            panelBanHangSubMenu.Visible = false;
            panelNhanVienSubMenu.Visible = false;
            panelHuongDanMenuSub.Visible = false;
            panelDoanhThuMenuSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelHeThongSubMenu.Visible == true)
                panelHeThongSubMenu.Visible = false;
            if (panelDanhMucSubMenu.Visible == true)
                panelDanhMucSubMenu.Visible = false;
            if (panelBanHangSubMenu.Visible == true)
                panelBanHangSubMenu.Visible = false;
            if (panelNhanVienSubMenu.Visible == true)
                panelNhanVienSubMenu.Visible = false;
            if (panelHuongDanMenuSub.Visible == true)
                panelHuongDanMenuSub.Visible = false;
            if (panelDoanhThuMenuSub.Visible == true)
                panelDoanhThuMenuSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHeThongSubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan taiKhoan = new frmThongTinTaiKhoan();
            taiKhoan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau reset = new frmDoiMatKhau();
            reset.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn đăng xuất không?",
             "Xác nhận đăng xuất",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            hideSubMenu();
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
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
            hideSubMenu();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMucSubMenu);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLySanPham());
            hideSubMenu();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyLoaiSanPham());
            hideSubMenu();
        }

        private void btnTheLuuDong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyTheLuuDong());
            hideSubMenu();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanHangSubMenu);
        }

        private void btnMenuBanHang_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnPhieuBanHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyPhieuBanHang());
            hideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVienSubMenu);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyNhanVien());
            hideSubMenu();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHuongDanMenuSub);
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGioiThieu());
            hideSubMenu();
        }

        private void btnCachSuDung_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCachSuDung());
            hideSubMenu();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoanhThuMenuSub);
        }

        private void btnTheoNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeNhanVien());
            hideSubMenu();
        }

        private void btnTheoSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeLoaiSP());
            hideSubMenu();
        }

        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelChildFrom.Controls.Add(formChild);
            panelChildFrom.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void CheckPermission()
        {
            if (AuthUtil.IsLogin())
            {
                btnHeThong.Visible = true;
                btnDanhMuc.Visible = true;
                btnBanHang.Visible = true;
                btnNhanVien.Visible = true;
                btnHuongDan.Visible = true;
                btnDoanhThu.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                btnHeThong.Visible = true;
                btnDangXuat.Enabled = false;
                btnThongTin.Enabled = false;
                btnDanhMuc.Visible = false;
                btnBanHang.Visible = false;
                btnNhanVien.Visible = false;
                btnDoanhThu.Visible = false;
            }
        }

        private void VaiTroNhanVien()
        {
            btnDanhMuc.Visible = false;
            btnNhanVien.Visible = false;
            btnDoanhThu.Visible = false;
        }

        private void frmMainForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
