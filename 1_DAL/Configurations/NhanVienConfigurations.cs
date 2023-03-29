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
    public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(200)");

            builder.Property(x => x.BirthDay).HasColumnType("DateTime");
            //builder.Property(x => x.Sex).HasColumnType("");
            builder.Property(x => x.LinkImage).HasColumnType("nvarchar(200)");
            builder.Property(x => x.UserName).HasColumnType("nvarchar(200)");
            builder.Property(x => x.PassWord).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Role).HasColumnType("nvarchar(200)");
        }
    }
}
