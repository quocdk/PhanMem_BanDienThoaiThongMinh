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
    public class KhuyenmaiDTRepository : IKMaiDTRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Promotion Promotion)
        {
            _dbContext.Add(Promotion);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Promotion Promotion)
        {
            _dbContext.Remove(Promotion);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Promotion> GetAll()
        {
            return _dbContext.Promotions.ToList();
        }

        public bool Update(Promotion Promotion)
        {
            _dbContext.Update(Promotion);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
