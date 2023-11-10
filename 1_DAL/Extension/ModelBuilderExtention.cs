using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL.Extension
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = Guid.Parse("ea13c2ed-c52b-45f6-aa4b-4e47bf37b7d5"), Name = "Nguyễn Tài Linh", PhoneNumber = "0345263615",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Nguyễn Tài Linh", PassWord="111"},
                new Employee() { Id = Guid.Parse("eb6b9462-5637-4146-b23f-9f3fda1c6a8a"), Name = "Đinh Kiến Quốc", PhoneNumber = "05421589244",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Đinh Kiếm Quốc", PassWord="111"},
                new Employee() { Id = Guid.Parse("f5cdbc9f-5db5-44df-b9de-fbc5cedb3e83"), Name = "Nguyễn Vinh", PhoneNumber = "08956241532",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Nguyễn Vinh", PassWord="111"}

            );
            modelBuilder.Entity<PhoneType>().HasData(
                new PhoneType() { }
            );
            modelBuilder.Entity<PhoneCompany>().HasData(
                new PhoneCompany() { Name = "Nokia" },
                new PhoneCompany() { Name = "IPhone" },
                new PhoneCompany() { Name = "BPhone" },
                new PhoneCompany() { Name = "SamSung" },
                new PhoneCompany() { Name = "RedMi" }
            );
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier() { Name="Đại Lý Hào Quang Rực Rỡ" },
                new Supplier() { Name="Đại Lý Cứu Trợ Vùng Lũ" },
                new Supplier() { Name="Đại Lý " },
                new Supplier() { Name="" },
                new Supplier() { Name="" }
            );
            modelBuilder.Entity<Promotion>().HasData(
                new Promotion() { Name = "Khuyến Mãi Ngày Valentine",CreateDate = DateTime.Parse("10-2-2023"),EndDate = DateTime.Parse("15-2-2023") ,Index = 10},
                new Promotion() { Name = "Khuyến Mãi Ngày Chrismas",CreateDate = DateTime.Parse("20-12-2023"),EndDate = DateTime.Parse("5-1-2024") , Index = 10},
                new Promotion() { Name = "Khuyến Mãi Ngày Tet",CreateDate = DateTime.Parse("5-2-2024"),EndDate = DateTime.Parse("15-2-2024") , Index = 20}
            );
            modelBuilder.Entity<Service>().HasData(
                new Service() { Name = "Sửa Màn Hình IPhone" , TypeService = "Sửa Chữa", Price = 50000000},
                new Service() { Name = "Sửa Màn Hình SamSung" , TypeService = "Sửa Chữa", Price = 10000000},
                new Service() { Name = "Thay Pin SamSung" , TypeService = "Sửa Chữa", Price = 5000000}
            );
            modelBuilder.Entity<Custommer>().HasData(
                new Custommer() {  }
            );
            modelBuilder.Entity<Bill>().HasData(
                new Bill() {  }
            );
            modelBuilder.Entity<BillDetail>().HasData(
                new BillDetail() {}
            );
            modelBuilder.Entity<SupplierDetail>().HasData(
                new SupplierDetail() {  }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product() { }
            );
        }
    }
}
