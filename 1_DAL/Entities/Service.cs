using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TypeService { get; set; }
        public decimal Price { get; set; }
        public virtual List<BillDetail> BillDetails { get; set; }
    }
}
