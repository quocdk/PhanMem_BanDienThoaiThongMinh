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
    public class NhaCungCapCTRepository : INhacungcapCTRepository
    {
        QuanLyDatabaseContext _context = new QuanLyDatabaseContext();
        public bool Add(SupplierDetail nhaCungcapCT)
        {
            _context.Add(nhaCungcapCT);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(SupplierDetail nhaCungcapCT)
        {
            _context.Remove(nhaCungcapCT);
            _context.SaveChanges();
            return true;
        }

        public List<SupplierDetail> GetAll()
        {
            return _context.SupplierDetails.ToList();
        }

        public bool Update(SupplierDetail nhaCungcapCT)
        {
            _context.Update(nhaCungcapCT);
            _context.SaveChanges();
            return true;
        }
    }
}
