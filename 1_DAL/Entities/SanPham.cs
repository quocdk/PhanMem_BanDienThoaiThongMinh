using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public Guid HangDTId { get; set; }
        public Guid LoaiDTId { get; set; }
        public Guid KhuyenMaiId { get; set; }
        public Guid NhaCungCapCTId { get; set; }
        public string Name { get; set; }
        public string LinkAnh { get; set; }
        public int Status { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal Price { get; set; }
        public string Descriptions { get; set; }
        public virtual LoaiDT LoaiDT { get; set; }
        public virtual HangDT HangDT { get; set; }
        public virtual List<NhaCungCapCT> NhaCungCapCTs { get; set; }
        public virtual List<HoaDonCT> HoaDonCTs { get; set; }
    }
}
