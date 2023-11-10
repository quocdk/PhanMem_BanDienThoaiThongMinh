using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ILoaiDTService
    {
        bool Add(PhoneType obj);
        bool Update(PhoneType obj);
        bool Delete(PhoneType obj);
        List<PhoneType> GetAll();
    }
}
