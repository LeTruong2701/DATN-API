﻿using DATN_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class DanhMuc
    {
        public int IdDanhMuc { get; set; }
        public int? IdDanhMucCha { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public Status TrangThai { get; set; }
   
        //public SanPham SanPham { get; set; }
    }
}
