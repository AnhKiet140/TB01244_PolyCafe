﻿using System;
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
    public partial class frmQuanLyTheLuuDong : Form
    {
        public frmQuanLyTheLuuDong()
        {
            InitializeComponent();
        }

        private void LoadDanhSachTheLuuDong()
        {
            BUSTheLuuDong bUSTheLuuDong = new BUSTheLuuDong();
            dgvTheLuuDong.DataSource = null;
            List<TheLuuDong> danhSach = bUSTheLuuDong.GetTheLuuDongList();

            DataTable table = new DataTable();
            table.Columns.Add("MaThe");
            table.Columns.Add("ChuSoHuu");
            table.Columns.Add("TrangThai");

            foreach (var the in danhSach)
            {
                table.Rows.Add(
                    the.MaThe,
                    the.ChuSoHuu,
                    the.TrangThai ? "Hoạt Động" : "Không Hoạt Động"
                );
            }

            dgvTheLuuDong.DataSource = table;
        }

        private void ClearForm()
        {
            txtMaThe.Enabled = false; // MaThe is auto-generated for inserts
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            chkHoatDong.Checked = true; // Default to "Hoạt Động"
            chkKhongHoatDong.Checked = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtTimKiem.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            string searchText = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachTheLuuDong(); // Reload full list if no search term
                return;
            }

            List<TheLuuDong> danhSach = busTheLuuDong.GetTheLuuDongList();
            var filteredList = danhSach.Where(the =>
                the.MaThe.ToLower().Contains(searchText.ToLower()) ||
                the.ChuSoHuu.ToLower().Contains(searchText.ToLower())).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("MaThe");
            table.Columns.Add("ChuSoHuu");
            table.Columns.Add("TrangThai");

            foreach (var the in filteredList)
            {
                table.Rows.Add(
                    the.MaThe,
                    the.ChuSoHuu,
                    the.TrangThai ? "Hoạt Động" : "Không Hoạt Động"
                );
            }

            dgvTheLuuDong.DataSource = null; // Clear existing data
            dgvTheLuuDong.DataSource = table;

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thẻ nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void frmQuanLyTheLuuDong_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachTheLuuDong();
        }

        private void dgvTheLuuDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLuuDong.SelectedRows.Count > 0)
            {
                var row = dgvTheLuuDong.SelectedRows[0];

                txtMaThe.Text = row.Cells["MaThe"].Value?.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value?.ToString();
                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                chkHoatDong.Checked = trangThai == "Hoạt Động";
                chkKhongHoatDong.Checked = trangThai == "Không Hoạt Động";

                txtMaThe.Enabled = false; // Disable MaThe for editing
            }
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

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhSachTheLuuDong(); // Reload full list if no search term
                return;
            }

            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            List<TheLuuDong> danhSach = busTheLuuDong.GetTheLuuDongList();

            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Không thể tải danh sách thẻ lưu động!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filteredList = danhSach.Where(the =>
                the.MaThe.ToLower().Contains(searchText.ToLower()) ||
                the.ChuSoHuu.ToLower().Contains(searchText.ToLower())).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("MaThe");
            table.Columns.Add("ChuSoHuu");
            table.Columns.Add("TrangThai");

            foreach (var the in filteredList)
            {
                table.Rows.Add(
                    the.MaThe,
                    the.ChuSoHuu,
                    the.TrangThai ? "Hoạt động" : "Ngưng hoạt động"
                );
            }

            dgvTheLuuDong.DataSource = null;
            dgvTheLuuDong.DataSource = table;

            dgvTheLuuDong.Columns["MaThe"].HeaderText = "Mã Thẻ";
            dgvTheLuuDong.Columns["ChuSoHuu"].HeaderText = "Chủ Sở Hữu";
            dgvTheLuuDong.Columns["TrangThai"].HeaderText = "Trạng Thái";

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thẻ lưu động nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            try
            {
                string chuSoHuu = txtChuSoHuu.Text.Trim();
                bool trangThai = chkHoatDong.Checked;

                if (string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Vui lòng nhập tên chủ sở hữu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLuuDong the = new TheLuuDong
                {
                    ChuSoHuu = chuSoHuu,
                    TrangThai = trangThai
                    // MaThe is generated by BLL
                };

                string result = busTheLuuDong.InsertTheLuuDong(the);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm thẻ lưu động thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachTheLuuDong();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            try
            {
                string maThe = txtMaThe.Text.Trim();
                string chuSoHuu = txtChuSoHuu.Text.Trim();
                bool trangThai = chkHoatDong.Checked;

                if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLuuDong the = new TheLuuDong
                {
                    MaThe = maThe,
                    ChuSoHuu = chuSoHuu,
                    TrangThai = trangThai
                };

                string result = busTheLuuDong.UpdateTheLuuDong(the);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thẻ lưu động thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachTheLuuDong();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            if (string.IsNullOrEmpty(maThe))
            {
                if (dgvTheLuuDong.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvTheLuuDong.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ để xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ {maThe} - {chuSoHuu}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
                string kq = busTheLuuDong.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thẻ {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachTheLuuDong();
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
            LoadDanhSachTheLuuDong();
        }
    }
}
