using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IHoaDonServices
    {
        bool Add(Bill obj);
        bool Update(Bill obj);
        bool Delete(Bill obj);
        List<Bill> GetAll();
    }
}
