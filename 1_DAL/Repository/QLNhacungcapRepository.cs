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
    public class QLNhacungcapRepository : IQLNhacungCapRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Supplier Supplier)
        {
            _dbContext.Add(Supplier);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Supplier Supplier)
        {
            _dbContext.Remove(Supplier);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Supplier> GetAll()
        {
            return _dbContext.Suppliers.ToList();
        }

        public SupplierDetail GetById(int id)
        {
           throw new NotImplementedException();
        }

        public bool Update(Supplier supplier)
        {
            _dbContext.Update(supplier);
            _dbContext.SaveChanges();
            return true;
        }


    }
}
