using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IDichVuServices
    {
        bool Add(Service obj);
        bool Update(Service obj);
        bool Delete(Service obj);
        List<Service> GetAll();
    }
}
