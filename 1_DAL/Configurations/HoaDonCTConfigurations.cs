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
    public class HoaDonCTConfigurations : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.ToTable("HoaDonCT");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IdHD);
            builder.HasOne(x => x.DichVu).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IdDV);
            builder.HasOne(x => x.SanPham).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IdSP);
            builder.HasOne(x => x.KhuyenMai).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IdKM);
        }
    }
}
