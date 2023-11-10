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
    public class BillConfigurations : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.Note).HasColumnType("nvarchar(200)");
            builder.HasOne(x => x.Employee).WithMany(x => x.Bills).HasForeignKey(x => x.EmployeeId);
            builder.HasOne(x => x.Custommer).WithMany(x => x.Bills).HasForeignKey(x => x.CustommerId);
        }
    }
}
