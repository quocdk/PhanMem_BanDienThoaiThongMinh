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
    public class HangDTService : IHangDTService
    {
        private IHangDTRepository _ihangdtrepository = new HangDTRepository();

        public bool Add(PhoneCompany phonecompany)
        {
            _ihangdtrepository.Add(phonecompany);
            return true;
        }

        public bool Delete(PhoneCompany phonecompany)
        {
            _ihangdtrepository.Delete(phonecompany);
            return true;
        }

        public List<PhoneCompany> GetAll()
        {
            return _ihangdtrepository.GetAll();
        }

        public bool Update(PhoneCompany phonecompany)
        {
            _ihangdtrepository.Update(phonecompany);
            return true;
        }
    }
}
