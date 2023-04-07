﻿using DATN_API.Data.Entities;
using DATN_API.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATN_API.Data.Configurations
{
    public class ThuongHieuConfiguration : IEntityTypeConfiguration<ThuongHieu>
    {
        public void Configure(EntityTypeBuilder<ThuongHieu> builder)
        {
            builder.ToTable("ThuongHieu");
            builder.HasKey(x => x.IdThuongHieu);
            builder.Property(x => x.TenThuongHieu).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.MoTa).IsRequired(false).HasColumnType("ntext");
            builder.Property(x => x.TrangThai).HasDefaultValue(Status.Active);

        }
    }
}
