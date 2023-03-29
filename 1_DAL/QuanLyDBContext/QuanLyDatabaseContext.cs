using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Entities;
using _1_DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace _1_DAL.QuanLyDBContext
{
    public class QuanLyDatabaseContext :DbContext
    {
        public QuanLyDatabaseContext()
        {

        }
        public QuanLyDatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public  DbSet<DichVu> dichVus { get; set; }
        public  DbSet<HangDT> hangDTs { get; set; }
        public  DbSet<HoaDon> hoaDons { get; set; }
        public  DbSet<HoaDonCT> hoaDonCTs { get; set; }
        public  DbSet<KhuyenMai> khuyenMais { get; set; }
        public  DbSet<LoaiDT> loaiDTs { get; set; }
        public  DbSet<NhaCungCap> nhaCungCaps { get; set; }
        public  DbSet<NhaCungCapCT> nhaCungCapCTs { get; set; }
        public  DbSet<NhanVien> nhanViens { get; set; }
        public  DbSet<SanPham> sanPhams   { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ANTHONYPC\SQLEXPRESS;Initial Catalog=du_an_01;Integrated Security=True");
        }
    }
}
