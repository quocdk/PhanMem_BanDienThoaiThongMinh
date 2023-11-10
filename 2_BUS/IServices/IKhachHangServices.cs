using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
        bool Add(Custommer obj);
        bool Update(Custommer obj);
        bool Delete(Custommer obj);
        List<Custommer> GetAll();
    }
}
