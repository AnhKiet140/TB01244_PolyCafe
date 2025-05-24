using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();

        public NhanVien DangNhap(string username,string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            return dalNhanVien.getNhanVien(username, password);
        }

        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dalNhanVien.ResetMatKhau(mk,email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienList()
        {
            return dalNhanVien.selectALL();
        }

        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = dalNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã Nhân Viên Không hợp lệ.";
                }
                if (dalNhanVien.checkEmailExits(nv.Email))
                {
                    return "Email đã tồn tại.";
                }
                dalNhanVien.Insert(nv);
                return string.Empty;

            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.deleteNhanVien(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateNhanVien(NhanVien nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.updateNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        // Thêm phương thức tìm kiếm
        public List<NhanVien> SearchNhanVien(string keyword)
        {
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetNhanVienList(); // Trả về toàn bộ danh sách nếu không có từ khóa
                }

                // Sử dụng LINQ để tìm kiếm theo MaNhanVien hoặc HoTen
                List<NhanVien> danhSach = dalNhanVien.selectALL()
                    .Where(nv => nv.MaNhanVien.Contains(keyword) || nv.HoTen.Contains(keyword))
                    .ToList();

                return danhSach;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần (tùy chọn)
                return new List<NhanVien>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }
    }
}
