using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface INhacungcapCTRepository
    {
        bool Add(SupplierDetail nhaCungcapCT);
        bool Update(SupplierDetail nhaCungcapCT);
        bool Delete(SupplierDetail nhaCungcapCT);
        List<SupplierDetail> GetAll();
    }
}
