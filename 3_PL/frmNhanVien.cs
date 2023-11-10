using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using System.Text.RegularExpressions;

namespace _3_PL
{
    public partial class frmNhanVien : Form
    {
        private INhanVienServices _inhanvienservice;
        private Employee employee;
        private string linkimage = "";

        public frmNhanVien()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienServices();
            employee = new Employee();

            dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            rb_danghd.Checked = true;
            LoadNhanVien();
        }

        public void LoadNhanVien()
        {
            dgv_danhsach.Rows.Clear();
            int STT = 1;

            foreach (var nhanvien in _inhanvienservice.GetAll())
            {
                string manv = "NV" + STT;

                string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                dgv_danhsach.Columns[0].Visible = false;
                dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.Email, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", nhanvien.Role, nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                STT++;
            }
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
            else if (ptb_nhanvien.Image == null)
            {
                MessageBox.Show("Bạn chưa tải ảnh đại diện!");
                return false;
            }
            return true;
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            var checkEmail = _inhanvienservice.GetAll().FirstOrDefault(x => x.Email == txb_email.Text);
            var checkusername = _inhanvienservice.GetAll().FirstOrDefault(x => x.UserName == txb_taikhoan.Text);
            if (!checkInput())
            {
            }
            else
            {
                if (checkEmail != null && checkusername != null)
                {
                    MessageBox.Show("Email hoặc tên tài khoản đã được sử dụng, vui lòng nhập lại!");
                }
                else
                {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkimage, Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage)), true);
                    linkimage = Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage));

                    Employee nv = new Employee()
                    {
                        Name = txb_hovaten.Text,
                        Email = txb_email.Text,
                        PhoneNumber = txb_sdt.Text,
                        BirthDay = dtp_ngaysinh.Value,
                        Sex = rb_nam.Checked,
                        Role = rb_quanly.Checked ? "Quản Lý" : "Nhân Viên",
                        UserName = txb_taikhoan.Text,
                        PassWord = txb_matkhau.Text,
                        Status = rb_danghd.Checked,
                        LinkImage = linkimage
                    };
                    _inhanvienservice.Add(nv);
                    MessageBox.Show("Thêm Thành công");
                    LoadNhanVien();
                }
            }
        }

        private void ptb_nhanvien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                linkimage = ofd.FileName;
                ptb_nhanvien.Image = Image.FromFile(ofd.FileName);
                ptb_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dgv_danhsach.Rows[e.RowIndex];
            employee = _inhanvienservice.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dgr.Cells[0].Value.ToString()));
            txb_hovaten.Text = dgr.Cells[2].Value.ToString();
            txb_email.Text = dgr.Cells[3].Value.ToString();
            txb_sdt.Text = dgr.Cells[4].Value.ToString();
            dtp_ngaysinh.Value = employee.BirthDay;
            rb_nam.Checked = dgr.Cells[6].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = dgr.Cells[6].Value.ToString() == "Nữ" ? true : false;
            rb_danghd.Checked = dgr.Cells[10].Value.ToString() == "Đang Hoạt Động" ? true : false;
            rb_khonghd.Checked = dgr.Cells[10].Value.ToString() == "Không Hoạt Động" ? true : false;
            rb_quanly.Checked = dgr.Cells[7].Value.ToString() == "Quản Lý" ? true : false;
            rb_nhanvien.Checked = dgr.Cells[7].Value.ToString() == "Nhân Viên" ? true : false;
            txb_taikhoan.Text = dgr.Cells[8].Value.ToString();
            txb_matkhau.Text = dgr.Cells[9].Value.ToString();
            linkimage = employee.LinkImage;
            if (linkimage != null && File.Exists(linkimage))
            {
                ptb_nhanvien.Image = Image.FromFile(linkimage);
                ptb_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            if (employee.LinkImage != linkimage)
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                File.Copy(linkimage, Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage)), true);
                linkimage = Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage));
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                employee.Name = txb_hovaten.Text;
                employee.Email = txb_email.Text;
                employee.PhoneNumber = txb_sdt.Text;
                employee.BirthDay = dtp_ngaysinh.Value;
                employee.Sex = rb_nam.Checked;
                employee.UserName = txb_taikhoan.Text;
                employee.PassWord = txb_matkhau.Text;
                employee.Role = rb_quanly.Checked ? "Quản Lý" : "Nhân Viên";
                employee.Status = rb_danghd.Checked;
                employee.LinkImage = linkimage;
                _inhanvienservice.Update(employee);
                LoadNhanVien();
            }

            MessageBox.Show("Sửa Thành Công");
        }

        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbb_loc_theo_chuc_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbb_loc_theo_chuc_vu_TextChanged(object sender, EventArgs e)
        {
            //if(cbb_loc_theo_chuc_vu.Text == "Quản Lý")
            //{
            //    var find = _inhanvienservice.GetAll().Where(x => x.Role == "Quản Lý");
            //    int STT = 1;
            //    foreach (var nhanvien in find)
            //    {
            //        string manv = "NV" + STT;

            //        dgv_danhsach.Rows.Clear();
            //        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
            //        dgv_danhsach.Columns[0].Visible = false;

            //        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
            //        STT++;
            //    }
            //}
            //if(cbb_loc_theo_chuc_vu.Text == "Nhân Viên")
            //{
            //    var find = _inhanvienservice.GetAll().Where(x => x.Role == "Nhân Viên");
            //    int STT = 1;
            //    foreach (var nhanvien in find)
            //    {
            //        string manv = "NV" + STT;

            //        dgv_danhsach.Rows.Clear();
            //        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
            //        dgv_danhsach.Columns[0].Visible = false;

            //        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
            //        STT++;
            //    }
            //}
            //if (txb_timkiem.Text == "")
            //{
            //   // LoadNhanVien();
            //}
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }
    }
}