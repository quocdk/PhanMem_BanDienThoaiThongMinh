using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IHangDTRepository
    {
        bool Add(PhoneCompany hangDT);
        bool Update(PhoneCompany hangDT);
        bool Delete(PhoneCompany hangDT);
        List<PhoneCompany> GetAll();
    }
}
