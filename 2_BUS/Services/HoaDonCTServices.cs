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
    public class HoaDonCTServices : IHoadonCTServices
    {
        private IHoaDonCTRepository ihoadonctrepository = new HoaDonCTRepository();
        public bool Add(BillDetail obj)
        {
            ihoadonctrepository.Add(obj);
            return true;
        }

        public bool Delete(BillDetail obj)
        {
            ihoadonctrepository.Delete(obj);
            return true;
        }

        public List<BillDetail> GetAll()
        {
            return ihoadonctrepository.GetAll();
        }

        public bool Update(BillDetail obj)
        {
            ihoadonctrepository.Update(obj);
            return true;
        }
    }
}
