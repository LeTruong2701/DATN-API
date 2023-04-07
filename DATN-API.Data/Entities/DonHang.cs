using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class DonHang
    {
        public int IdDonHang { get; set; }
        public int IdKhachHang { get; set; }
        public string GhiChu { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public DateTime NgayDat { get; set; }
        public string TrangThaiDonHang { get; set; }
        public decimal TongTien { get; set; }

        //public List<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public KhachHang KhachHang { get; set; }
    }
}
