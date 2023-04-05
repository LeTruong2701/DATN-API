using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class ChiTietDonHang
    {
        public int IdChiTietDonHang { get; set; }
        public int IdDonHang { get; set; }
        public int IdSanPham { get; set; }
        public int IdMauSanPham { get; set; }
        public int IdSizeSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaMua { get; set; }
    }
}
