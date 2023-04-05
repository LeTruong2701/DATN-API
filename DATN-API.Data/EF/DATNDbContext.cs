using DATN_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.EF
{
    public class DATNDbContext : DbContext
    {
        public DATNDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<MauSanPham> MauSanPhams { get; set; }
        public DbSet<SizeSanPham> SizeSanPhams { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}
