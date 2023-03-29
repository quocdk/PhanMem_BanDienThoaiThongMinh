
using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class SanPhamConfigurations : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)");
            builder.Property(x => x.LinkAnh).HasColumnType("nvarchar(200)");
            //builder.HasOne(x => x.KhuyenMai).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdKhuyenMai);
            builder.HasOne(x => x.HangDT).WithMany(x => x.SanPhams).HasForeignKey(x => x.HangDTId);
            builder.HasOne(x => x.LoaiDT).WithMany(x => x.SanPhams).HasForeignKey(x => x.LoaiDTId);
        }
    }
}
