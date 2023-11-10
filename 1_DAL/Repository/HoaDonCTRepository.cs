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
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(BillDetail hoaDonCT)
        {
            _dbContext.Add(hoaDonCT);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(BillDetail hoaDonCT)
        {
            _dbContext.Remove(hoaDonCT);
            _dbContext.SaveChanges();
            return true;
        }

        public List<BillDetail> GetAll()
        {
            return _dbContext.BillDetails.ToList();
        }

        public bool Update(BillDetail hoaDonCT)
        {
            _dbContext.Update(hoaDonCT);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
