using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISanPhamServices
    {
        bool Add(Product obj);
        bool Update(Product obj);
        bool Delete(Product obj);
        List<Product> GetAll();
    }
}
