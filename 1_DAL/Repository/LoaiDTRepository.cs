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
    public class LoaiDTRepository : ILoaiDTRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(PhoneType loaiDT)
        {
            _dbContext.Add(loaiDT);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhoneType loaiDT)
        {
            _dbContext.Remove(loaiDT);
            _dbContext.SaveChanges();
            return true;
        }

        public List<PhoneType> GetAll()
        {
            return _dbContext.PhoneTypes.ToList();
        }

        public bool Update(PhoneType loaiDT)
        {
            _dbContext.Update(loaiDT);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
