using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface ISanPhamRepository
    {
        bool Add(Product sanPham);
        bool Update(Product sanPham);
        bool Delete(Product sanPham);
        List<Product> GetAll();
    }
}
