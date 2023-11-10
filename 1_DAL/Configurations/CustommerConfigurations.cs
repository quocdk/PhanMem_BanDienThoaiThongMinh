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
    public class CustommerConfigurations : IEntityTypeConfiguration<Custommer>
    {
        public void Configure(EntityTypeBuilder<Custommer> builder)
        {
            builder.ToTable("Custommer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(200)");

        }
    }
}
