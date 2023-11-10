using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Entities;

namespace _3_PL
{
    public partial class frmQuenMatKhau : Form
    {
        private INhanVienServices _inhanvienservice;
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public frmQuenMatKhau()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienServices();
            this.CenterToScreen();
        }
        public void sendemail(string email, string password)
        {
            string to;
            to = txb_email.Text.Trim();
            string content = "Đây là email chứa mật khẩu mới của bạn:";
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress("linhntph21637@fpt.edu.vn");
            mail.Subject = "Reset Password";
            mail.Body = content;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("linhntph21637@fpt.edu.vn", "linhntph21637123456789");
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email đã được gửi thành công!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_resetpassword_Click(object sender, EventArgs e)
        {
            

        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

    }
}
