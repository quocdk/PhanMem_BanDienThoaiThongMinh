using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface INhaCungCapCTServices
    {
        bool Add(SupplierDetail obj);
        bool Update(SupplierDetail obj);
        bool Delete(SupplierDetail obj);
        List<SupplierDetail> GetAll();
    }
}
