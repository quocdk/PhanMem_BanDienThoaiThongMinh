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
            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien() {  Name = "Nguyễn Tài Linh", PhoneNumber = "0345263615",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Nguyễn Tài Linh", PassWord="111"},
                new NhanVien() {  Name = "Đinh Kiến Quốc", PhoneNumber = "05421589244",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Đinh Kiếm Quốc", PassWord="111"},
                new NhanVien() {  Name = "Nguyễn Vinh", PhoneNumber = "08956241532",BirthDay=DateTime.Now,Sex = true,LinkImage = "", Status = true, Role = "Quản Lý", UserName= "Nguyễn Vinh", PassWord="111"}

            );
            modelBuilder.Entity<LoaiDT>().HasData(
                new LoaiDT() { }
            );
            modelBuilder.Entity<HangDT>().HasData(
                new HangDT() { Name = "Nokia" },
                new HangDT() { Name = "IPhone" },
                new HangDT() { Name = "BPhone" },
                new HangDT() { Name = "SamSung" },
                new HangDT() { Name = "RedMi" }
            );
            modelBuilder.Entity<NhaCungCap>().HasData(
                new NhaCungCap() { Name="Đại Lý Hào Quang Rực Rỡ" },
                new NhaCungCap() { Name="Đại Lý Cứu Trợ Vùng Lũ" },
                new NhaCungCap() { Name="Đại Lý " },
                new NhaCungCap() { Name="" },
                new NhaCungCap() { Name="" }
            );
            modelBuilder.Entity<KhuyenMai>().HasData(
                new KhuyenMai() { Name = "Khuyến Mãi Ngày Valentine",CreateDate = DateTime.Parse("10-2-2023"),EndDate = DateTime.Parse("15-2-2023") ,ChiSo = 10},
                new KhuyenMai() { Name = "Khuyến Mãi Ngày Chrismas",CreateDate = DateTime.Parse("20-12-2023"),EndDate = DateTime.Parse("5-1-2024") ,ChiSo = 10},
                new KhuyenMai() { Name = "Khuyến Mãi Ngày Tet",CreateDate = DateTime.Parse("5-2-2024"),EndDate = DateTime.Parse("15-2-2024") ,ChiSo = 20}
            );
            modelBuilder.Entity<DichVu>().HasData(
                new DichVu() { Name = "Sửa Màn Hình IPhone" , LoaiDichVu = "Sửa Chữa", Price = 50000000},
                new DichVu() { Name = "Sửa Màn Hình SamSung" , LoaiDichVu = "Sửa Chữa", Price = 10000000},
                new DichVu() { Name = "Thay Pin SamSung" , LoaiDichVu = "Sửa Chữa", Price = 5000000}
            );
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang() {  }
            );
            modelBuilder.Entity<HoaDon>().HasData(
                new HoaDon() {  }
            );
            modelBuilder.Entity<HoaDonCT>().HasData(
                new HoaDonCT() {}
            );
            modelBuilder.Entity<NhaCungCapCT>().HasData(
                new NhaCungCapCT() {  }
            );
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham() { }
            );
        }
    }
}
