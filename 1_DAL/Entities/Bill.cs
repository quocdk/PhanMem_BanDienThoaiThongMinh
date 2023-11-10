using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Guid CustommerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Custommer Custommer { get; set; }
        public virtual List<BillDetail> BillDetails { get; set; }
    }
}
