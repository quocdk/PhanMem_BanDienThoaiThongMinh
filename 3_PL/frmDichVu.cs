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

namespace _3_PL
{
    public partial class frmDichVu : Form
    {
        IDichVuServices _idichVuServices;
        IHangDTService _ihangDTServices;
        ISanPhamServices _isanPhamServices;
        IHoadonCTServices _ibillDetailServices;

        public frmDichVu()
        {
            InitializeComponent();
            _idichVuServices = new DichVuServices();
            _ihangDTServices = new HangDTService();
            _isanPhamServices = new SanPhamServices();
            _ibillDetailServices = new HoaDonCTServices();
        }

        private void btnShowDV_Click(object sender, EventArgs e)
        {
            #region dk
            var sl = (from x in _idichVuServices.GetAll() select x.Id).ToList();
            string IdSanPham = "";
            for (int i = 0; i < sl.Count; i++)
            {

                if (i < 10)
                {
                    IdSanPham = "DV0000" + Convert.ToString(i);

                }
                else if (i < 100)
                {
                    IdSanPham = "Dv000" + Convert.ToString(i);

                }
                else if (i < 1000)
                {
                    IdSanPham = "DV00" + Convert.ToString(i);

                }
                else if (i < 10000)
                {
                    IdSanPham = "DV0" + Convert.ToString(i);

                }
                else
                {
                    IdSanPham = "DV" + Convert.ToString(i);

                }
            }
            {




            }


           



            #endregion
            #region list


            var dgvv = (from x in _idichVuServices.GetAll()
                        select new
                        {
                            IDDichVu = x.Id,
                            tenDichVu = x.Name,
                            loaiDichVu = x.TypeService,
                            GiaTien = x.Price
                        }).ToList();
            var dgv = (from x in dgvv orderby x.loaiDichVu select x).ToList();
            #endregion
            dgvDichVuDV.DataSource = dgv;
            MessageBox.Show("Show thành công.");
        }

        private void cbbLoaiDichVuDV_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            #region list


            var dgv = (from x in _idichVuServices.GetAll()
                       select new
                       {
                           IDDichVu = x.Id,
                           tenDichVu = x.Name,
                           loaiDichVu = x.TypeService,
                           GiaTien = x.Price
                       }).ToList();
            #endregion


            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtTenDichVuDV.Text == null || txtGiaTienDV.Text == null || cbbLoaiDichVuDV.Text == "Trống")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    Service dich = new Service();
                    dich.Id = Guid.NewGuid();
                    dich.Name = txtTenDichVuDV.Text;
                    dich.TypeService = cbbLoaiDichVuDV.Text;
                    dich.Price = decimal.Parse(txtGiaTienDV.Text);
                    _idichVuServices.Add(dich);
                    dgvDichVuDV.DataSource = dgv;
                    MessageBox.Show("Thêm thành công.");
                    frmDichVu_Load(sender, e);
                }





            }
        }

        private void dgvDichVuDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDichVuDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvDichVuDV.Rows[e.RowIndex];
            txtTenDichVuDV.Text = data.Cells[1].Value.ToString();
            txtIdDichVuDV.Text = data.Cells[0].Value.ToString();
            cbbLoaiDichVuDV.Text = data.Cells[2].Value.ToString();
            txtGiaTienDV.Text = data.Cells[3].Value.ToString();

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (txtGiaTienDV.Text == "" || txtTenDichVuDV.Text == "" || cbbLoaiDichVuDV.Text == "Trống" || txtIdDichVuDV.Text == "")
            {
                MessageBox.Show("Không thể sửa nếu chưa nhập đủ thông tin");
            }
            else

            {
                var dich = (from x in _idichVuServices.GetAll() where x.Id == Guid.Parse(txtIdDichVuDV.Text) select x).FirstOrDefault();
                dich.Name = txtTenDichVuDV.Text;
                dich.TypeService = cbbLoaiDichVuDV.Text;
                dich.Price = int.Parse(txtGiaTienDV.Text);
                _idichVuServices.Update(dich);
                MessageBox.Show("Sửa thành công.");
                txtGiaTienDV.Text = "";
                txtIdDichVuDV.Text = "";
                txtTenDichVuDV.Text = "";
                cbbLoaiDichVuDV.Text = "";
                dgvDichVuDV.DataSource = (from x in _idichVuServices.GetAll() select x).ToList();
            }
        }

        private void btnTimKiemDV_Click(object sender, EventArgs e)
        {
            var dgv = (from x in _idichVuServices.GetAll() where x.Name.StartsWith($"{txtTimKiemDV.Text}") select x).ToList();
            dgvDichVuDV.DataSource = dgv;
        }

        private void txtGiaTienDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaTienDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
