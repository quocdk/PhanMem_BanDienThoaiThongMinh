using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class HoaDonCT
    {
        public Guid Id { get; set; }
        public Guid DichVuId { get; set; }
        public Guid HoaDonId { get; set; }
        public Guid SanPhamId { get; set; }
        public Guid KhuyenMaiId { get; set; }
        public int Quantity { get; set; }
        public decimal IntoMoney { get; set; }
        public virtual DichVu DichVu { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
