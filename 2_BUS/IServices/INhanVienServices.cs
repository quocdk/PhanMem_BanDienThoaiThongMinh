using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface INhanVienServices
    {
        bool Add(Employee obj);
        bool Update(Employee obj);
        bool Delete(Employee obj);
        List<Employee> GetAll();
    }
}
