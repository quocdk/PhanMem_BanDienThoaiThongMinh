using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IHoaDonCTRepository
    {
        bool Add(BillDetail hoaDonCT);
        bool Update(BillDetail hoaDonCT);
        bool Delete(BillDetail hoaDonCT);
        List<BillDetail> GetAll();
    }
}
