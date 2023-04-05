using DATN_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class SizeSanPham
    {
        public int IdSizeSanPham { get; set; }
        public int IdSanPham { get; set; }
        public int IdMauSanPham { get; set; }
        public string Size { get; set; }
        public int SoLuong { get; set; }
        public Status TrangThai { get; set; }

    }
}
