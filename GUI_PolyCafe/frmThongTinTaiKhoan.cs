using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;
using GUI_PolyCafe.Helper;

namespace GUI_PolyCafe
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            string maNhanVien = "NV006"; // Thay bằng mã nhân viên động nếu cần (ví dụ: từ session)

            // Kiểm tra mã nhân viên có hợp lệ không
            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Mã nhân viên không tồn tại. Vui lòng kiểm tra lại.",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                // Gọi phương thức từ tầng BLL để lấy thông tin nhân viên
                BUSThongTin bus = new BUSThongTin();
                ThongTin thongTin = bus.GetThongTinByMa(maNhanVien);

                if (thongTin != null)
                {
                    // Debug: In thông tin để kiểm tra
                    Console.WriteLine($"MaNhanVien: {thongTin.MaNhanVien}");
                    Console.WriteLine($"HoTen: {thongTin.HoTen}");
                    Console.WriteLine($"Email: {thongTin.Email}");

                    // Điền thông tin vào các trường văn bản trên form
                    txtMaNhanVien.Text = thongTin.MaNhanVien ?? string.Empty;
                    txtTenNhanVien.Text = thongTin.HoTen ?? string.Empty;
                    txtVaiTro.Text = thongTin.VaiTro ? "Quản lý" : "Nhân viên";
                    txtTrangThai.Text = thongTin.TrangThai ? "Hoạt động" : "Ngưng hoạt động";
                    txtEmail.Text = thongTin.Email ?? string.Empty;

                    // Xử lý ảnh nếu có
                    if (thongTin.HinhAnh != null && thongTin.HinhAnh.Length > 0)
                    {
                        pbHinhAnh.Image = ImageUtil.ByteArrayToImage(thongTin.HinhAnh);
                        pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pbHinhAnh.Image = ImageUtil.LoadImage(@"D:\MÔN CHUYÊN NGÀNH\Dự án mẫu (UDPM.NET)\Picture\banker-flat-icon-png_238399"); // Thay bằng đường dẫn thực tế
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy thông tin cho mã nhân viên: {maNhanVien}",
                                   "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Đặt các trường về rỗng khi không tìm thấy dữ liệu
                    txtMaNhanVien.Text = string.Empty;
                    txtTenNhanVien.Text = string.Empty;
                    txtVaiTro.Text = string.Empty;
                    txtTrangThai.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    pbHinhAnh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message,
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Đặt các trường về rỗng khi có lỗi
                txtMaNhanVien.Text = string.Empty;
                txtTenNhanVien.Text = string.Empty;
                txtVaiTro.Text = string.Empty;
                txtTrangThai.Text = string.Empty;
                txtEmail.Text = string.Empty;
                pbHinhAnh.Image = null;
            }
        }

        private void btnUploadSanPham_Click(object sender, EventArgs e)
        {
            // Mở OpenFileDialog để chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png",
                Title = "Chọn ảnh nhân viên"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    Image img = ImageUtil.LoadImage(imagePath);
                    if (img != null)
                    {
                        // Lưu ảnh vào thư mục và lấy đường dẫn
                        string destinationFolder = @"C:\PolyCafe\Images"; // Thay bằng thư mục lưu ảnh thực tế
                        string newImagePath = ImageUtil.SaveImage(img, destinationFolder);

                        // Chuyển đổi ảnh thành byte[] để hiển thị tạm thời
                        byte[] imageData = ImageUtil.ImageToByteArray(img);
                        pbHinhAnh.Image = ImageUtil.ByteArrayToImage(imageData);
                        pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;

                        // Lưu ý: Vì bạn không muốn thêm/sửa/xóa, đoạn cập nhật database bị comment
                        // Để lưu vào database, cần gọi BLL để cập nhật HinhAnh
                        // string maNhanVien = txtMaNhanVien.Text;
                        // BUSThongTin bus = new BUSThongTin();
                        // bus.UpdateHinhAnh(maNhanVien, imageData); // Cần thêm phương thức này
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien))
                return;

            try
            {
                BUSThongTin dal = new BUSThongTin(); // Hoặc BUSThongTin nếu bạn dùng kiến trúc 3 lớp
                ThongTin nv = dal.GetThongTinByMa(maNhanVien);

                if (nv != null)
                {
                    txtTenNhanVien.Text = nv.HoTen;
                    // Hiển thị TrangThai dưới dạng chuỗi dễ hiểu
                    txtTrangThai.Text = nv.TrangThai ? "Hoạt động" : "Ngưng hoạt động";
                    txtEmail.Text = nv.Email;

                    if (nv.HinhAnh != null && nv.HinhAnh.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(nv.HinhAnh))
                        {
                            pbHinhAnh.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbHinhAnh.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
