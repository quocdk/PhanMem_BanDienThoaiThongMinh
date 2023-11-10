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
    public class HoaDonRepository:IHoaDonRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Bill hoaDon)
        {
            _dbContext.Add(hoaDon);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Bill hoaDon)
        {
            _dbContext.Remove(hoaDon);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Bill> GetAll()
        {
            return _dbContext.bills.ToList();
        }

        public bool Update(Bill hoaDon)
        {
            _dbContext.Update(hoaDon);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
