using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface ILoaiDTRepository
    {
        bool Add(PhoneType loaiDT);
        bool Update(PhoneType loaiDT);
        bool Delete(PhoneType loaiDT);
        List<PhoneType> GetAll();
    }
}
