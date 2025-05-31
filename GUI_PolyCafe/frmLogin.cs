using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmLogin : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
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

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            NhanVien nv = busNhanVien.DangNhap(username, password);
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài Khoản đã tạm thời bị vô hiệu hoá, Vui Lòng Liên Hệ Quản Trị Viên");
                    return;
                }
                AuthUtil.user = nv;

                frmMainForm1 main = new frmMainForm1();
                main.Show();
                this.Hide();
            }
        }

        private void chkHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '*';
        }
    }
}
