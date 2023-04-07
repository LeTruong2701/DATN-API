using DATN_API.Data.Configurations;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucConfiguration());
            modelBuilder.ApplyConfiguration(new MauSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new SizeSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new KhuyenMaiConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new ThuongHieuConfiguration());
            modelBuilder.ApplyConfiguration(new DonHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietDonHangConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonNhapConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietHoaDonNhapConfiguration());


            //base.OnModelCreating(modelBuilder);
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
