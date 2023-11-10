using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IKhachHangRepository
    {
        bool Add(Custommer khachHang);
        bool Update(Custommer khachHang);
        bool Delete(Custommer khachHang);
        List<Custommer> GetAll();
    }
}
