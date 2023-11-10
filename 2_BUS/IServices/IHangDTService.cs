using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IHangDTService
    {
        bool Add(PhoneCompany phonecompany);
        bool Update(PhoneCompany phonecompany);
        bool Delete(PhoneCompany phonecompany);
        List<PhoneCompany> GetAll();
    }
}
