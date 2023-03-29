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
        bool Add(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(NhanVien nhanVien);
        List<NhanVien> GetAll();
    }
}
