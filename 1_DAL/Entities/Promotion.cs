using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Promotion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Index { get; set; }
        public virtual List<BillDetail> BillDetails { get; set; }
    }
}
