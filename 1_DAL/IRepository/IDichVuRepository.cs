using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IDichVuRepository
    {
        bool Add(Service dichVu);
        bool Update(Service dichVu);
        bool Delete(Service dichVu);
        List<Service> GetAll();
    }
}
