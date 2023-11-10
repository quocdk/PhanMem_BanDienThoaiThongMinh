using _1_DAL.Entities;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class DichVuServices : IDichVuServices
    {
        private IDichVuRepository idichvurepository = new DichVuRepository();

        public bool Add(Service obj)
        {
            idichvurepository.Add(obj);
            return true;
        }

        public bool Delete(Service obj)
        {
            idichvurepository.Delete(obj);
            return true;
        }

        public List<Service> GetAll()
        {
            return idichvurepository.GetAll();
        }

        public bool Update(Service obj)
        {
            idichvurepository.Update(obj);
            return true;
        }
    }
}
