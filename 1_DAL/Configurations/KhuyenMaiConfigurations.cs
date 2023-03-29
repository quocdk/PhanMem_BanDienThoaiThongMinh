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
    public class KhuyenMaiConfigurations : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)");
            builder.Property(x => x.CreateDate).HasColumnType("DateTime");
            builder.Property(x => x.EndDate).HasColumnType("DateTime");
            builder.Property(x => x.ChiSo).HasColumnType("nvarchar(200)");
        }
    }
}
