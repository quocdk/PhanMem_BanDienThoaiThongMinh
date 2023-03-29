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
        public bool Add(NhanVien nhanVien)
        {
            _dbContext.Add(nhanVien);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien nhanVien)
        {
            _dbContext.Remove(nhanVien);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.nhanViens.ToList();
        }

        public bool Update(NhanVien nhanVien)
        {
            _dbContext.Update(nhanVien);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
