using DATN_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class MauSanPham
    {
        public int IdMauSanPham { get; set; }
        public int IdSanPham { get; set; }
        public string TenMau { get; set; }
        public string MaMau { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string AnhSanPham { get; set; }
        public Status CheckThanhToan { get; set; }
        public Status TrangThai { get; set; }

        //public List<ChiTietDonHang> ChiTietDonHangs { get; set; }

        //public List<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }

        public SanPham SanPham { get; set; }

        //public List<SizeSanPham> SizeSanPhams { get; set; }

    }
}
