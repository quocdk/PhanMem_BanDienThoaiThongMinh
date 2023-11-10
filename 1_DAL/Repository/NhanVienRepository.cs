using _1_DAL.Entities;
using _1_DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.QuanLyDBContext;



namespace _1_DAL.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Employee employee)
        {
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public bool Update(Employee employee)
        {
            _dbContext.Update(employee);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
