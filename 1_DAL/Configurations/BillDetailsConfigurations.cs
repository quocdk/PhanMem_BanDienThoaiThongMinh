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
    public class BillDetailsConfigurations : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.ToTable("BillDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.IntoMoney).IsRequired();
            builder.HasOne(x => x.Bill).WithMany(x => x.BillDetails).HasForeignKey(x => x.BillId);
            builder.HasOne(x => x.Service).WithMany(x => x.BillDetails).HasForeignKey(x => x.ServiceId);
            builder.HasOne(x => x.Product).WithMany(x => x.BillDetails).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Promotion).WithMany(x => x.BillDetails).HasForeignKey(x => x.PromotionId);
        }
    }
}
