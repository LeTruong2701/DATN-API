﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        public DonHang DonHang { get; set; }

        public SanPham SanPham { get; set; }

        public MauSanPham MauSanPham { get; set; }

        public SizeSanPham SizeSanPham { get; set; }
    }
}
