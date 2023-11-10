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
    public class SupplierDetailsConfigurations : IEntityTypeConfiguration<SupplierDetail>
    {
        public void Configure(EntityTypeBuilder<SupplierDetail> builder)
        {
            builder.ToTable("SupplierDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.HasOne(x => x.Product).WithMany(x => x.SupplierDetails).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Supplier).WithMany(x => x.SupplierDetails).HasForeignKey(x => x.SupplierId);
        }
    }
}
