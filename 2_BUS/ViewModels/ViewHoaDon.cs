using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class ViewHoaDon
    {
        public Bill hoaDon { get; set; }
        public Employee nhanVien { get; set; }
        public Custommer khachHang { get; set; }
        public Promotion khuyenMai { get; set; }

    }
}
