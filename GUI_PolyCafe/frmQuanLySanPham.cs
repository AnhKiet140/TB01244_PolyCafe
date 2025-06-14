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

namespace GUI_PolyCafe
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
            txtDonGia.Mask = "0000000000";
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void ClearForm()
        {
            btnSua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            rdbHoatDong.Checked = true;
            pbHinhAnh.Image = null;
        }

        private void LoadDanhSachSanPham()
        {
            BUSSanPham busSanPham = new BUSSanPham();
            dgrDanhSachSP.DataSource = null;
            List<SanPham> danhSach = busSanPham.GetSanPhamList();

            // Tạo DataTable hiển thị với text thay vì bool
            DataTable table = new DataTable();
            table.Columns.Add("MaSanPham");
            table.Columns.Add("TenSanPham");
            table.Columns.Add("DonGia");
            table.Columns.Add("MaLoai");
            table.Columns.Add("TrangThai");

            foreach (var sp in danhSach)
            {
                table.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    sp.DonGia,
                    sp.MaLoai,
                    sp.TrangThai ? "Bán" : "Ngưng Bán"
                );
            }

            dgrDanhSachSP.DataSource = null;
            dgrDanhSachSP.DataSource = table;

            dgrDanhSachSP.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgrDanhSachSP.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgrDanhSachSP.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgrDanhSachSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgrDanhSachSP.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BUSLoaiSanPham bUSLoaiSanPham = new BUSLoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdbHoatDong.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = ""
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUSSanPham bUSSanPham = new BUSSanPham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdbHoatDong.Checked;
                string maSP = txtMaSanPham.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUSSanPham bUSSanPham = new BUSSanPham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoiSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (dgrDanhSachSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachSP.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSanPham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSSanPham bus = new BUSSanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }

        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDeActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void dgrDanhSachSP_SelectionChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgrDanhSachSP.SelectedRows.Count > 0)
        //        {
        //            DataGridViewRow row = dgrDanhSachSP.SelectedRows[0];
        //            string maSanPham = row.Cells["MaSanPham"].Value?.ToString() ?? "N/A";
        //            string tenSanPham = row.Cells["TenSanPham"].Value?.ToString() ?? "N/A";
        //            string trangThai = row.Cells["trangThai"].Value?.ToString() ?? "N/A";
        //            bool isHoatDong = trangThai == "Bán"; // Map "Bán" to true, "Ngưng bán" to false

        //            MessageBox.Show($"Mã Sản Phẩm: {maSanPham}\nTên Sản Phẩm: {tenSanPham}\nTrạng Thái: {trangThai}", "Thông báo",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Add the requested button enable/disable logic
        //            btnThem.Enabled = false;
        //            btnSua.Enabled = true;
        //            btnXoa.Enabled = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadSanPham_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdbHoatDong.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string savePath = ImageUtil.SaveImage(pbHinhAnh.Image, "Uploads");

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savePath
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUSSanPham bUSSanPham = new BUSSanPham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdbHoatDong.Checked;
                string maSP = txtMaSanPham.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUSSanPham bUSSanPham = new BUSSanPham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (dgrDanhSachSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachSP.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSanPham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSSanPham bus = new BUSSanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void dgrDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrDanhSachSP.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            cboLoaiSanPham.SelectedValue = row.Cells["MaLoai"].Value.ToString();

            string path = Path.Combine(Application.StartupPath,
                row.Cells["HinhAnh"].Value.ToString());
            pbHinhAnh.Image = ImageUtil.LoadImage(path);
            pbHinhAnh.Tag = path;

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdbHoatDong.Checked = true;
            }
            else
            {
                rdbNgungBan.Checked = true;
            }
            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgrDanhSachSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrDanhSachSP.SelectedRows.Count > 0)
            {
                var row = dgrDanhSachSP.SelectedRows[0];

                txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                cboLoaiSanPham.Text = row.Cells["MaLoai"].Value?.ToString();


                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == "Qu" || trangThai == "Quản Lý")
                {
                    rdbHoatDong.Checked = true;
                    rdbNgungBan.Checked = false;
                }
                else if (trangThai == "Nh" || trangThai == "Nhân Viên")
                {
                    rdbHoatDong.Checked = true;
                    rdbNgungBan.Checked = false;
                }
                else
                {
                    rdbHoatDong.Checked = false;
                    rdbNgungBan.Checked = false;
                }
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachSanPham(); // Reload full list if no search term
                return;
            }

            BUSSanPham busSanPham = new BUSSanPham();
            List<SanPham> danhSach = busSanPham.GetSanPhamList();

            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Không thể tải danh sách sản phẩm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filteredList = danhSach.Where(sp =>
                sp.MaSanPham.ToLower().Contains(searchText.ToLower()) ||
                sp.TenSanPham.ToLower().Contains(searchText.ToLower()) ||
                sp.MaLoai.ToLower().Contains(searchText.ToLower())).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("MaSanPham");
            table.Columns.Add("TenSanPham");
            table.Columns.Add("DonGia");
            table.Columns.Add("MaLoai");
            table.Columns.Add("TrangThai");

            foreach (var sp in filteredList)
            {
                table.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    sp.DonGia,
                    sp.MaLoai,
                    sp.TrangThai ? "Bán" : "Ngưng Bán"
                );
            }

            dgrDanhSachSP.DataSource = null; // Clear existing data
            dgrDanhSachSP.DataSource = table;

            dgrDanhSachSP.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgrDanhSachSP.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgrDanhSachSP.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgrDanhSachSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgrDanhSachSP.Columns["TrangThai"].HeaderText = "Trạng Thái";

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
