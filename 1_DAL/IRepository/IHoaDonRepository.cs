using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IHoaDonRepository
    {
        bool Add(Bill hoaDon);
        bool Update(Bill hoaDon);
        bool Delete(Bill hoaDon);
        List<Bill> GetAll();
    }
}
