using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSThongTin
    {
        private DALThongTin dalThongTin = new DALThongTin();

        /// <summary>
        /// Trả về thông tin nhân viên theo mã nhân viên
        /// </summary>
        public ThongTin GetThongTinByMa(string maNhanVien)
        {
            if (string.IsNullOrWhiteSpace(maNhanVien))
            {
                return null;
            }
            try
            {
                return dalThongTin.GetThongTinByMa(maNhanVien);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin nhân viên: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Kiểm tra đăng nhập theo email và mật khẩu
        /// </summary>
        public ThongTin KiemTraDangNhap(string email, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau))
                return null;

            try
            {
                List<ThongTin> list = dalThongTin.SelectAll();
                ThongTin result = list.FirstOrDefault(t => t.Email == email && t.MatKhau == matKhau);
                if (result != null)
                    Console.WriteLine($"Đăng nhập thành công cho MaNhanVien: {result.MaNhanVien}");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Lấy toàn bộ danh sách nhân viên
        /// </summary>
        public List<ThongTin> GetAllThongTin()
        {
            try
            {
                return dalThongTin.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message, ex);
            }
        }
    }
}
