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
    public partial class frmLoaiDT : Form
    {
        ILoaiDTService _iloaidtservice;
        PhoneType loaidt;
        public frmLoaiDT()
        {
            InitializeComponent();
            _iloaidtservice = new LoaiDTService();
            loaidt = new PhoneType();
            LoadLoaiDT();
        }
        public void LoadLoaiDT()
        {
            dgv_danhsach.Rows.Clear();
            int STT = 1;
            foreach (var loai in _iloaidtservice.GetAll())
            {
                
                dgv_danhsach.Columns[0].Visible = false;
                dgv_danhsach.Rows.Add(loai.Id,STT,loai.Name);
                STT++;
            }
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            PhoneType loaidt = new PhoneType()
            {
                Id = Guid.NewGuid(),
                Name = txb_tenloaidt.Text

            };
            _iloaidtservice.Add(loaidt);
            MessageBox.Show("Thêm Thành Công");
            LoadLoaiDT();
        }
        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgv_danhsach.Rows[e.RowIndex];
            loaidt = _iloaidtservice.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dgvr.Cells[0].Value.ToString()));
            txb_id.Text = dgvr.Cells[0].Value.ToString();
            txb_tenloaidt.Text = dgvr.Cells[2].Value.ToString();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            loaidt.Name = txb_tenloaidt.Text;
            _iloaidtservice.Update(loaidt);
            MessageBox.Show("Sửa Thành Công");
            LoadLoaiDT();
        }

        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {
            var find = _iloaidtservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text));
            dgv_danhsach.Rows.Clear();
            int STT = 1;
            foreach (var loai in find)
            {
                
                dgv_danhsach.Columns[0].Visible = false;
                dgv_danhsach.Rows.Add(loai.Id, STT, loai.Name);
                STT++;
            }
        }
    }
}
