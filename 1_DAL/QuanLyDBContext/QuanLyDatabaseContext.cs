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
        public  DbSet<Service> Services { get; set; }
        public  DbSet<PhoneCompany> PhoneCompanies { get; set; }
        public  DbSet<Bill> bills { get; set; }
        public  DbSet<BillDetail> BillDetails { get; set; }
        public  DbSet<Promotion> Promotions { get; set; }
        public  DbSet<PhoneType> PhoneTypes { get; set; }
        public  DbSet<Supplier> Suppliers { get; set; }
        public  DbSet<SupplierDetail> SupplierDetails { get; set; }
        public  DbSet<Employee> Employees { get; set; }
        public  DbSet<Product> Products   { get; set; }
        public DbSet<Custommer> custommers { get; set; }
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ANTHONYPC\SQLEXPRESS;Initial Catalog=du_an_1_;Integrated Security=True");
        }
    }
}
