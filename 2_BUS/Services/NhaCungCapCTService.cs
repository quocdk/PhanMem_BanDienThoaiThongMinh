using _1_DAL.Entities;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class NhaCungCapCTService : INhaCungCapCTServices
    {
        private INhacungcapCTRepository _inhacungcapctRepository = new NhaCungCapCTRepository();
        public bool Add(SupplierDetail obj)
        {
            _inhacungcapctRepository.Add(obj);
            return true;
        }

        public bool Delete(SupplierDetail obj)
        {
            _inhacungcapctRepository.Delete(obj);
            return true;
        }

        public List<SupplierDetail> GetAll()
        {
            return _inhacungcapctRepository.GetAll();
        }

        public bool Update(SupplierDetail obj)
        {
            _inhacungcapctRepository.Update(obj);
            return true;
        }
    }
}
