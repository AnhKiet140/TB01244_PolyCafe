using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmMainFrom1 : Form
    {
        public frmMainFrom1()
        {
            InitializeComponent();
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

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMucSubMenu);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnTheLuuDong_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanHangSubMenu);
        }

        private void btnPhieuBanHang_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnMenuBanHang_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVienSubMenu);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHuongDanMenuSub);
        }

        private void btnCachSuDung_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoanhThuMenuSub);
        }

        private void btnThongKeTheoNhanVien_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private void btnThongKeTheoSanPham_Click(object sender, EventArgs e)
        {
            //..
            // Your code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFrom.Controls.Add(childForm);
            panelChildFrom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
