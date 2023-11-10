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
    public class PhoneCompanyConfigurations : IEntityTypeConfiguration<PhoneCompany>
    {
        public void Configure(EntityTypeBuilder<PhoneCompany> builder)
        {
            builder.ToTable("PhoneCompany");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
        }
    }
}
