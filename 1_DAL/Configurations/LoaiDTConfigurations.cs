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
    public class LoaiDTConfigurations : IEntityTypeConfiguration<LoaiDT>
    {
        public void Configure(EntityTypeBuilder<LoaiDT> builder)
        {
            builder.ToTable("LoaiDienThoai");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(200)");
        }
    }
}
