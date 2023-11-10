using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface IKMaiDTRepository
    {
        bool Add(Promotion khuyenmai);
        bool Update(Promotion khuyenmai);
        bool Delete(Promotion khuyenmai);
        List<Promotion> GetAll();
    }
}
