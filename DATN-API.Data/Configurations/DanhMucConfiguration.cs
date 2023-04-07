using DATN_API.Data.Entities;
using DATN_API.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Configurations
{
    internal class DanhMucConfiguration : IEntityTypeConfiguration<DanhMuc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc> builder)
        {
            builder.ToTable("DanhMuc");
            builder.HasKey(x=>x.IdDanhMuc);
            builder.Property(x => x.IdDanhMucCha).IsRequired(false);
            builder.Property(x => x.TenDanhMuc).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.MoTa).IsRequired(false).HasColumnType("nvarchar(500)");
            builder.Property(x => x.TrangThai).HasDefaultValue(Status.Active);

        }
    }
}
