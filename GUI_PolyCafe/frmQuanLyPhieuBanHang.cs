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
    public partial class frmQuanLyPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        public frmQuanLyPhieuBanHang()
        {
            InitializeComponent();
        }

        private void ClearForm(string msThe)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaPhieu.Clear();
            cboNhanVienBH.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbChoThanhToan.Enabled = true;
            rdbDaThanhToan.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbChoThanhToan.Checked = true;
        }

        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboNhanVienBH.Enabled = false;
                }
                cboNhanVienBH.DataSource = dsLoai;
                cboNhanVienBH.ValueMember = "MaNhanVien";
                cboNhanVienBH.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaTheLuuDong.DataSource = lst;
            cboMaTheLuuDong.ValueMember = "MaThe";
            cboMaTheLuuDong.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BUSPhieuBanHang busPhieuBanHang = new BUSPhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboNhanVienBH.Enabled = false;
            }
            dgrDanhSachPhieu.DataSource = lst;


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút
            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!dgrDanhSachPhieu.Columns.Contains("ThanhToan"))
            {
                dgrDanhSachPhieu.Columns.Add(buttonColumn);
            }
            dgrDanhSachPhieu.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgrDanhSachPhieu.RowTemplate.Height = 50;

            dgrDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgrDanhSachPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)dgrDanhSachPhieu.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cboMaTheLuuDong.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in cboNhanVienBH.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            frmChiTietPhieu frmChiTiet = new frmChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();
        }

        private void dgrDanhSachPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoadingTheLuuDongData = true;
            DataGridViewRow row = dgrDanhSachPhieu.Rows[e.RowIndex];
            cboMaTheLuuDong.SelectedValue = row.Cells["MaThe"].Value.ToString();
            cboNhanVienBH.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdbDaThanhToan.Checked = true;
                rdbDaThanhToan.Enabled = false;
                rdbChoThanhToan.Enabled = false;
                cboNhanVienBH.Enabled = false;
                dtpNgayTao.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            else
            {
                rdbDaThanhToan.Checked = false;
                rdbDaThanhToan.Enabled = true;
                rdbChoThanhToan.Enabled = true;
                cboNhanVienBH.Enabled = true;
                rdbChoThanhToan.Checked = true;
                rdbChoThanhToan.Enabled = true;
                dtpNgayTao.Enabled = true;
                // Bật nút "Sửa"
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maNhanVien = cboNhanVienBH.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdbChoThanhToan.Checked)
            {
                trangThai = false;
            }
            else
            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUSPhieuBanHang bus = new BUSPhieuBanHang();
            string result = bus.InsertPhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = cboNhanVienBH.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdbChoThanhToan.Checked)
            {
                trangThai = false;
            }
            else


            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUSPhieuBanHang bus = new BUSPhieuBanHang();
            string result = bus.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string chuSoHuu = cboMaTheLuuDong.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (dgrDanhSachPhieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachPhieu.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSPhieuBanHang bus = new BUSPhieuBanHang();
                string kq = bus.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    cboMaTheLuuDong.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void frmQuanLyPhieuBanHang_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachPhieu(""); // Reload full list if no search term
                return;
            }

            BUSPhieuBanHang busPhieuBanHang = new BUSPhieuBanHang();
            List<PhieuBanHang> danhSach = busPhieuBanHang.GetListPhieuBanHang(null);

            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Không thể tải danh sách phiếu bán hàng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AuthUtil.user.VaiTro)
            {
                danhSach = danhSach.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
            }

            var filteredList = danhSach.Where(pbh =>
                pbh.MaPhieu.ToLower().Contains(searchText.ToLower()) ||
                pbh.MaThe.ToLower().Contains(searchText.ToLower()) ||
                pbh.ChuSoHuu.ToLower().Contains(searchText.ToLower()) ||
                pbh.MaNhanVien.ToLower().Contains(searchText.ToLower()) ||
                pbh.HoTen.ToLower().Contains(searchText.ToLower())).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("MaPhieu");
            table.Columns.Add("MaThe");
            table.Columns.Add("ChuSoHuu");
            table.Columns.Add("MaNhanVien");
            table.Columns.Add("HoTen");
            table.Columns.Add("NgayTao");
            table.Columns.Add("TrangThai");

            foreach (var pbh in filteredList)
            {
                table.Rows.Add(
                    pbh.MaPhieu,
                    pbh.MaThe,
                    pbh.ChuSoHuu,
                    pbh.MaNhanVien,
                    pbh.HoTen,
                    pbh.NgayTao.ToString("dd/MM/yyyy"),
                    pbh.TrangThai ? "Hoạt động" : "Ngưng hoạt động"
                );
            }

            dgrDanhSachPhieu.DataSource = null;
            dgrDanhSachPhieu.DataSource = table;

            if (!dgrDanhSachPhieu.Columns.Contains("ThanhToan"))
            {
                DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
                buttonColumn.Name = "ThanhToan";
                buttonColumn.HeaderText = "Thanh Toán";
                buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
                buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;
                buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dgrDanhSachPhieu.Columns.Add(buttonColumn);
            }
            dgrDanhSachPhieu.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgrDanhSachPhieu.RowTemplate.Height = 50;

            dgrDanhSachPhieu.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
            dgrDanhSachPhieu.Columns["MaThe"].HeaderText = "Mã Thẻ";
            dgrDanhSachPhieu.Columns["ChuSoHuu"].HeaderText = "Chủ Sở Hữu";
            dgrDanhSachPhieu.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgrDanhSachPhieu.Columns["HoTen"].HeaderText = "Họ Tên";
            dgrDanhSachPhieu.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgrDanhSachPhieu.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgrDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu bán hàng nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
