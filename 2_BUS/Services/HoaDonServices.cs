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
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonRepository ihoadonrepository = new HoaDonRepository();
        public bool Add(Bill obj)
        {
            ihoadonrepository.Add(obj);
            return true;
        }

        public bool Delete(Bill obj)
        {
            ihoadonrepository.Delete(obj);
            return true;
        }

        public List<Bill> GetAll()
        {
            return ihoadonrepository.GetAll();
        }

        public bool Update(Bill obj)
        {
            ihoadonrepository.Update(obj);
            return true;
        }
    }
}
