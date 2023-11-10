using FrmDuAn1;
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
    public partial class FrmTong : Form
    {
        public FrmTong()
        {
            InitializeComponent();
            Panel plChuaTatCaForm = new Panel();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnQuanLyCuaHang_Click(object sender, EventArgs e)
        {
            plChuaTatCaForm.Controls.Clear();
            frmHang frmHang = new frmHang();
            frmHang.TopLevel = false;
            frmHang.Dock = DockStyle.Fill;
            frmHang.TopMost = true;
            frmHang.FormBorderStyle = FormBorderStyle.None;
            plChuaTatCaForm.Controls.Add(frmHang);
            frmHang.Show();
        }

        private void plChuaTatCaForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            plChuaTatCaForm.Controls.Clear();
            frmBanHang frmBanHang = new frmBanHang();
            frmBanHang.TopLevel = false;
            frmBanHang.Dock = DockStyle.Fill;
            frmBanHang.TopMost = true;
            frmBanHang.FormBorderStyle = FormBorderStyle.None;
            plChuaTatCaForm.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }
    }
}
