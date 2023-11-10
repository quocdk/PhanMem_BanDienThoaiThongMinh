using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IQLNhacungCapRepository
    {
        bool Add(Supplier nhaCC);
        bool Update(Supplier nhaCC);
        bool Delete(Supplier nhaCC);
        List<Supplier> GetAll();
    }
}
