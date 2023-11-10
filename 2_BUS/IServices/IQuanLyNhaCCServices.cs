using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQuanLyNhaCCServices
    {
        bool Add(Supplier Supplier);
        bool Update(Supplier Supplier);
        bool Delete(Supplier Supplier);
        List<Supplier> GetAll();
    
    }
}

