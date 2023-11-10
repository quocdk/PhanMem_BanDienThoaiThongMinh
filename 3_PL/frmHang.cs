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
    public partial class frmHang : Form
    {
        IHangDTService _ihangdtservice;
        PhoneCompany hangdt;
        public frmHang()
        {
            InitializeComponent();
            _ihangdtservice = new HangDTService();
            hangdt = new PhoneCompany();
            LoadHangDT();
        }
        public void LoadHangDT()
        {
            dgv_danhsach.Rows.Clear();
            int STT = 1;
            foreach (var hang in _ihangdtservice.GetAll())
            {
                
                dgv_danhsach.Columns[0].Visible = false;                
                dgv_danhsach.Rows.Add(hang.Id,STT,hang.Name);
                STT++;
            }
        }

        private void btn_themhang_Click(object sender, EventArgs e)
        {
            PhoneCompany hangDT = new PhoneCompany()
            {
                Id = Guid.NewGuid(),
                Name = txb_tenhang.Text
            };
            _ihangdtservice.Add(hangDT);
            MessageBox.Show("Thêm Thành Công");
            LoadHangDT();
        }
        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgv_danhsach.Rows[e.RowIndex];
            hangdt = _ihangdtservice.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dgvr.Cells[0].Value.ToString()));
            txb_idhang.Text = dgvr.Cells[0].Value.ToString();
            txb_tenhang.Text = dgvr.Cells[2].Value.ToString();
        }
        private void btn_suahang_Click(object sender, EventArgs e)
        {
                hangdt.Name = txb_tenhang.Text;
                _ihangdtservice.Update(hangdt);
                MessageBox.Show("Sửa Thành Công");
                LoadHangDT();
        }

        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(txb_timkiem.Text != "")
            {
                var find = _ihangdtservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text));
                foreach (var hang in find)
                {
                    int STT = 1;
                    dgv_danhsach.Rows.Clear();
                    

                    
                    dgv_danhsach.Columns[0].Visible = false;
                    dgv_danhsach.Rows.Add(hang.Id, STT, hang.Name);
                    STT++;

                }
            }
            if(txb_timkiem.Text  == "")
            {
                LoadHangDT();
            }

        }
    }
}
