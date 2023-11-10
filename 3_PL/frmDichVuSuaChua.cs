using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class frmDichVuSuaChua : Form
    {

        IQuanLyKMServices _ikhuyenMaiServices;
        ISanPhamServices _isanPhamServices;
        IQuanLyNhaCCServices _inhaCungCapServices;
        IHangDTService _ihangDTServices;
        ILoaiDTService _iloaiDTServices;
        IHoadonCTServices _ibillDetailServices;
        IDichVuServices _idichVuServices;
        public frmDichVuSuaChua()
        {
            InitializeComponent();

            _ikhuyenMaiServices = new QlkhuyenmaiServices();
            _idichVuServices = new DichVuServices();
            _ibillDetailServices = new HoaDonCTServices();
            _isanPhamServices = new SanPhamServices();
            _ihangDTServices = new HangDTService();
            _iloaiDTServices = new LoaiDTService();
            _inhaCungCapServices = new QuanLyNhaCCServices();

        }

        private void cbbTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var list = (from dichvu in _idichVuServices.GetAll()
                        select new
                        {
                            IDDichVu = dichvu.Id,
                            TenDichVu = dichvu.Name,

                            LoaiDichVu = dichvu.TypeService,
                            GiaTien = dichvu.Price,
                        }).ToList();
            if (txtTimKiem.Text == null)
            {
                var dgv = (from x in list select x).ToList();
                dgvDanhSachDichVu.DataSource = dgv;
            }
            else
            {
                var dgv = (from x in list where x.TenDichVu.StartsWith($"{txtTimKiem.Text}") select x).ToList();
                dgvDanhSachDichVu.DataSource = dgv;
            }

        }
        private void frmDichVuSuaChua_Load(object sender, EventArgs e)
        {
            #region list dgv


            #region list dgv


            var list = (from dichvu in _idichVuServices.GetAll()
                        select new
                        {
                            IDDichVu = dichvu.Id,
                            TenDichVu = dichvu.Name,

                            LoaiDichVu = dichvu.TypeService,
                            GiaTien = dichvu.Price,
                        }).ToList();
            #endregion
            #endregion


            #region Dk lọc


            if (cbbLoaiDichVu.Text == "Trống")
            {
                if (txtTimKiem.Text == null)
                {
                    var dgv = (from x in list select x).ToList();
                    dgvDanhSachDichVu.DataSource = dgv;
                }
                else
                {
                    var dgv = (from x in list where x.TenDichVu.StartsWith($"{txtTimKiem.Text}") select x).ToList();
                    dgvDanhSachDichVu.DataSource = dgv;
                }


            }
            else
            {

            }
            #endregion
            var khuyenmai = (from x in _ikhuyenMaiServices.GetAll() select x.Name).ToList();

            cbbKhuyenMai.DataSource = khuyenmai;



        }

        private void t_Click(object sender, EventArgs e)
        {
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemVaoDonHang_Click(object sender, EventArgs e)
        {
            if (dgvGioHangDichVu.DataBindings == null)
            {
                MessageBox.Show("Vui lòng thêm dịch vụ vào giỏ hàng.", "Thông báo");
            }

        }

        private void btnXoaDonHang_Click(object sender, EventArgs e)
        {
            txtIdHoaDon.Text = null;
            txtTenKhachHang.Text = null;
            txtSoDienThoai.Text = null;
            txtThanhTien.Text = null;
            cbbKhuyenMai.Text = "Trống";
            txtGiamGia.Text = null;
            txtTongTien.Text = null;
            txtKhachThanhToan.Text = null;
            txtTienThua.Text = null;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" || txtSoDienThoai.Text == "" || cbbKhuyenMai.Text == "" || txtKhachThanhToan.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo");
            }
            else if (int.Parse(txtKhachThanhToan.Text) < int.Parse(txtTongTien.Text))
            {
                MessageBox.Show("Khách chưa đưa đủ tiền.", "Thông báo");
            }

        }

        private void dgvDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //thêm
            #region list dgv


            var list = (from dichvu in _idichVuServices.GetAll()
                        select new
                        {
                            IDDichVu = dichvu.Id,
                            TenDichVu = dichvu.Name,
                            LoaiDichVu = dichvu.TypeService,
                            GiaTien = dichvu.Price,
                        }).ToList();
            #endregion

            dgvGioHangDichVu.Rows.Add(
                           dgvDanhSachDichVu.Rows[e.RowIndex].Cells[0].Value.ToString(),
                           dgvDanhSachDichVu.Rows[e.RowIndex].Cells[1].Value.ToString(),
                           dgvDanhSachDichVu.Rows[e.RowIndex].Cells[2].Value.ToString(),
                           dgvDanhSachDichVu.Rows[e.RowIndex].Cells[3].Value.ToString()
                           );



            if (dgvDanhSachDichVu.DataBindings == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ.", "Thông báo");
            }
        }

        private void cbbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region list dgv


            var list = (from dichvu in _idichVuServices.GetAll()
                        select new
                        {
                            IDDichVu = dichvu.Id,
                            TenDichVu = dichvu.Name,

                            LoaiDichVu = dichvu.TypeService,
                            GiaTien = dichvu.Price,
                        }).ToList();
            #endregion
            if (cbbLoaiDichVu.Text == "Trống")
            {
                if (txtTimKiem.Text == null)
                {
                    var dgv = (from x in list select x).ToList();
                    dgvDanhSachDichVu.DataSource = dgv;
                }
                else
                {
                    var dgv = (from x in list where x.TenDichVu.StartsWith($"{txtTimKiem.Text}") select x).ToList();
                    dgvDanhSachDichVu.DataSource = dgv;
                }
            }
        }

        private void btnXoa1DichVu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvDanhSachDichVu.SelectedRows)
            {
                dgvGioHangDichVu.Rows.Remove(item);
            }
        }

        private void btnXoa1DichVu_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvDanhSachDichVu.SelectedRows)
            {
                dgvGioHangDichVu.Rows.Remove(item);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            dgvGioHangDichVu.Rows.Clear();
        }
    }
}

