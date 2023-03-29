using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public int Point { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
