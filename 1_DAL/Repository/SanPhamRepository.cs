using _1_DAL.Entities;
using _1_DAL.IRepository;
using _1_DAL.QuanLyDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class SanPhamRepository : ISanPhamRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Product sanPham)
        {
            _dbContext.Add(sanPham);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Product sanPham)
        {
            _dbContext.Remove(sanPham);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public bool Update(Product sanPham)
        {
            _dbContext.Update(sanPham);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
