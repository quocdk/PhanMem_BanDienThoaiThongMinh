using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class SupplierDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
