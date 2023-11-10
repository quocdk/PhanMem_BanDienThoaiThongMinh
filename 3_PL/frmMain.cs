using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.Services;
using _2_BUS.IServices;
using FrmDuAn1;

namespace _3_PL
{
    public partial class frmMain : Form
    {
        INhanVienServices _inhanvienservice = new NhanVienServices();
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var layusername = Properties.Settings.Default.TKdaDN;
            var nhanvien = _inhanvienservice.GetAll().FirstOrDefault(x => x.UserName == layusername);
            if (nhanvien.LinkImage != null)
            {
                string linkanh = nhanvien.LinkImage.Replace(@"\", @"/");
                if (File.Exists(linkanh))
                {
                    ptb_nhanvien.Image = Image.FromFile(linkanh);
                    ptb_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            
            lb_name.Text = Convert.ToString(nhanvien.Role)  + ": " + nhanvien.Name;
        }
        private Form activeForm;

        public void ChangeForm(Form form)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            ctn_main.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            frmBanHang frmBanHang = new frmBanHang();
            ChangeForm(frmBanHang);
            //ctn_main.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmDichVu frmdichvu = new frmDichVu();
            ChangeForm(frmdichvu);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmHoaDon frmhoadon = new frmHoaDon();
            ChangeForm(frmhoadon);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            var role = _inhanvienservice.GetAll().Where(p => p.UserName == Properties.Settings.Default.TKdaDN).Select(p => p.Role).FirstOrDefault().ToString();
            if (role == "Quản Lý")
            {
                frmNhanVien frmnhanvien = new frmNhanVien();
                ChangeForm(frmnhanvien);
            }
            else if (role != "Quản Lý")
            {
                MessageBox.Show("Nhân viên không được sử dụng chức năng này!");
            }
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            ChangeForm(frmSanPham);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            frmDichVuSuaChua frmDichVuSuaChua = new frmDichVuSuaChua();
            ChangeForm(frmDichVuSuaChua);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_thongke_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frmThongKeDoanhThu = new frmThongKeDoanhThu();
            ChangeForm(frmThongKeDoanhThu);
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frmLogin = new frmDangNhap();
                frmLogin.ShowDialog();
                //this.Close();
            }
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            frmQUANLYKM frmkhuyenmai = new frmQUANLYKM();
            ChangeForm(frmkhuyenmai);
        }

        private void btn_loaidt_Click(object sender, EventArgs e)
        {
            frmLoaiDT frmLoaiDT = new frmLoaiDT();
            ChangeForm(frmLoaiDT);
        }

        private void btn_hangdt_Click(object sender, EventArgs e)
        {
            frmHang frmHang = new frmHang();
            ChangeForm(frmHang);
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            frmQUANLYNHACC frmnhacungcap = new frmQUANLYNHACC();
            ChangeForm(frmnhacungcap);
        }
    }
}
