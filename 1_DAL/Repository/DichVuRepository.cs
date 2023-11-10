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
    public class DichVuRepository : IDichVuRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Service dichVu)
        {
            _dbContext.Add(dichVu);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Service dichVu)
        {
            _dbContext.Remove(dichVu);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Service> GetAll()
        {
            return _dbContext.Services.ToList();
        }

        public bool Update(Service dichVu)
        {
            _dbContext.Update(dichVu);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
