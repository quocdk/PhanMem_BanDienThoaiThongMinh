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
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangRepository ikhachhangrepository = new KhachHangRepository();
        public bool Add(Custommer obj)
        {
            ikhachhangrepository.Add(obj);
            return true;
        }

        public bool Delete(Custommer obj)
        {
            ikhachhangrepository.Delete(obj);
            return true;
        }

        public List<Custommer> GetAll()
        {
            return ikhachhangrepository.GetAll();
        }

        public bool Update(Custommer obj)
        {
            ikhachhangrepository.Update(obj);
            return true;
        }
    }
}
