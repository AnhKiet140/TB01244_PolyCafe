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

namespace GUI_PolyCafe
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien busNhanVien = new BUSNhanVien();
            dgvDanhSachNhanVien.DataSource = null;
            List<NhanVien> danhSach = busNhanVien.GetNhanVienList();

            // Tạo DataTable hiển thị với text thay vì bool
            DataTable table = new DataTable();
            table.Columns.Add("MaNhanVien");
            table.Columns.Add("HoTen");
            table.Columns.Add("Email");
            table.Columns.Add("MatKhau");
            table.Columns.Add("VaiTro");
            table.Columns.Add("TrangThai");

            foreach (var nv in danhSach)
            {
                table.Rows.Add(
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.Email,
                    nv.MatKhau,
                    nv.VaiTro ? "Quản Lý" : "Nhân Viên",
                    nv.TrangThai ? "Hoạt Động" : "Không Hoạt Động"
                );
            }


            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.DataSource = table;
        }

        private void ClearForm()
        {
            txtMaNhanVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNhanVien.Clear();
            txtHoVaTen.Clear();
            txtMatKhau.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            chkNhanVien.Checked = true; // Mặc định chọn "Nhân viên"
        }

        private void dgvDanhSachNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.SelectedRows.Count > 0)
            {
                var row = dgvDanhSachNhanVien.SelectedRows[0];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();


                string vaiTro = row.Cells["VaiTro"].Value?.ToString();
                if (vaiTro == "Qu" || vaiTro == "Quản Lý")
                {
                    chkQuanLy.Checked = true;
                    chkNhanVien.Checked = false;
                }
                else if (vaiTro == "Nh" || vaiTro == "Nhân Viên")
                {
                    chkNhanVien.Checked = true;
                    chkQuanLy.Checked = false;
                }
                else
                {
                    chkQuanLy.Checked = false;
                    chkNhanVien.Checked = false;
                }

                // Xử lý cột Trạng Thái (Hoạt động hoặc Không hoạt động)
                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == "Hoạt động")
                {
                    chkHoatDong.Checked = true;
                    chkKhongHoatDong.Checked = false;
                }
                else if (trangThai == "Không hoạt động")
                {
                    chkKhongHoatDong.Checked = true;
                    chkHoatDong.Checked = false;
                }
                else
                {
                    chkHoatDong.Checked = false;
                    chkKhongHoatDong.Checked = false;
                }
            }
        }

        private void chkNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQuanLy.Checked)
                chkNhanVien.Checked = false;
        }

        private void chkQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhanVien.Checked)
                chkQuanLy.Checked = false;
        }

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhongHoatDong.Checked)
                chkHoatDong.Checked = false;
        }

        private void chkKhongHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoatDong.Checked)
                chkKhongHoatDong.Checked = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            BUSNhanVien bUSNhanVien = new BUSNhanVien();
            try
            {
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoVaTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                bool vaiTro = chkNhanVien.Checked; // True for "Nhân viên", False for "Quản lý"
                bool trangThai = chkHoatDong.Checked; // True for "Hoạt động", False for "Không hoạt động"

                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai
                };

                bUSNhanVien.InsertNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string hoTen = txtHoVaTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool vaiTro;

            if (chkQuanLy.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (chkHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string name = txtHoVaTen.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                if (dgvDanhSachNhanVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNhanVien.SelectedRows[0];
                    maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    name = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSNhanVien bus = new BUSNhanVien();
                string kq = bus.DeleteNhanVien(maNhanVien);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            BUSNhanVien busNhanVien = new BUSNhanVien();
            string searchText = txtTimKiem.Text.Trim(); // Giả định có TextBox tên txtTimKiem

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachNhanVien(); // Tải lại toàn bộ danh sách nếu không có từ khóa
                return;
            }

            List<NhanVien> danhSach = busNhanVien.SearchNhanVien(searchText); // Giả định có phương thức SearchNhanVien

            DataTable table = new DataTable();
            table.Columns.Add("MaNhanVien");
            table.Columns.Add("HoTen");
            table.Columns.Add("Email");
            table.Columns.Add("MatKhau");
            table.Columns.Add("VaiTro");
            table.Columns.Add("TrangThai");

            foreach (var nv in danhSach)
            {
                table.Rows.Add(
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.Email,
                    nv.MatKhau,
                    nv.VaiTro ? "Quản Lý" : "Nhân Viên",
                    nv.TrangThai ? "Hoạt Động" : "Không Hoạt Động"
                );
            }

            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.DataSource = table;

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
