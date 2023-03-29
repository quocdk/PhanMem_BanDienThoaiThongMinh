using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL.Configurations
{
    public class DichVuConfigurations : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.ToTable("DichVu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.LoaiDichVu).HasColumnType("nvarchar(200)").IsRequired();
        }
    }
}
