using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class BillDetail
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public Guid PromotionId { get; set; }
        public int Quantity { get; set; }
        public decimal IntoMoney { get; set; }
        public virtual Service Service { get; set; }
        public virtual Product Product { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
