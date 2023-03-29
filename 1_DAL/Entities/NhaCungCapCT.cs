using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class NhaCungCapCT
    {
        public Guid Id { get; set; }
        public Guid SanPhamId { get; set; }
        public Guid NhaCungCapId { get; set; }
        public string Name { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
