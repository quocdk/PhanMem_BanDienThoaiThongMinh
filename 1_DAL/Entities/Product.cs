using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid PhoneCompanyId { get; set; }
        public Guid PhoneTypeId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid SupplierDetailId { get; set; }
        public string Name { get; set; }
        public string LinkAnh { get; set; }
        public int Status { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal Price { get; set; }
        public string Descriptions { get; set; }
        public int Quantity { get; set; }
        public string WarrantyPeriod { get; set; }

        public virtual PhoneType PhoneType { get; set; }
        public virtual PhoneCompany PhoneCompany { get; set; }
        public virtual List<SupplierDetail> SupplierDetails { get; set; }
        public virtual List<BillDetail> BillDetails { get; set; }
    }
}
