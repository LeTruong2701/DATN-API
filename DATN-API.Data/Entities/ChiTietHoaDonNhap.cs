using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class ChiTietHoaDonNhap
    {
        public int IdChiTietHoaDonNhap { get; set; }
        public int IdHoaDonNhap { get; set; }
        public int IdSanPham { get; set; }
        public int IdMauSanPham { get; set; }
        public int IdSizeSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }

        public HoaDonNhap HoaDonNhap { set; get; }

        public SanPham SanPham { get; set; }

        public MauSanPham MauSanPham { get; set; }

        public SizeSanPham SizeSanPham { get; set; }
    }
}
