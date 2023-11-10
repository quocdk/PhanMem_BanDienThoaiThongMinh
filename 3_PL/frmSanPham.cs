using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class frmSanPham : Form
    {
        ISanPhamServices _isanPhamServices;
        IQuanLyNhaCCServices _inhaCungCapServices;
        INhaCungCapCTServices _inhacungcapctservice;
        IHangDTService _ihangDTServices;
        ILoaiDTService _iloaiDTServices;
        IHoadonCTServices _ibillDetailServices;
        IDichVuServices _idichVuServices;
        
        public Product _product;
        string linkavatar = "";
        string tensp = "";
        public frmSanPham()
        {
            InitializeComponent();
            _product = new Product();
            _idichVuServices = new DichVuServices();
            _ibillDetailServices = new HoaDonCTServices();
            _isanPhamServices = new SanPhamServices();
            _ihangDTServices = new HangDTService();
            _iloaiDTServices = new LoaiDTService();
            _inhaCungCapServices = new QuanLyNhaCCServices();
            _inhacungcapctservice = new NhaCungCapCTService();
            LoadDaTa();

        }
        public void LoadDaTa()
        {
            dgvSanPhamSP.ColumnCount = 13;
            dgvSanPhamSP.Columns[0].Name = "Id";
            dgvSanPhamSP.Columns[0].Visible = false;
            dgvSanPhamSP.Columns[1].Name = "Tên SP";
            dgvSanPhamSP.Columns[2].Name = "Hãng SP";
            dgvSanPhamSP.Columns[3].Name = "Loại";
            dgvSanPhamSP.Columns[4].Name = "Nhà cung cấp";
            dgvSanPhamSP.Columns[5].Name = "Số lượng";
            dgvSanPhamSP.Columns[6].Name = "Giá nhập";
            dgvSanPhamSP.Columns[7].Name = "Giá bán";
            dgvSanPhamSP.Columns[8].Name = "Thời gian";
            dgvSanPhamSP.Columns[9].Name = "Trạng thái";
            dgvSanPhamSP.Columns[10].Name = "Mô tả";
            dgvSanPhamSP.Columns[11].Name = "linh ảnh";
            dgvSanPhamSP.Columns[11].Visible = false;
                dgvSanPhamSP.Rows.Clear();
                var data = (from a in _isanPhamServices.GetAll()

                            join c in _ihangDTServices.GetAll() on a.PhoneCompanyId equals c.Id
                            join d in _iloaiDTServices.GetAll() on a.PhoneTypeId equals d.Id
                            join e in _inhacungcapctservice.GetAll() on a.SupplierDetailId equals e.Id
                            join x in _inhaCungCapServices.GetAll() on e.SupplierId equals x.Id

                            select new
                            {
                                Id = a.Id,
                                Name = a.Name,
                                PhoneCompany = c.Name,
                                PhoneType = c.Name,
                                SupplierName = d.Name,
                                Quantity = a.Quantity,
                                Price = a.Price,
                                ImportPrice = a.ImportPrice,
                                WarrantyPeriod = a.WarrantyPeriod,
                                Descriptions = a.Descriptions,
                                status = a.Status,
                                linkanh = a.LinkAnh

                            }).ToList();

                foreach (var item in data)
                {
                    dgvSanPhamSP.Rows.Add(item.Id, item.Name, item.PhoneCompany, item.PhoneType, item.SupplierName, item.Quantity, item.ImportPrice, item.Price, item.WarrantyPeriod, item.status, item.Descriptions, item.linkanh);
                }

        }

        private void btnShowSP_Click(object sender, EventArgs e)
        {
            LoadDaTa();
        }
        private void ptb_anhsp_Click(object sender, EventArgs e)
        {
            
        }


        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            foreach (var sp in _isanPhamServices.GetAll())
            {

            }

            #region dk
            var sl = (from x in _isanPhamServices.GetAll() select x.Id).ToList().Count;
            var sll = sl + 1;
            string IdSanPham = "";
            if (sll < 10)
            {
                IdSanPham = "SP0000" + Convert.ToString(sll);
            }
            else if (sll < 100)
            {
                IdSanPham = "SP000" + Convert.ToString(sll);
            }
            else if (sll < 1000)
            {
                IdSanPham = "SP00" + Convert.ToString(sll);
            }
            else if (sll < 10000)
            {
                IdSanPham = "SP0" + Convert.ToString(sll);
            }
            else
            {
                IdSanPham = "SP" + Convert.ToString(sll);
            }

            #endregion
            #region list


            var list = (from sp in _isanPhamServices.GetAll()
                        join billD in _ibillDetailServices.GetAll() on sp.Id equals billD.ProductId
                        join loaidt in _iloaiDTServices.GetAll() on sp.PhoneTypeId equals loaidt.Id
                        join hangdt in _ihangDTServices.GetAll() on sp.PhoneCompanyId equals hangdt.Id
                        join nhacc in _inhaCungCapServices.GetAll() on billD.PromotionId equals nhacc.Id
                        select new
                        {
                            IDSanPham = IdSanPham,
                            TenSanPham = sp.Name,
                            Hang = hangdt.Name,
                            LoaiSanPham = loaidt.Name,
                            NhaCungCap = nhacc.Name,
                            SoLuong = sp.Quantity,
                            GiaTien = sp.Price,
                            ThoiGianBaoHanh = sp.WarrantyPeriod,
                            TrangThai = sp.Status == 1 ? "Còn" : "Hết",
                            MoTa = sp.Descriptions,
                            LinkAnh = sp.LinkAnh,
                        }).ToList();
            #endregion
            if (cbbLocHangSP.Text == "Trống" && cbbLocLoaiSanPhamSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;

            }
            else if (cbbLocHangSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.LoaiSanPham == cbbLocLoaiSanPhamSP.Text where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;
            }
            else if (cbbLocLoaiSanPhamSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.Hang == cbbLocHangSP.Text where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;
            }
        }
        public bool checknhap()
        {
            if (txtTenSanPhamSP.Text == "" || txtGiaBan.Text == "" || txtGiaTienSP.Text == "" || txtMoTaSP.Text == "" || cbbHangSP.Text == "" || cbbLoaiSanPhamSP.Text == ""  || txtThoiGianBaoHanhSP.Text == "") return false;
            return true;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //var p = _isanPhamServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(txtIDSanPham.Text));
            var tsp = _isanPhamServices.GetAll().FirstOrDefault(p => p.Name == txtTenSanPhamSP.Text);
            int gn, gb;

            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            //else if (p != null)
            //{
            //    MessageBox.Show("Mã sản phẩm đã tồn tại", "Chú ý");
            //}
            else if (tsp != null)
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại", "Chú ý");
            }
            else if (Convert.ToDecimal(txtGiaTienSP.Text) > Convert.ToDecimal(txtGiaBan.Text))
            {
                MessageBox.Show("Giá bán phải cao hơn giá nhập", "Chú ý");
            }
            //else if (linkavatar == "")
            //{
            //    MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm", "Chú ý");
            //}
            else
            {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkavatar, Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar)), true);
                    linkavatar = Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar));
                    _product = new Product();
                    _product.Id = Guid.NewGuid();
                    //_product.MaDT = txb_masp.Text;
                    _product.Name = txtTenSanPhamSP.Text;
                    _product.ImportPrice = Convert.ToDecimal(txtGiaTienSP.Text);
                    _product.Price = Convert.ToDecimal(txtGiaBan.Text);
                    _product.PhoneCompanyId = cbbHangSP.Text == "cphone" ? Guid.Parse("B8079D0F-3710-4E6E-9749-33E4A3F5DC0F") : cbbHangSP.Text == "Iphone" ? Guid.Parse("7D05E20A-320A-47E0-93FC-A8C6970DECC1") : Guid.Parse("52360786-F447-44CB-A146-C86BE1D54058");
                _product.PhoneTypeId = cbbLoaiSanPhamSP.Text == "cellphone" ? Guid.Parse("1F98A930-6D81-46CD-AB61-D76C4E866B10") :  Guid.Parse("56997555-00D8-4584-877C-F3D709C50A87");
                _product.SupplierDetailId = Guid.Parse("6DDC1B41-50FD-4F3C-AAFF-D1CFD6E31B39");
                    _product.WarrantyPeriod = txtThoiGianBaoHanhSP.Text;
                    _product.Quantity = int.Parse(nudSoLuongSP.Text);
                    _product.LinkAnh = linkavatar;
                    _product.Descriptions = txtMoTaSP.Text;
                    _product.Status = rb_conhang.Checked == true ? 1 : 0;
                    _isanPhamServices.Add(_product);
                    MessageBox.Show("Thêm sản phẩm thành công");

                    LoadDaTa();


                
            }
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
           
        }
        private void cbbHangSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbLoaiSanPhamSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbNhaCungCapSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iddddd_Click(object sender, EventArgs e)
        {

        }

        private void iddddd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPhamSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPhamSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dgvSanPhamSP.Rows[e.RowIndex];
            txtIDSanPham.Text = dgvSanPhamSP.Rows[0].ToString();
            txtTenSanPhamSP.Text = dgvSanPhamSP.Rows[1].ToString();
            cbbHangSP.Text = dgvSanPhamSP.Rows[2].ToString();
            cbbLoaiSanPhamSP.Text = dgvSanPhamSP.Rows[3].ToString();
            cbbNhaCungCapSP.Text = dgvSanPhamSP.Rows[4].ToString();
            nudSoLuongSP.Value = int.Parse(dgvSanPhamSP.Rows[5].ToString());
            txtGiaTienSP.Text = dgvSanPhamSP.Rows[6].ToString();
            txtGiaBan.Text = dgvSanPhamSP.Rows[7].ToString();
            txtThoiGianBaoHanhSP.Text = dgvSanPhamSP.Rows[8].ToString();
            txtMoTaSP.Text = dgvSanPhamSP.Rows[9].ToString();
        }

        private void cbbLocLoaiSanPhamSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            var loai = (from x in _iloaiDTServices.GetAll() select x.Name).ToList();
            var hang = (from x in _ihangDTServices.GetAll() select x.Name).ToList();
            var ncc = (from x in _inhaCungCapServices.GetAll() select x.Name).ToList();
            cbbNhaCungCapSP.DataSource = ncc;
            cbbLocHangSP.DataSource = hang;
            cbbHangSP.DataSource = hang;
            cbbLoaiSanPhamSP.DataSource = loai;
            cbbLocLoaiSanPhamSP.DataSource = loai;
        }



        private void txtGiaTienSP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiaTienSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void nudSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ptb_anh_s_P_Click(object sender, EventArgs e)
        {
            

            
        }

        private void ptb_san_p_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                linkavatar = ofd.FileName;
                ptb_san_p.Image = Image.FromFile(ofd.FileName);
                ptb_san_p.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }
}


