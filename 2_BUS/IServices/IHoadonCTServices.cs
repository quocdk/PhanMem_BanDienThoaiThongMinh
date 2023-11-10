using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IHoadonCTServices
    {
        bool Add(BillDetail obj);
        bool Update(BillDetail obj);
        bool Delete(BillDetail obj);
        List<BillDetail> GetAll();
    }
}
