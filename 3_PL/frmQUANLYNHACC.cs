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
using System.Net.Mail;
using System.Xml.Linq;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore;
using _1_DAL.QuanLyDBContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NPOI.XWPF.UserModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ClosedXML;
using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using DocumentFormat.OpenXml.InkML;
using Microsoft.Data.SqlClient;
using System.Net;

namespace _3_PL
{
    public partial class frmQUANLYNHACC : Form
    {

        private QuanLyDatabaseContext db = new QuanLyDatabaseContext();
        IQuanLyNhaCCServices _qlNhacc;
        Supplier _supplier;
        public frmQUANLYNHACC()
        {
            InitializeComponent();
            _qlNhacc = new QuanLyNhaCCServices();
        }
        public void load()
        {
            _qlNhacc.GetAll();
            dtgrDanhsach.DataSource = _qlNhacc.GetAll();
            for (int i = 0; i < dtgrDanhsach.Rows.Count; i++)
            {
                dtgrDanhsach.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }
        }






        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // chuyển ảnh qua bytes

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
            {
                // Ném ngoại lệ ArgumentNullException với thông báo lỗi
                throw new ArgumentNullException(nameof(image), "Hình ảnh đầu vào là null. Không thể chuyển đổi thành mảng byte.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, ImageFormat.Jpeg); // hoặc bạn có thể chọn định dạng ảnh khác
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    // Ném ngoại lệ Exception với thông báo lỗi và đính kèm InnerException
                    MessageBox.Show("NHA CUNG CAP DA TON TAI");
                    throw;

                }

            }
        }
        // chuyển bytes qua ảnh

        private byte[] GetImageBytesFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return ms.ToArray();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        //        // lấy giá trị Id từ cột đầu tiên của dòng được chọn và hiển thị lên TextBox1
        //        txtbid.Text = row.Cells[0].Value.ToString();

        //        // lấy giá trị Name từ cột thứ hai của dòng được chọn và hiển thị lên TextBox2
        //        txtten.Text = row.Cells[1].Value.ToString();

        //        // lấy giá trị ảnh từ cột thứ ba của dòng được chọn và hiển thị lên PictureBox1
        //        byte[] imageBytes = (byte[])row.Cells[2].Value;
        //        if (imageBytes != null)
        //        {
        //            using (MemoryStream ms = new MemoryStream(imageBytes))
        //            {
        //                pictureBox1.Image = Image.FromStream(ms);
        //            }
        //        }
        //        else
        //        {
        //            pictureBox1.Image = null;
        //        }
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra các trường bắt buộc không được để trống
        //    if (string.IsNullOrWhiteSpace(txtten.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(txtdiachi.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra định dạng email hợp lệ
        //    if (!string.IsNullOrWhiteSpace(txtemail.Text) && !IsValidEmail(txtemail.Text))
        //    {
        //        MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Lấy thông tin nhà cung cấp cần cập nhật từ các TextBox và PictureBox
        //    Supplier ncc = new Supplier()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = txtten.Text,
        //        HinhAnh = GetImageBytes(pictureBox1.Image),
        //        DiaChi = txtdiachi.Text,
        //        DienThoai = txtdienthoai.Text,
        //        Email = txtemail.Text,
        //        Website = txtws.Text,
        //        GhiChu = txtghichu.Text
        //    };

        //    // Gọi phương thức Update của đối tượng QLNhacc để cập nhật thông tin nhà cung cấp
        //    bool result = _qlNhacc.Update(ncc);

        //    // Hiển thị thông báo kết quả cập nhật
        //    if (result)
        //    {
        //        MessageBox.Show("Cập nhật nhà cung cấp thành công!");
        //        load();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Cập nhật nhà cung cấp không thành công!");
        //    }

        //}



        //private void button6_Click(object sender, EventArgs e, char searchName)
        //{
        //    string searchNamea = txtSearch.Text;
        //    var suppliers = db.Suppliers.Where(s => s.Name.Contains(searchName)).ToList();
        //    dataGridView1.DataSource = suppliers;
        //}

        //private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{  // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

        //    Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

        //    // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
        //    var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

        //    // Đổ dữ liệu lên dataGridView2
        //    dataGridView2.DataSource = products;
        //}

        //private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        //{
        //    dataGridView1.Columns["Id"].Visible = false;
        //}

        //private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

        //    Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

        //    // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
        //    var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

        //    // Đổ dữ liệu lên dataGridView2
        //    dataGridView2.DataSource = products;
        //}










        // BẮT ĐẦU SỬA TÙỪ ĐÂY YYYYYYYYYYYYYYYYYYYYYYYYYYYYY



        //private void button3_Click_1(object sender, EventArgs e)
        //{

        //    OpenFileDialog openFile = new OpenFileDialog();
        //    openFile.Filter = "picture file (.png,.jpg)|*.png;*jpg";
        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(openFile.FileName);
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }

        //}

        private void frmQUANLYNHACC_Load(object sender, EventArgs e)
        {

            // Tạo các cột cho DataGridView
            //DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            //idColumn.Name = "Id";
            //idColumn.HeaderText = "Id";
            //idColumn.DataPropertyName = "Id";
            //idColumn.ValueType = typeof(Guid);
            //idColumn.Width = 25;

            //DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            //nameColumn.Name = "Name";
            //nameColumn.HeaderText = "Name";
            //nameColumn.DataPropertyName = "Name";



            //DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            //addressColumn.Name = "Address";
            //addressColumn.HeaderText = "Address";
            //addressColumn.DataPropertyName = "Address";

            //DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            //phoneColumn.Name = "PhoneNumber";
            //phoneColumn.HeaderText = "PhoneNumber";
            //phoneColumn.DataPropertyName = "PhoneNumber";

            //DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            //emailColumn.Name = "Email";
            //emailColumn.HeaderText = "Email";
            //emailColumn.DataPropertyName = "Email";

            //DataGridViewTextBoxColumn websiteColumn = new DataGridViewTextBoxColumn();
            //websiteColumn.Name = "WebSite";
            //websiteColumn.HeaderText = "WebSite";
            //websiteColumn.DataPropertyName = "WebSite";

            //DataGridViewTextBoxColumn noteColumn = new DataGridViewTextBoxColumn();
            //noteColumn.Name = "Note";
            //noteColumn.HeaderText = "Note";
            //noteColumn.DataPropertyName = "Note";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            imageColumn.DataPropertyName = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 50; // chiều rộng của cột hình ảnh
                                    //imageColumn.Height = 50; // chiều cao của cột hình ảnh
                                    // Thêm các cột vào DataGridView
            dtgrDanhsach.Columns.AddRange(new DataGridViewColumn[] { /*idColumn, nameColumn,*/ imageColumn/* addressColumn, phoneColumn, emailColumn, websiteColumn, noteColumn*/ });

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị lên DataGridView
            ////List<Supplier> suppliers = _nhacc.GetAll();
            ////dataGridView1.DataSource = suppliers;
            ///

            load();


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra các trường bắt buộc không được để trống
        //    if (string.IsNullOrWhiteSpace(txtten.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(txtdiachi.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra định dạng email hợp lệ
        //    if (!string.IsNullOrWhiteSpace(txtemail.Text) && !IsValidEmail(txtemail.Text))
        //    {
        //        MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Tạo đối tượng Supplier mới và gán các giá trị cho các thuộc tính của nó
        //    Supplier ncc = new Supplier()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = txtten.Text,
        //        Image = GetImageBytes(pictureBox1.Image), // lấy dữ liệu ảnh từ PictureBox
        //        Address = txtdiachi.Text,
        //        PhoneNumber = txtdienthoai.Text,
        //        Email = txtemail.Text,
        //        WebSite = txtws.Text,
        //        Note = txtghichu.Text
        //    };

        //    // Gọi phương thức Add của đối tượng QLNhacc để thêm đối tượng Supplier mới vào danh sách
        //    bool result = _qlNhacc.Add(ncc);

        //    // Hiển thị thông báo kết quả thêm
        //    if (result)
        //    {
        //        MessageBox.Show("Thêm nhà cung cấp thành công!");
        //        load();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm nhà cung cấp không thành công!");
        //    }


        //    // Bắt lỗi hình ảnh 
        //    try
        //    {
        //        // Kiểm tra xem người dùng đã chọn tập tin hình ảnh hay chưa
        //        if (pictureBox1.Image == null)
        //        {
        //            MessageBox.Show("Vui lòng chọn một hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Tạo đối tượng Image mới từ PictureBox
        //        Image img = pictureBox1.Image;

        //        // Kiểm tra xem định dạng của tập tin hình ảnh có hợp lệ hay không
        //        if (img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
        //            || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid
        //            || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid)
        //        {
        //            // Đoạn mã của bạn để thêm bản ghi mới ở đây
        //        }
        //        else
        //        {
        //            MessageBox.Show("Định dạng hình ảnh không hợp lệ! Vui lòng chọn một hình ảnh JPG, PNG hoặc GIF.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (System.Runtime.InteropServices.ExternalException ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //public void ac()
        //{
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //    // Tạo file Excel mới
        //    ExcelPackage excelPackage = new ExcelPackage();

        //    // Tạo một worksheet mới
        //    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

        //    // Đặt header cho các cột trong worksheet
        //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
        //    {
        //        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
        //    }

        //    // Lưu dữ liệu từ DataGridView vào worksheet
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }

        //    // Hiển thị dialog để chọn thư mục lưu file
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
        //    saveFileDialog1.Title = "Save an Excel File";
        //    saveFileDialog1.ShowDialog();

        //    // Nếu người dùng chọn OK và tên file hợp lệ
        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
        //    {
        //        // Lưu file Excel
        //        using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
        //        {
        //            excelPackage.SaveAs(stream);
        //        }

        //        // Thông báo thành công
        //        MessageBox.Show("Đã xuất dữ liệu ra file Excel!");
        //    }
        //}
        //private void button5_Click(object sender, EventArgs e)
        //{


        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //    // Tạo file Excel mới
        //    ExcelPackage excelPackage = new ExcelPackage();

        //    // Tạo một worksheet mới
        //    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

        //    // Đặt header cho các cột trong worksheet
        //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
        //    {
        //        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
        //    }

        //    // Lưu dữ liệu từ DataGridView vào worksheet
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            if (worksheet != null && dataGridView1.Rows[i] != null && dataGridView1.Rows[i].Cells[j] != null && dataGridView1.Rows[i].Cells[j].Value != null)
        //            {
        //                worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //    }


        //    // Hiển thị dialog để chọn thư mục lưu file
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
        //    saveFileDialog1.Title = "Save an Excel File";
        //    saveFileDialog1.ShowDialog();

        //    // Nếu người dùng chọn OK và tên file hợp lệ
        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
        //    {
        //        // Lưu file Excel
        //        using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
        //        {
        //            excelPackage.SaveAs(stream);
        //        }

        //        // Thông báo thành công
        //        MessageBox.Show("Đã xuất dữ liệu ra file Excel!");
        //    }



        //}

        private void button6_Click(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text;
            var suppliers = db.Suppliers
                .Where(s => s.Name.Contains(searchText) || s.PhoneNumber.Contains(searchText))
                .ToList();
            dtgrDanhsach.DataSource = suppliers;

        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dtgrDanhsach.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox tương ứng
                //txtbid.Text = row.Cells["Id"].Value.ToString();
                txtten.Text = row.Cells["Name"].Value.ToString();
                txtdiachi.Text = row.Cells["Address"].Value.ToString();
                txtdienthoai.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtws.Text = row.Cells["Website"].Value.ToString();
                txtghichu.Text = row.Cells["Note"].Value.ToString();

                // Lấy dữ liệu ảnh từ row
                byte[] imageData = (byte[])row.Cells["Image"].Value;

                // Kiểm tra dữ liệu ảnh không rỗng
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {

            }
            // Lấy giá trị id của nhà cung cấp từ cell đang được chọn
            Guid supplierId = Guid.Empty;
            if (dtgrDanhsach.CurrentRow != null)
            {
                supplierId = (Guid)dtgrDanhsach.CurrentRow.Cells["Id"].Value;
            }

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            //var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            //dataGridView2.DataSource = products;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier supplier = dtgrDanhsach.CurrentRow.DataBoundItem as Supplier;
                bool isDeleted = _qlNhacc.Delete(supplier);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click nút "Cập nhật"
            try
            {
                using (var dbContext = new QuanLyDatabaseContext()) // Tạo đối tượng DbContext
                {
                    // Các thao tác cập nhật dữ liệu vào cơ sở dữ liệu ở đây

                    // Gọi phương thức SaveChanges() của DbContext để lưu thay đổi
                    dbContext.SaveChanges();

                    // Thông báo lưu dữ liệu thành công (hoặc thực hiện các tác vụ khác)
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
            }
            catch (DbUpdateException ex)
            {
                // Xử lý ngoại lệ DbUpdateException
                // Lấy inner exception để xem thông tin lỗi chi tiết
                var innerException = ex.InnerException;

                // Kiểm tra xem innerException có phải là SqlException hay không
                if (innerException is SqlException sqlException)
                {
                    // Kiểm tra mã lỗi SQL Server để xác định nguyên nhân cụ thể
                    int errorCode = sqlException.Number;
                    switch (errorCode)
                    {
                        case 515:
                            // Lỗi giá trị NULL không được chấp nhận cho cột 'Image'
                            MessageBox.Show("Lỗi: Giá trị NULL không được chấp nhận cho cột 'Image'. Vui lòng nhập giá trị hợp lệ.");
                            break;
                        default:
                            // Xử lý các lỗi khác theo yêu cầu của bạn
                            MessageBox.Show("Lỗi: " + innerException.Message);
                            break;
                    }
                }
                else
                {
                    // Xử lý các ngoại lệ khác của DbUpdateException
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác không phải là DbUpdateException
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            // Kiểm tra trường "txtten" (tên nhà cung cấp) và "txtdiachi" (địa chỉ nhà cung cấp) không được để trống
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!");
                return;
            }

            // Kiểm tra trường "txtemail" (email) có định dạng hợp lệ
            if (!IsValidEmailFormat(txtemail.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!");
                return;
            }

            // Tạo đối tượng Supplier mới (ncc) với các thuộc tính từ các trường trên form
            Supplier ncc = new Supplier();
            ncc.Name = txtten.Text;
            ncc.Address = txtdiachi.Text;
            ncc.Email = txtemail.Text;

            // Gọi phương thức Update của đối tượng QuanLyNhaCungCap (_qlNhacc) để cập nhật thông tin nhà cung cấp
            bool result = _qlNhacc.Update(ncc);

            // Kiểm tra kết quả cập nhật
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!");
                load(); // Gọi phương thức load để tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhà cung cấp không thành công!");
            }
        }
        // Phương thức kiểm tra định dạng email hợp lệ
        private bool IsValidEmailFormat(string email)
        {
            // Kiểm tra định dạng email hợp lệ
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //private async void button2_Click_1(object sender, EventArgs e)
        //{
        //    string fromMail = textBox20.Text;
        //    string fromPassword = textBox21.Text;

        //    // Kiểm tra textBox20 có giá trị hay không
        //    if (string.IsNullOrWhiteSpace(fromMail))
        //    {
        //        MessageBox.Show("Vui lòng nhập Tài Khoản Gmail.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra textBox21 có giá trị hay không
        //    if (string.IsNullOrWhiteSpace(fromPassword))
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu email nguồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra định dạng email nguồn
        //    if (!IsValidEmail(fromMail))
        //    {
        //        MessageBox.Show("Địa chỉ email nguồn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    // Kiểm tra xem textbox có chứa email hay không
        //    if (string.IsNullOrWhiteSpace(textBox25.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập ít nhất một địa chỉ email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra xem textbox tiêu đề có chứa dữ liệu hay không
        //    if (string.IsNullOrWhiteSpace(textBox26.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tiêu đề email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Kiểm tra xem textbox nội dung có chứa dữ liệu hay không
        //    if (string.IsNullOrWhiteSpace(textBox27.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập nội dung email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    string[] toMails = textBox25.Text.Split(new[] { "\n", "," }, StringSplitOptions.RemoveEmptyEntries);

        //    int secondsToWait = 10;

        //    int successCount = 0; // Số email được gửi thành công

        //    foreach (string toMail in toMails)
        //    {
        //        try
        //        {
        //            // Kiểm tra định dạng email
        //            if (!IsValidEmail(toMail.Trim()))
        //            {
        //                MessageBox.Show($"Địa chỉ email {toMail.Trim()} không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                continue; // Chuyển sang email tiếp theo trong danh sách
        //            }

        //            MailMessage message = new MailMessage();
        //            message.From = new MailAddress(fromMail);
        //            message.Subject = textBox26.Text; // Sử dụng tiêu đề từ textbox 2
        //            message.To.Add(new MailAddress(toMail.Trim()));
        //            message.Body = textBox27.Text; // Sử dụng nội dung từ textbox 3

        //            var smtpClient = new SmtpClient("smtp.gmail.com")
        //            {
        //                Port = 587,
        //                Credentials = new NetworkCredential(fromMail, fromPassword),
        //                EnableSsl = true,
        //            };

        //            await smtpClient.SendMailAsync(message);

        //            successCount++; // Tăng số email được gửi thành công

        //            label20.Invoke((MethodInvoker)delegate
        //            {
        //                label20.Text = $"Đã gửi email đến địa chỉ: {toMail.Trim()} thành công!";
        //            });

        //            // Đếm ngược và gửi email tiếp theo
        //            for (int i = secondsToWait; i >= 0; i--)
        //            {
        //                label21.Invoke((MethodInvoker)delegate
        //                {
        //                    label21.Text = $"Gửi mail tiếp theo trong {i} giây...";
        //                });

        //                await Task.Delay(1000);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Gửi email đến địa chỉ: {toMail.Trim()} thất bại! Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    // Hiển thị thông báo khi gửi xong danh sách email
        //    MessageBox.Show($"Đã gửi hoàn thành {successCount} email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        // Hàm kiểm tra định dạng email
        //private bool lIsValidEmail(string email)
        //{
        //    try
        //    {
        //        var addr = new System.Net.Mail.MailAddress(email);
        //        return addr.Address == email;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        private void btLammoi_clik(object sender, EventArgs e)
        {


            //txtbid.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtws.Text = "";
            txtghichu.Text = "";
            pictureBox1.ImageLocation = "path/to/default/image.png";
            load();



        }

        private void btthemncc_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!string.IsNullOrWhiteSpace(txtemail.Text) && !IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Supplier mới và gán các giá trị cho các thuộc tính của nó
            Supplier ncc = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = txtten.Text,
                Image = GetImageBytes(pictureBox1.Image), // lấy dữ liệu ảnh từ PictureBox
                Address = txtdiachi.Text,
                PhoneNumber = txtdienthoai.Text,
                Email = txtemail.Text,
                WebSite = txtws.Text,
                Note = txtghichu.Text
            };

            // Gọi phương thức Add của đối tượng QLNhacc để thêm đối tượng Supplier mới vào danh sách
            bool result = _qlNhacc.Add(ncc);

            // Hiển thị thông báo kết quả thêm
            if (result)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công!");
            }


            // Bắt lỗi hình ảnh 
            try
            {
                // Kiểm tra xem người dùng đã chọn tập tin hình ảnh hay chưa
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn một hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Image mới từ PictureBox
                Image img = pictureBox1.Image;

                // Kiểm tra xem định dạng của tập tin hình ảnh có hợp lệ hay không
                if (img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
                    || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid
                    || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid)
                {
                    // Đoạn mã của bạn để thêm bản ghi mới ở đây
                }
                else
                {
                    MessageBox.Show("Định dạng hình ảnh không hợp lệ! Vui lòng chọn một hình ảnh JPG, PNG hoặc GIF.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btxoa_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier supplier = dtgrDanhsach.CurrentRow.DataBoundItem as Supplier;
                bool isDeleted = _qlNhacc.Delete(supplier);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
        }

        private void btxuat_click(object sender, EventArgs e)
        {


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Tạo file Excel mới
            ExcelPackage excelPackage = new ExcelPackage();

            // Tạo một worksheet mới
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            // Đặt header cho các cột trong worksheet
            for (int i = 0; i < dtgrDanhsach.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dtgrDanhsach.Columns[i].HeaderText;
            }

            // Lưu dữ liệu từ DataGridView vào worksheet
            for (int i = 0; i < dtgrDanhsach.Rows.Count; i++)
            {
                for (int j = 0; j < dtgrDanhsach.Columns.Count; j++)
                {
                    if (worksheet != null && dtgrDanhsach.Rows[i] != null && dtgrDanhsach.Rows[i].Cells[j] != null && dtgrDanhsach.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dtgrDanhsach.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }


            // Hiển thị dialog để chọn thư mục lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            // Nếu người dùng chọn OK và tên file hợp lệ
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                // Lưu file Excel
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    excelPackage.SaveAs(stream);
                }

                // Thông báo thành công
                MessageBox.Show("Đã xuất dữ liệu ra file Excel!");
            }




        }

        private void btxuat_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "picture file (.png,.jpg)|*.png;*jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private async void btGuimail_click(object sender, EventArgs e)
        {

            string fromMail = textBox20.Text;
            string fromPassword = textBox21.Text;

            // Kiểm tra textBox20 có giá trị hay không
            if (string.IsNullOrWhiteSpace(fromMail))
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản Gmail.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra textBox21 có giá trị hay không
            if (string.IsNullOrWhiteSpace(fromPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu email nguồn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng email nguồn
            if (!IsValidEmail(fromMail))
            {
                MessageBox.Show("Địa chỉ email nguồn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra xem textbox có chứa email hay không
            if (string.IsNullOrWhiteSpace(textBox25.Text))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một địa chỉ email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem textbox tiêu đề có chứa dữ liệu hay không
            if (string.IsNullOrWhiteSpace(textBox26.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem textbox nội dung có chứa dữ liệu hay không
            if (string.IsNullOrWhiteSpace(textBox27.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] toMails = textBox25.Text.Split(new[] { "\n", "," }, StringSplitOptions.RemoveEmptyEntries);

            int secondsToWait = 10;

            int successCount = 0; // Số email được gửi thành công

            foreach (string toMail in toMails)
            {
                try
                {
                    // Kiểm tra định dạng email
                    if (!IsValidEmail(toMail.Trim()))
                    {
                        MessageBox.Show($"Địa chỉ email {toMail.Trim()} không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // Chuyển sang email tiếp theo trong danh sách
                    }

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.Subject = textBox26.Text; // Sử dụng tiêu đề từ textbox 2
                    message.To.Add(new MailAddress(toMail.Trim()));
                    message.Body = textBox27.Text; // Sử dụng nội dung từ textbox 3

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(fromMail, fromPassword),
                        EnableSsl = true,
                    };

                    await smtpClient.SendMailAsync(message);

                    successCount++; // Tăng số email được gửi thành công

                    label20.Invoke((MethodInvoker)delegate
                    {
                        label20.Text = $"Đã gửi email đến địa chỉ: {toMail.Trim()} thành công!";
                    });

                    // Đếm ngược và gửi email tiếp theo
                    for (int i = secondsToWait; i >= 0; i--)
                    {
                        label21.Invoke((MethodInvoker)delegate
                        {
                            label21.Text = $"Gửi mail tiếp theo trong {i} giây...";
                        });

                        await Task.Delay(1000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gửi email đến địa chỉ: {toMail.Trim()} thất bại! Lỗi: Tên Tải Khoản Hoặc Mật Khẩu Không Chính Xác ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Hiển thị thông báo khi gửi xong danh sách email
            MessageBox.Show($"Đã gửi hoàn thành {successCount} email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm kiểm tra định dạng email


        private bool lIsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        private void dtgridview_click(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dtgrDanhsach.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox tương ứng
                //txtbid.Text = row.Cells["Id"].Value.ToString();
                txtten.Text = row.Cells["Name"].Value.ToString();
                txtdiachi.Text = row.Cells["Address"].Value.ToString();
                txtdienthoai.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtws.Text = row.Cells["Website"].Value.ToString();
                txtghichu.Text = row.Cells["Note"].Value.ToString();

                // Lấy dữ liệu ảnh từ row
                byte[] imageData = (byte[])row.Cells["Image"].Value;

                // Kiểm tra dữ liệu ảnh không rỗng
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {

            }
            // Lấy giá trị id của nhà cung cấp từ cell đang được chọn
            Guid supplierId = Guid.Empty;
            if (dtgrDanhsach.CurrentRow != null)
            {
                supplierId = (Guid)dtgrDanhsach.CurrentRow.Cells["Id"].Value;
            }

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            //var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            //dataGridView2.DataSource = products;


        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {


            string searchText = txtSearch.Text;
            var suppliers = db.Suppliers
                .Where(s => s.Name.Contains(searchText) || s.PhoneNumber.Contains(searchText))
                .ToList();
            dtgrDanhsach.DataSource = suppliers;


        }




        //public byte[] imgby64(Image image , System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, format);
        //        byte[] imageBytes= ms.ToArray();
        //        return imageBytes;
        //    }         
        //}
        //public byte[] imgby46(byte[] imageBytes)
        //{
        //    using (MemoryStream ms = new MemoryStream(imageBytes))
        //    {
        //        Image image = Image.FromStream(ms, true);
        //        return imgby64(image, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    }
        //}
    }
}





