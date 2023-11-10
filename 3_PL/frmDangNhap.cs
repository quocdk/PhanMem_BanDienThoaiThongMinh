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
using System.Net.Mail;
using System.Net;

namespace _3_PL
{
    public partial class frmDangNhap : Form
    {
        INhanVienServices _inhanvienservice;
        public frmDangNhap()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienServices();
            
            cb_nhomk.Checked = true;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txb_username.Text = Properties.Settings.Default.username;
            txb_password.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.username != "")
            {
                cb_nhomk.Checked = true;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var intomainform = _inhanvienservice.GetAll().Where(x => x.UserName == txb_username.Text && x.PassWord == txb_password.Text).FirstOrDefault();
            if(intomainform != null)
            {
                this.Hide();
                frmMain frmmai = new frmMain();
                frmmai.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void cb_nhomk_CheckedChanged(object sender, EventArgs e)
        {
            if (txb_username.Text != "" && txb_password.Text != "")
            {
                if(cb_nhomk.Checked == true)
                {
                    string saveusername =txb_username.Text;
                    string savepassword =txb_password.Text;
                    Properties.Settings.Default.username = saveusername;
                    Properties.Settings.Default.password = savepassword;
                    Properties.Settings.Default.TKdaDN = txb_username.Text;
                    Properties.Settings.Default.MKdaDN = txb_password.Text;
                    Properties.Settings.Default.Save();

                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.TKdaDN = txb_username.Text;
                    Properties.Settings.Default.MKdaDN = txb_password.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void lb_forgetpassword_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frmqmk = new frmQuenMatKhau();
            frmqmk.ShowDialog();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            frmDangKy frmdk = new frmDangKy();
            frmdk.ShowDialog();
        }
    }
}
