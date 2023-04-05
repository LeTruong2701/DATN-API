﻿using DATN_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class NhanVien
    {
        public int IdNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public Status TrangThai { get; set; }
    }
}
