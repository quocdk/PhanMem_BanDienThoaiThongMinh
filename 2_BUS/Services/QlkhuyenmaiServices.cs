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
    public class QlkhuyenmaiServices : IQuanLyKMServices
    {
        private IKMaiDTRepository _khuyenmai = new KhuyenmaiDTRepository();
        public bool Add(Promotion obj)
        {
            _khuyenmai.Add(obj);
            return true;
        }

        public bool Delete(Promotion obj)
        {
            _khuyenmai.Delete(obj);
            return true;
        }

        public List<Promotion> GetAll()
        {
            return _khuyenmai.GetAll();

        }

        public bool Update(Promotion obj)
        {
            _khuyenmai.Update(obj);
            return true;
        }
    }
}
