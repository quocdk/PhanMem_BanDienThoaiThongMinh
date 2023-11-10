
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
    public class ProductsConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)");
            builder.Property(x => x.LinkAnh).HasColumnType("nvarchar(200)");
            builder.Property(x => x.WarrantyPeriod).HasColumnType("nvarchar(200)");
            //builder.HasOne(x => x.KhuyenMai).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdKhuyenMai);
            builder.HasOne(x => x.PhoneCompany).WithMany(x => x.Products).HasForeignKey(x => x.PhoneCompanyId);
            builder.HasOne(x => x.PhoneType).WithMany(x => x.Products).HasForeignKey(x => x.PhoneTypeId);
        }
    }
}
