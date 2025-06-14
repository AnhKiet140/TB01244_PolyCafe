using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;

namespace DAL_PolyCafe
{
    public class DALThongTin
    {
        public ThongTin GetThongTinByMa(string maNhanVien)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = @maNhanVien";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0B47B2G\\SQLEXPRESS;Initial Catalog=PolyCafe;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien); // Thêm dòng này
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ThongTin
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                // Các trường khác
                            };
                        }
                        return null;
                    }
                }
            }
        }


        private List<ThongTin> SelectBySql(string sql, List<object> args)
        {
            List<ThongTin> list = new List<ThongTin>();

            SqlDataReader reader = DBUtil.Query(sql, args);
            while (reader.Read())
            {
                ThongTin entity = new ThongTin();
                entity.MaNhanVien = reader.GetString(0);
                entity.HoTen = reader.GetString(1);
                entity.MatKhau = reader.GetString(2);
                entity.VaiTro = reader.GetBoolean(3);
                entity.TrangThai = reader.GetBoolean(4); // Cập nhật thành GetBoolean
                entity.Email = reader.GetString(5);
                entity.HinhAnh = reader.IsDBNull(6) ? null : (byte[])reader[6];

                list.Add(entity);
            }
            reader.Close();
            return list;
        }


        public List<ThongTin> SelectAll()
        {
            List<ThongTin> list = new List<ThongTin>();
            string sql = "SELECT * FROM NhanVien";

            try
            {
                using (SqlConnection conn = new SqlConnection(DBUtil.connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ThongTin tt = new ThongTin
                                {
                                    MaNhanVien = reader["MaNhanVien"].ToString(),
                                    HoTen = reader["HoTen"].ToString(),
                                    MatKhau = reader["MatKhau"].ToString(),
                                    VaiTro = reader["VaiTro"] != DBNull.Value && Convert.ToBoolean(reader["VaiTro"]),
                                    TrangThai = reader["TrangThai"] != DBNull.Value && Convert.ToBoolean(reader["TrangThai"]), // Cập nhật
                                    Email = reader["Email"].ToString(),
                                    HinhAnh = reader["HinhAnh"] == DBNull.Value ? null : (byte[])reader["HinhAnh"]
                                };
                                list.Add(tt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách ThongTin: " + ex.Message);
            }

            return list;
        }
    }
}
