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
        public Guid IdHangDT { get; set; }
        public Guid IdLoaiDT { get; set; }
        public Guid IdKhuyenMai { get; set; }
        public Guid IdNhaCungCapCT { get; set; }
        public string Name { get; set; }
        public string LinkAnh { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual LoaiDT LoaiDT { get; set; }
        public virtual HangDT HangDT { get; set; }
        public virtual List<NhaCungCapCT> NhaCungCapCTs { get; set; }
        public virtual List<HoaDonCT> HoaDonCTs { get; set; }
    }
}
