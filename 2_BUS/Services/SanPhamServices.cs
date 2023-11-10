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
    public class SanPhamServices : ISanPhamServices
    {
        private ISanPhamRepository isanphamrepository = new SanPhamRepository();
        public bool Add(Product obj)
        {
            isanphamrepository.Add(obj);
            return true;
        }

        public bool Delete(Product obj)
        {
            isanphamrepository.Delete(obj);
            return true;
        }

        public List<Product> GetAll()
        {
            return isanphamrepository.GetAll();
        }

        public bool Update(Product obj)
        {
            isanphamrepository.Update(obj);
            return true;
        }
    }
}
