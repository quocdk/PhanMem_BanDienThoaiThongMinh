using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class ViewProduct
    {
        public Guid Id { get; set; }
        public string   Name { get; set; }
        public string NamePhoneCompany { get; set; }
        public string NamePhoneType { get; set; }
        public string NameSupplier { get; set; }
        public int Quantity { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal Price { get; set; }
        public string Guarantee { get; set; }
        
    }
}
