﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class ThongTin
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public bool VaiTro { get; set; }
        public bool TrangThai { get; set; } 
        public string Email { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
