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
    public class LoaiDTService :ILoaiDTService
    {
        private ILoaiDTRepository _iloaidtrepository = new LoaiDTRepository();

        public bool Add(PhoneType obj)
        {
            _iloaidtrepository.Add(obj);
            return true;
        }

        public bool Delete(PhoneType obj)
        {
            _iloaidtrepository.Delete(obj);
            return true;
        }

        public List<PhoneType> GetAll()
        {
            return _iloaidtrepository.GetAll();
        }

        public bool Update(PhoneType obj)
        {
            _iloaidtrepository.Update(obj);
            return true;
        }
    }
}
