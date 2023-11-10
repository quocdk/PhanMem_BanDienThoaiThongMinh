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
    public class QuanLyNhaCCServices : IQuanLyNhaCCServices
    {
        IQLNhacungCapRepository _nhacc = new QLNhacungcapRepository();
        public bool Add(Supplier obj)
        {
            _nhacc.Add(obj);
            return true;
        }

        public bool Delete(Supplier obj)
        {
            _nhacc.Delete(obj);
            return true;
        }

        public List<Supplier> GetAll()
        {
            return _nhacc.GetAll();

        }

        public bool Update(Supplier obj)
        {
            _nhacc.Update(obj);
            return true;
        }
    }
}
