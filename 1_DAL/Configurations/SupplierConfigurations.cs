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
    public class SupplierConfigurations : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Address).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.WebSite).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Note).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Image).HasColumnType("varbinary(200)").IsRequired();
        }
    }
}
