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
    public class NhaCungCapCTConfigurations : IEntityTypeConfiguration<NhaCungCapCT>
    {
        public void Configure(EntityTypeBuilder<NhaCungCapCT> builder)
        {
            builder.ToTable("NhaCungCapCT");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.HasOne(x => x.SanPham).WithMany(x => x.NhaCungCapCTs).HasForeignKey(x => x.SanPhamId);
            builder.HasOne(x => x.NhaCungCap).WithMany(x => x.NhaCungCapCTs).HasForeignKey(x => x.NhaCungCapId);
        }
    }
}
