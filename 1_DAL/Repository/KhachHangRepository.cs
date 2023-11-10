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
    public class KhachHangRepository : IKhachHangRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Custommer khachHang)
        {
            _dbContext.Add(khachHang);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Custommer khachHang)
        {
            _dbContext.Remove(khachHang);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Custommer> GetAll()
        {
            return _dbContext.custommers.ToList();
        }

        public bool Update(Custommer khachHang)
        {
            _dbContext.Update(khachHang);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
