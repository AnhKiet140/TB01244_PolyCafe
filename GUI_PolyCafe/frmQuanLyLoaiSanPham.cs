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
    public partial class frmQuanLyLoaiSanPham : Form
    {
        public frmQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        private void dgvLoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();
            string tenLoai = txtTenLoai.Text.Trim();
            string ghiChu = txtGhiChuSP.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            LoaiSanPham loai = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BUSLoaiSanPham bus = new BUSLoaiSanPham();
            string result = bus.InsertLoaiSanPham(loai);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();
            string tenLoai = txtTenLoai.Text.Trim();
            string ghiChu = txtGhiChuSP.Text.Trim();
            if (string.IsNullOrEmpty(maLoai))
            {
                if (dgvLoaiSanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvLoaiSanPham.SelectedRows[0];
                    maLoai = selectedRow.Cells["MaLoai"].Value.ToString();
                    tenLoai = selectedRow.Cells["TenLoai"].Value.ToString();
                    ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin loại sản phẩm cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {maLoai} - {tenLoai}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSLoaiSanPham bus = new BUSLoaiSanPham();
                string kq = bus.DeleteLoaiSanPham(maLoai);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin loại sản phẩm {maLoai} - {tenLoai} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSP();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaLoai.Clear();
            txtGhiChuSP.Clear();
            txtTenLoai.Clear();
        }

        private void LoadDanhSachLoaiSP()
        {
            BUSLoaiSanPham busLoaiSp = new BUSLoaiSanPham();
            dgvLoaiSanPham.DataSource = null;
            dgvLoaiSanPham.DataSource = busLoaiSp.GetLoaiSanPhamList();
            dgvLoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvLoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgvLoaiSanPham.Columns["GhiChu"].HeaderText = "Ghi Chú";

            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
