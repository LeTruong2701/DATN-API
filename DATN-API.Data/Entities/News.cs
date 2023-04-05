﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Entities
{
    public class News
    {
        public int IdNews { get; set; }
        public string LoaiTin { get; set; }
        public string Title { get; set; }
        public string NoiDung { get; set; }
        public string Anh { get; set; }
        public int IdNguoiDung { get; set; }
        public DateTime NgayDang { get; set; }
    }
}
