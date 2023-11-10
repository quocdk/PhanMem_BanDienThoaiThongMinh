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
    public class HangDTRepository : IHangDTRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(PhoneCompany hangDT)
        {
            _dbContext.Add(hangDT);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhoneCompany hangDT)
        {
            _dbContext.Remove(hangDT);
            _dbContext.SaveChanges();
            return true;
        }

        public List<PhoneCompany> GetAll()
        {
            return _dbContext.PhoneCompanies.ToList();
        }

        public bool Update(PhoneCompany hangDT)
        {
            _dbContext.Update(hangDT);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
