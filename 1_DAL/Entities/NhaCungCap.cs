using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class NhaCungCap
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<NhaCungCapCT> NhaCungCapCTs { get; set; }
    }
}
