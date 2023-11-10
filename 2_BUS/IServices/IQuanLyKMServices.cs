using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQuanLyKMServices
    {    
        bool Add(Promotion promotion);
        bool Update(Promotion promotion);
        bool Delete(Promotion promotion);
        List<Promotion> GetAll();
    }
}

