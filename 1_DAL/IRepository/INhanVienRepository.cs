using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface INhanVienRepository
    {
        bool Add(Employee nhanVien);
        bool Update(Employee nhanVien);
        bool Delete(Employee nhanVien);
        List<Employee> GetAll();
    }
}
