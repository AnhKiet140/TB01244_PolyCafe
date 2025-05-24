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
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmDoiMatKhau : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        private bool changePicture = true;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhanThayDoi_Click(object sender, EventArgs e)
        {
            if(!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ không đúng. Vui lòng nhập lại");
            }
            else
            {
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhauMoi.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu chưa trùng khớp!");
                }
                else
                {
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;

                    if (busNhanVien.ResetMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!!");
                    }
                    else MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại!!");
                }
            }
        }

        private void btnQuayLoai_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtMaNhanVien.Text = AuthUtil.user.MaNhanVien;
                txtTenNhanVien.Text = AuthUtil.user.HoTen;
            }
        }

        private void picMatKhauCu_Click(object sender, EventArgs e)
        {
            if (changePicture)
            {
                txtMatKhauCu.PasswordChar = '*';
                picMatKhauCu.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_2.png");
            }
            else
            {
                txtMatKhauCu.PasswordChar = '\0';
                picMatKhauCu.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_1.png");
            }
            changePicture = !changePicture;
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = '*';
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = '*';
        }

        private void txtXacNhanMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhauMoi.PasswordChar = '*';
        }

        private void picMatKhauMoi_Click(object sender, EventArgs e)
        {
            if (changePicture)
            {
                txtMatKhauMoi.PasswordChar = '*';
                picMatKhauMoi.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_2.png");
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '\0';
                picMatKhauMoi.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_1.png");
            }
            changePicture = !changePicture;
        }

        private void picHienThiMatKhau_Click(object sender, EventArgs e)
        {
            if (changePicture)
            {
                txtXacNhanMatKhauMoi.PasswordChar = '*';
                picHienThiMatKhau.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_2.png");
            }
            else
            {
                txtXacNhanMatKhauMoi.PasswordChar = '\0';
                picHienThiMatKhau.Image = Image.FromFile("D:\\MÔN CHUYÊN NGÀNH\\Hình Dự án mẫu\\eye_1.png");
            }
            changePicture = !changePicture;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
