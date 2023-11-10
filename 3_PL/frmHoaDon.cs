using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Buffers;
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
    public partial class frmHoaDon : Form
    {
        private IHoaDonServices hoaDonServices;
        private IHoadonCTServices hoaDonCTServices;
        private ISanPhamServices sanPhamServices;
        private IHangDTService hangDTServices;
        private ILoaiDTService loaiDTServices;
        private IQuanLyKMServices khuyenMaiServices;
        private INhanVienServices nhanVienServices;
        private IKhachHangServices khachHangServices;
        public frmHoaDon()
        {
            InitializeComponent();
            hoaDonServices = new HoaDonServices();
            hoaDonCTServices = new HoaDonCTServices();
            sanPhamServices = new SanPhamServices();
            hangDTServices = new HangDTService();
            loaiDTServices = new LoaiDTService();
            khuyenMaiServices = new QlkhuyenmaiServices();
            nhanVienServices = new NhanVienServices();
            khachHangServices = new KhachHangServices();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            //cbbTk.Items.Add("Số điện thoại");
            //cbbTk.Items.Add("Tên khách hàng");

            var hd = from x in hoaDonServices.GetAll()
                     join y in nhanVienServices.GetAll() on x.EmployeeId equals y.Id
                     join z in khachHangServices.GetAll() on x.CustommerId equals z.Id
                     join a in hoaDonCTServices.GetAll() on x.Id equals a.BillId
                     join b in khuyenMaiServices.GetAll() on a.PromotionId equals b.Id
                     orderby x.CreateDate descending
                     select new
                     {
                         Id = x.Id,
                         TenNhanVien = y.Name,
                         TenKhachHang = z.Name,
                         SoDienThoai = z.PhoneNumber,
                         NgayTao = x.CreateDate,
                         TongTien = x.TotalPrice,
                         KhuyenMai = b.Name,
                         GiamGia = x.TotalPrice * decimal.Parse( b.Index.ToString()) / 100,
                         KhachPhaiTra = x.TotalPrice - (x.TotalPrice * decimal.Parse(b.Index.ToString()) / 100)
                     };
            //dgvHoaDon.DataSource = hd;
            foreach (var x in hd.Distinct())
            {
                dgvHoaDon.Rows.Add(x.Id, x.TenNhanVien, x.TenKhachHang, x.SoDienThoai, x.NgayTao, x.TongTien, x.KhuyenMai, x.GiamGia, x.KhachPhaiTra);
            }
            dgvHoaDon.Columns[0].Visible = false;
            DgvHoaDonCT.Columns[0].Visible = false;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            if (txtTkHd.Text != null && cbbTk.Text != null)
            {
                if (cbbTk.Text == "Số điện thoại")
                {
                    dgvHoaDon.Rows.Clear();
                    var hdsdt = from x in hoaDonServices.GetAll()
                                join y in nhanVienServices.GetAll() on x.EmployeeId equals y.Id
                                join z in khachHangServices.GetAll() on x.CustommerId equals z.Id
                                join a in hoaDonCTServices.GetAll() on x.Id equals a.BillId
                                join b in khuyenMaiServices.GetAll() on a.PromotionId equals b.Id
                                where z.PhoneNumber == txtTkHd.Text
                                select new
                                {
                                    Id = x.Id,
                                    TenNhanVien = y.Name,
                                    TenKhachHang = z.Name,
                                    SoDienThoai = z.PhoneNumber,
                                    NgayTao = x.CreateDate,
                                    TongTien = x.TotalPrice,
                                    KhuyenMai = b.Name,
                                    GiamGia = x.TotalPrice - b.Index / 100,
                                    KhachPhaiTra = x.TotalPrice - (x.TotalPrice - b.Index / 100)
                                };
                    foreach (var x in hdsdt.Distinct())
                    {
                        dgvHoaDon.Rows.Add(x.Id, x.TenNhanVien, x.TenKhachHang, x.SoDienThoai, x.NgayTao, x.TongTien, x.KhuyenMai, x.GiamGia, x.KhachPhaiTra);
                    }
                }
                else if (cbbTk.Text == "Tên khách hàng")
                {
                    dgvHoaDon.Rows.Clear();
                    var hdtkh = from x in hoaDonServices.GetAll()
                                join y in nhanVienServices.GetAll() on x.EmployeeId equals y.Id
                                join z in khachHangServices.GetAll() on x.CustommerId equals z.Id
                                join a in hoaDonCTServices.GetAll() on x.Id equals a.BillId
                                join b in khuyenMaiServices.GetAll() on a.PromotionId equals b.Id
                                where z.Name == txtTkHd.Text
                                select new
                                {
                                    Id = x.Id,
                                    TenNhanVien = y.Name,
                                    TenKhachHang = z.Name,
                                    SoDienThoai = z.PhoneNumber,
                                    NgayTao = x.CreateDate,
                                    TongTien = x.TotalPrice,
                                    KhuyenMai = b.Name,
                                    GiamGia = x.TotalPrice - b.Index / 100,
                                    KhachPhaiTra = x.TotalPrice - (x.TotalPrice - b.Index / 100)
                                };
                    foreach (var x in hdtkh.Distinct())
                    {
                        dgvHoaDon.Rows.Add(x.Id, x.TenNhanVien, x.TenKhachHang, x.SoDienThoai, x.NgayTao, x.TongTien, x.KhuyenMai, x.GiamGia, x.KhachPhaiTra);
                    }
                }
            }
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idhd = Guid.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            var hdct = from x in hoaDonCTServices.GetAll()
                       join y in sanPhamServices.GetAll() on x.ProductId equals y.Id
                       where x.BillId == idhd
                       select new
                       {
                           ID = x.Id,
                           TenSanPham = y.Name,
                           DonGia = y.Price,
                           SoLuong = x.Quantity,
                           ThanhTien = x.IntoMoney
                       };
            DgvHoaDonCT.Rows.Clear();
            foreach (var x in hdct.Distinct())
            {
                DgvHoaDonCT.Rows.Add(x.ID, x.TenSanPham, x.DonGia, x.SoLuong, x.ThanhTien);
            }
        }

        private void dtpNgayTao_ValueChanged(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            var hdsdt = from x in hoaDonServices.GetAll()
                        join y in nhanVienServices.GetAll() on x.EmployeeId equals y.Id
                        join z in khachHangServices.GetAll() on x.CustommerId equals z.Id
                        join a in hoaDonCTServices.GetAll() on x.Id equals a.BillId
                        join b in khuyenMaiServices.GetAll() on a.PromotionId equals b.Id
                        where x.CreateDate == dtpNgayTao.Value.Date
                        select new
                        {
                            Id = x.Id,
                            TenNhanVien = y.Name,
                            TenKhachHang = z.Name,
                            SoDienThoai = z.PhoneNumber,
                            NgayTao = x.CreateDate,
                            TongTien = x.TotalPrice,
                            KhuyenMai = b.Name,
                            GiamGia = x.TotalPrice - b.Index / 100,
                            KhachPhaiTra = x.TotalPrice - (x.TotalPrice - b.Index / 100)
                        };
            foreach (var x in hdsdt.Distinct())
            {
                dgvHoaDon.Rows.Add(x.Id, x.TenNhanVien, x.TenKhachHang, x.SoDienThoai, x.NgayTao, x.TongTien, x.KhuyenMai, x.GiamGia, x.KhachPhaiTra);
            }
        }

        
    }
}
