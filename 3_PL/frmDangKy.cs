using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IServices;
using _2_BUS.Services;
using _1_DAL.Entities;
using System.Text.RegularExpressions;
using FrmDuAn1;

namespace _3_PL
{
    public partial class frmDangKy : Form
    {
        INhanVienServices _inhanvienservice = new NhanVienServices();
        Employee employee;
        string linkimage = "";
        public frmDangKy()
        {
            InitializeComponent();
            dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            employee = new Employee();
            
        }
        public bool checkInput()
        {
            string email = txb_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Email không hợp lệ!!!");
                txb_email.Text = "";
                return false;
            }
            else if (txb_hovaten.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên nhân viên");
                return false;
            }
            else if (txb_hovaten.Text.Length < 8)
            {
                MessageBox.Show("Tên nhân viên phải có ít nhất 8 kí tự");
                return false;
            }
            else if (txb_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");
                return false;
            }
            else if (!txb_sdt.Text.All(char.IsNumber))
            {
                MessageBox.Show("Số điện thoại phải là số !");
                return false;
            }
            else if (txb_matkhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ !");
                return false;
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Bạn chưa tải ảnh đại diện !");
                return false;
            }else if (!rb_dongy.Checked)
            {
                MessageBox.Show("Bạn chưa đồng ký điều khoản.");
            }
            return true;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(linkimage, Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage)), true);
            linkimage = Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage));
            var chechEmail = _inhanvienservice.GetAll().FirstOrDefault(x => x.Email == txb_email.Text);
            if (!checkInput())
            {

            }
            else
            {
                if (chechEmail != null)
                {
                    MessageBox.Show("Email này đã được sử dụng, vui lòng sử dung email khác!");
                }
                else
                {
                    Employee nv = new Employee()
                    {
                        Name = txb_hovaten.Text,
                        Email = txb_email.Text,
                        PhoneNumber = txb_sdt.Text,
                        BirthDay = dtp_ngaysinh.Value,
                        Sex = rb_nam.Checked,
                        Role = "Quản Lý",
                        UserName = txb_username.Text,
                        PassWord = txb_matkhau.Text,
                        Status = true,
                        LinkImage = linkimage
                    };
                    _inhanvienservice.Add(nv);
                    MessageBox.Show("Đăng ký thành công. Chúc mừng bạn!");
                    this.Hide();
                    frmBanHang frmbanhang = new frmBanHang();
                    frmbanhang.ShowDialog();
                    this.Close();

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                linkimage = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            

        }
    }
}
