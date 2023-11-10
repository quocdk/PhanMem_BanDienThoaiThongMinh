using _1_DAL.Entities;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace _3_PL
{
    public partial class frmQUANLYKM : Form
    {
        IQuanLyKMServices _quanlykm;
        Promotion _promotion;

        public frmQUANLYKM()
        {
            InitializeComponent();        
            _quanlykm = new QlkhuyenmaiServices();
        }
     public void load()
        {
            dtgv.DataSource = _quanlykm.GetAll();
            ////dtgv.Columns["STT"].Width = 50;
            //dtgv.Columns["ID"].Width = 50;
            dtgv.Columns["ID"].Width = 50;

        }

        private void frmQUANLYKM_Load(object sender, EventArgs e)
        {
            load();
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promotion km = new Promotion();

            if (string.IsNullOrWhiteSpace(tbTenKM.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khuyến mãi, xin hãy nhập");
                tbTenKM.BackColor = Color.Red;
                return;
            }
            else
            {
                tbTenKM.BackColor = Color.White;
                km.Name = tbTenKM.Text;
            }

            if (dtngaybatdaua.Value >= dtngaybatdauv.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc, xin hãy chọn lại");
                dtngaybatdaua.BackColor = Color.Red;
                dtngaybatdauv.BackColor = Color.Red;
                return;
            }
            else
            {
                dtngaybatdaua.BackColor = Color.White;
                dtngaybatdauv.BackColor = Color.White;
                km.CreateDate = dtngaybatdaua.Value;
                km.EndDate = dtngaybatdauv.Value;
            }

            if (string.IsNullOrWhiteSpace(tbptKM.Text))
            {
                MessageBox.Show("Bạn chưa nhập % khuyến mãi, xin hãy nhập");
                tbptKM.BackColor = Color.Red;
                return;
            }
            else if (!int.TryParse(tbptKM.Text, out int index))
            {
                MessageBox.Show("Bạn không thể nhập chữ vào % khuyến mãi, xin hãy nhập số");
                tbptKM.BackColor = Color.Red;
                return;
            }
            else
            {
                tbptKM.BackColor = Color.White;
                km.Index = index;
                _quanlykm.Add(km);
                MessageBox.Show("Thêm thành công");
            }

            load();
            tbTenKM.Text = "";
            tbptKM.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (dtgv.CurrentCell != null)
            {
                var kmList = _quanlykm.GetAll();
                var row = dtgv.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    //tbidKM.Text = km.Id.ToString();
                    tbTenKM.Text = km.Name.ToString();
                    tbptKM.Text = km.Index.ToString();
                    dtngaybatdaua.Value = km.CreateDate;
                    dtngaybatdauv.Value = km.EndDate;
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kmList = _quanlykm.GetAll();
            if (dtgv.CurrentCell != null)
            {
                var row = dtgv.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    if (string.IsNullOrWhiteSpace(tbTenKM.Text))
                    {
                        MessageBox.Show("Vui lòng nhập tên khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dtngaybatdaua.Value >= dtngaybatdauv.Value)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrWhiteSpace(tbptKM.Text) || !int.TryParse(tbptKM.Text, out int index))
                    {
                        MessageBox.Show("Vui lòng nhập phần trăm khuyến mãi là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        km.Name = tbTenKM.Text;
                        km.CreateDate = dtngaybatdaua.Value;
                        km.EndDate = dtngaybatdauv.Value;
                        km.Index = index;
                        _quanlykm.Update(km);
                        MessageBox.Show("Cập nhật thông tin khuyến mãi thành công!");
                        load();
                    }
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dtgv.CurrentCell != null)
            {
                var kmList = _quanlykm.GetAll();
                var row = dtgv.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    _quanlykm.Delete(km);
                    MessageBox.Show("Xóa khuyến mãi thành công!");
                    load();
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //tbidKM.Text = "";
            tbTenKM.Text = "";
            tbptKM.Text = "";
            dtngaybatdaua.Value = DateTime.Now;
            dtngaybatdauv.Value = DateTime.Now;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //string tuKhoa = textBox6.Text;
            //string query = "SELECT * FROM KhuyenMai WHERE TenKM LIKE '%" + tuKhoa + "%'";
            //DataTable dt = GetData(query);
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy kết quả tương ứng", "Thông báo");
            //}
            //else
            //{
            //    dataGridView1.DataSource = dt;
            //}
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtngaybatdaua.Value;
            DateTime toDate = dtngaybatdauv.Value;
            List<Promotion> result = _quanlykm.GetAll().Where(km => km.CreateDate >= fromDate && km.EndDate <= toDate).ToList();
            dtgv.DataSource = result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dtngaybatdaua.Value;
            string formattedDate = dateTime.ToString("dd/MM/yyyy");
            Console.WriteLine(formattedDate); // Kết quả: "09/04/2023"

        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            load();
        }
        //
        private void ExportToExcel2()
        {
            // Tạo workbook mới
            XSSFWorkbook workbook = new XSSFWorkbook();
            // Tạo sheet mới
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // Tạo header cho sheet
            IRow headerRow = sheet.CreateRow(0);
            for (int j = 0; j < dtgv.Columns.Count; j++)
            {
                headerRow.CreateCell(j).SetCellValue(dtgv.Columns[j].HeaderText);
            }

            // Lấy dữ liệu từ DataGridView và đưa vào DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                dt.Columns.Add(dtgv.Columns[i].Name);
            }
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                for (int i = 0; i < dtgv.Columns.Count; i++)
                {
                    dRow[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(dRow);
            }

            // Lấy số cột và số dòng của DataTable
            int rowCount = dt.Rows.Count;
            int colCount = dt.Columns.Count;

            // Lấy dữ liệu từ DataTable và đưa vào sheet
            for (int i = 0; i < rowCount; i++)
            {
                IRow dataRow = sheet.CreateRow(i + 1);
                for (int j = 0; j < colCount; j++)
                {
                    dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            // Hiển thị dialog để chọn thư mục lưu file
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu file Excel
                string fileName = "TTkhuyenmai_" + DateTime.Now.ToString("dd-MM-yyyy-ss") + ".xlsx";
                string filePath = Path.Combine(folderDialog.SelectedPath, fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }

                // Hiển thị thông báo xuất file thành công
                MessageBox.Show("Xuất file thành công!", "Thông báo");
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ExportToExcel2();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dtgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dtgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dtgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
