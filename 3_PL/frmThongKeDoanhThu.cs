using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDuAn1
{
    public partial class frmThongKeDoanhThu : Form
    {
        private IHoaDonServices hoaDonServices;
        private IHoadonCTServices hoaDonCTServices;
        private ISanPhamServices sanPhamServices;
        private INhanVienServices nhanVienServices;
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            hoaDonServices = new HoaDonServices();
            hoaDonCTServices = new HoaDonCTServices();
            sanPhamServices = new SanPhamServices();
            nhanVienServices = new NhanVienServices();
            LoadDataThongke();
        }
        private void LoadDataThongke()
        {
            cbbthongke.Items.Add("Theo sản phẩm");
            cbbthongke.Items.Add("Theo nhân viên");
            cbbThang.Items.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            cbbNam.Items.Add(new List<int> { 2020, 2021, 2022, 2023, 2024, 2055, 2026, 2027, 2028, 2029, 2030 });
            lbTongSoHoaDon.Text = hoaDonServices.GetAll().Count().ToString();
            var a = hoaDonServices.GetAll().Select(x => x.TotalPrice).ToList();
            float tongtien = 0;
            foreach (var x in a)
            {
                tongtien += float.Parse(x.ToString());
            }
            lbDoanhthu.Text = tongtien.ToString();
            var b = (from x in hoaDonServices.GetAll()
                     join y in hoaDonCTServices.GetAll() on x.Id equals y.BillId
                     select y.Quantity).ToList();
            int spban = 0;
            foreach (var x in b)
            {
                spban += int.Parse(x.ToString());
            }
            lbSoSanPhamBan.Text = spban.ToString();

            
                dgvSpBan.Rows.Clear();
                var soluongsp = from x in hoaDonCTServices.GetAll()
                                group x by new
                                {
                                    x.ProductId,
                                    x.Quantity
                                }
                                into g
                                select new BillDetail
                                {
                                    ProductId = g.Key.ProductId,
                                    Quantity = g.Sum(x => x.Quantity)
                                };

                var soluongcuasp = from x in soluongsp
                                   join y in sanPhamServices.GetAll() on x.ProductId equals y.Id
                                   select new
                                   {
                                       MaSanPham = x.ProductId,
                                       TenSanPham = y.Name,
                                       GiaBan = y.Price,
                                       SoLuongBan = x.Quantity,
                                       DoanhThu = y.Price * x.Quantity
                                   };
                foreach (var x in soluongcuasp)
                {
                    dgvSpBan.Rows.Add(x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuongBan, x.DoanhThu);
                }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbTongSoHoaDon.Text = hoaDonServices.GetAll().Where(x => x.CreateDate == DateTime.Parse(dateTimePicker1.Text)).Count().ToString();
            var a = hoaDonServices.GetAll().Where(x => x.CreateDate == DateTime.Parse(dateTimePicker1.Text)).Select(x => x.TotalPrice).ToList();
            float tongtien = 0;
            foreach (var x in a)
            {
                tongtien += float.Parse(x.ToString());
            }
            lbDoanhthu.Text = tongtien.ToString();
            var b = (from x in hoaDonServices.GetAll()
                     join y in hoaDonCTServices.GetAll() on x.Id equals y.BillId
                     where x.CreateDate == DateTime.Parse(dateTimePicker1.Text)
                     select y.Quantity).ToList();
            int spban = 0;
            foreach (var x in b)
            {
                spban += int.Parse(x.ToString());
            }
            lbSoSanPhamBan.Text = spban.ToString();

            dgvSpBan.Rows.Clear();
            var soluongsp = from x in hoaDonCTServices.GetAll()
                            group x by new
                            {
                                x.BillId,
                                x.ProductId,
                                x.Quantity
                            }
                            into g
                            select new BillDetail
                            {
                                BillId = g.Key.BillId,
                                ProductId = g.Key.ProductId,
                                Quantity = g.Sum(x => x.Quantity)
                            };

            var soluongcuasp = from x in soluongsp
                               join y in sanPhamServices.GetAll() on x.ProductId equals y.Id
                               join z in hoaDonServices.GetAll() on x.BillId equals z.Id
                               where z.CreateDate== DateTime.Parse(dateTimePicker1.Text)
                               select new
                               {
                                   MaSanPham = x.ProductId,
                                   TenSanPham = y.Name,
                                   GiaBan = y.Price,
                                   SoLuongBan = x.Quantity,
                                   DoanhThu = y.Price * x.Quantity
                               };
            foreach (var x in soluongcuasp)
            {
                dgvSpBan.Rows.Add(x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuongBan, x.DoanhThu);
            }
        }

        private void cbbthongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbthongke.Text == "Theo sản phẩm")
            {
                dgvSpBan.Rows.Clear();
                var soluongsp = from x in hoaDonCTServices.GetAll()
                                group x by new
                                {
                                    x.ProductId,
                                    x.Quantity
                                }
                                into g
                                select new BillDetail
                                {
                                    ProductId = g.Key.ProductId,
                                    Quantity = g.Sum(x => x.Quantity)
                                };

                var soluongcuasp = from x in soluongsp
                                   join y in sanPhamServices.GetAll() on x.ProductId equals y.Id
                                   select new
                                   {
                                       MaSanPham = x.ProductId,
                                       TenSanPham = y.Name,
                                       GiaBan = y.Price,
                                       SoLuongBan = x.Quantity,
                                       DoanhThu = y.Price * x.Quantity
                                   };
                foreach (var x in soluongcuasp)
                {
                    dgvSpBan.Rows.Add(x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuongBan, x.DoanhThu);
                }
            }
            //else if (cbbthongke.Text == "Theo nhân viên")
            //{
            //    dgvSpBan.Rows.Clear();
            //    var soluongsp = from x in hoaDonCTServices.GetAll()
            //                    group x by new
            //                    {
            //                        x.BillId,
            //                        x.ProductId,
            //                        x.Quantity
            //                    }
            //                    into g
            //                    select new BillDetail
            //                    {
            //                        BillId=g.Key.BillId,
            //                        ProductId = g.Key.ProductId,
            //                        Quantity = g.Sum(x => x.Quantity)
            //                    };
            //    var soluongnhanvienban = from x in hoaDonServices.GetAll()
            //                             join y in soluongsp on x.Id equals y.BillId
            //                             join z in nhanVienServices.GetAll() on x.EmployeeId equals z.Id
            //                             select new
            //                             {
            //                                 MaNhanVien = x.EmployeeId,
            //                                 TenNhanVien = z.Name,
            //                                 SoLuongBan = y.Quantity,
            //                                 DoanhThu = x.TotalPrice
            //                             };
            //    foreach (var x in soluongnhanvienban)
            //    {
            //        dgvSpBan.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.SoLuongBan, x.DoanhThu);
            //    }
        }
    }
}

