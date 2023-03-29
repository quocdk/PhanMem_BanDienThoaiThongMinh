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
    public class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.Note).HasColumnType("nvarchar(200)");
            builder.HasOne(x => x.NhanVien).WithMany(x => x.HoaDons).HasForeignKey(x => x.NhanVienId);
            builder.HasOne(x => x.KhachHang).WithMany(x => x.HoaDons).HasForeignKey(x => x.KhachHangId);
        }
    }
}
