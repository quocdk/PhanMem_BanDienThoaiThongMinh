namespace _3_PL
{
    partial class frmDichVuSuaChua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.grbHoaDonThanhToan = new System.Windows.Forms.GroupBox();
            this.btnXoaDonHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cbbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.txtKhachThanhToan = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIdHoaDon = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGioHangDichVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemVaoDonHang = new System.Windows.Forms.Button();
            this.btnXoa1DichVu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.grbHoaDonThanhToan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHangDichVu)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbLoaiDichVu
            // 
            this.cbbLoaiDichVu.FormattingEnabled = true;
            this.cbbLoaiDichVu.Items.AddRange(new object[] {
            "Trống",
            "Sửa chữa",
            "Bảo hành/Bảo dưỡng",
            "Đổi trả"});
            this.cbbLoaiDichVu.Location = new System.Drawing.Point(41, 148);
            this.cbbLoaiDichVu.Name = "cbbLoaiDichVu";
            this.cbbLoaiDichVu.Size = new System.Drawing.Size(167, 28);
            this.cbbLoaiDichVu.TabIndex = 49;
            this.cbbLoaiDichVu.Text = "Trống";
            this.cbbLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiDichVu_SelectedIndexChanged);
            // 
            // grbHoaDonThanhToan
            // 
            this.grbHoaDonThanhToan.Controls.Add(this.btnXoaDonHang);
            this.grbHoaDonThanhToan.Controls.Add(this.btnThanhToan);
            this.grbHoaDonThanhToan.Controls.Add(this.txtTienThua);
            this.grbHoaDonThanhToan.Controls.Add(this.txtTongTien);
            this.grbHoaDonThanhToan.Controls.Add(this.txtGiamGia);
            this.grbHoaDonThanhToan.Controls.Add(this.txtThanhTien);
            this.grbHoaDonThanhToan.Controls.Add(this.cbbKhuyenMai);
            this.grbHoaDonThanhToan.Controls.Add(this.txtKhachThanhToan);
            this.grbHoaDonThanhToan.Controls.Add(this.txtSoDienThoai);
            this.grbHoaDonThanhToan.Controls.Add(this.txtTenKhachHang);
            this.grbHoaDonThanhToan.Controls.Add(this.label13);
            this.grbHoaDonThanhToan.Controls.Add(this.label14);
            this.grbHoaDonThanhToan.Controls.Add(this.label15);
            this.grbHoaDonThanhToan.Controls.Add(this.label16);
            this.grbHoaDonThanhToan.Controls.Add(this.label17);
            this.grbHoaDonThanhToan.Controls.Add(this.label18);
            this.grbHoaDonThanhToan.Controls.Add(this.label19);
            this.grbHoaDonThanhToan.Controls.Add(this.label20);
            this.grbHoaDonThanhToan.Controls.Add(this.label21);
            this.grbHoaDonThanhToan.Controls.Add(this.txtIdHoaDon);
            this.grbHoaDonThanhToan.Location = new System.Drawing.Point(647, 122);
            this.grbHoaDonThanhToan.Name = "grbHoaDonThanhToan";
            this.grbHoaDonThanhToan.Size = new System.Drawing.Size(409, 553);
            this.grbHoaDonThanhToan.TabIndex = 48;
            this.grbHoaDonThanhToan.TabStop = false;
            this.grbHoaDonThanhToan.Text = "Hóa đơn thanh toán";
            // 
            // btnXoaDonHang
            // 
            this.btnXoaDonHang.Location = new System.Drawing.Point(6, 485);
            this.btnXoaDonHang.Name = "btnXoaDonHang";
            this.btnXoaDonHang.Size = new System.Drawing.Size(128, 41);
            this.btnXoaDonHang.TabIndex = 45;
            this.btnXoaDonHang.Text = "Xóa đơn hàng";
            this.btnXoaDonHang.UseVisualStyleBackColor = true;
            this.btnXoaDonHang.Click += new System.EventHandler(this.btnXoaDonHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(264, 485);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 41);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(153, 382);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(239, 27);
            this.txtTienThua.TabIndex = 44;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(153, 297);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(239, 27);
            this.txtTongTien.TabIndex = 43;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(153, 254);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(239, 27);
            this.txtGiamGia.TabIndex = 42;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(153, 169);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(239, 27);
            this.txtThanhTien.TabIndex = 41;
            // 
            // cbbKhuyenMai
            // 
            this.cbbKhuyenMai.FormattingEnabled = true;
            this.cbbKhuyenMai.Location = new System.Drawing.Point(153, 209);
            this.cbbKhuyenMai.Name = "cbbKhuyenMai";
            this.cbbKhuyenMai.Size = new System.Drawing.Size(239, 28);
            this.cbbKhuyenMai.TabIndex = 25;
            this.cbbKhuyenMai.Text = "Trống";
            this.cbbKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cbbKhuyenMai_SelectedIndexChanged);
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.Location = new System.Drawing.Point(153, 338);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(239, 27);
            this.txtKhachThanhToan.TabIndex = 40;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(153, 124);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(239, 27);
            this.txtSoDienThoai.TabIndex = 35;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(153, 80);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(239, 27);
            this.txtTenKhachHang.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tiền thừa :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Khách thanh toán :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tổng :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Giảm giá :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Khuyến mãi :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Thành tiền :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Số điện thoại :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Tên khách hàng :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "IDHoaDon :";
            // 
            // txtIdHoaDon
            // 
            this.txtIdHoaDon.Location = new System.Drawing.Point(153, 43);
            this.txtIdHoaDon.Name = "txtIdHoaDon";
            this.txtIdHoaDon.ReadOnly = true;
            this.txtIdHoaDon.Size = new System.Drawing.Size(239, 27);
            this.txtIdHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSachDichVu);
            this.groupBox3.Location = new System.Drawing.Point(34, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 190);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách dịch vụ";
            // 
            // dgvDanhSachDichVu
            // 
            this.dgvDanhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Loai,
            this.dataGridViewTextBoxColumn4});
            this.dgvDanhSachDichVu.Location = new System.Drawing.Point(12, 26);
            this.dgvDanhSachDichVu.Name = "dgvDanhSachDichVu";
            this.dgvDanhSachDichVu.RowHeadersWidth = 51;
            this.dgvDanhSachDichVu.RowTemplate.Height = 29;
            this.dgvDanhSachDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDichVu.Size = new System.Drawing.Size(580, 153);
            this.dgvDanhSachDichVu.TabIndex = 17;
            this.dgvDanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDichVu_CellClick);
            this.dgvDanhSachDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDichVu_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDDichVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDDichVu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDichVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDichVu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "LoaiDichVu";
            this.Loai.HeaderText = "LoaiDichVu";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "GiaTien";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGioHangDichVu);
            this.groupBox2.Controls.Add(this.btnThemVaoDonHang);
            this.groupBox2.Controls.Add(this.btnXoa1DichVu);
            this.groupBox2.Controls.Add(this.btnXoaTatCa);
            this.groupBox2.Location = new System.Drawing.Point(34, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 260);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng dịch vụ";
            // 
            // dgvGioHangDichVu
            // 
            this.dgvGioHangDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHangDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHangDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvGioHangDichVu.Location = new System.Drawing.Point(6, 26);
            this.dgvGioHangDichVu.Name = "dgvGioHangDichVu";
            this.dgvGioHangDichVu.RowHeadersWidth = 51;
            this.dgvGioHangDichVu.RowTemplate.Height = 29;
            this.dgvGioHangDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHangDichVu.Size = new System.Drawing.Size(580, 175);
            this.dgvGioHangDichVu.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "IDDichVu";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "TenDichVu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "LoaiDichVu";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "GiaTien";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // btnThemVaoDonHang
            // 
            this.btnThemVaoDonHang.BackColor = System.Drawing.Color.Brown;
            this.btnThemVaoDonHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemVaoDonHang.Location = new System.Drawing.Point(425, 207);
            this.btnThemVaoDonHang.Name = "btnThemVaoDonHang";
            this.btnThemVaoDonHang.Size = new System.Drawing.Size(161, 50);
            this.btnThemVaoDonHang.TabIndex = 21;
            this.btnThemVaoDonHang.Text = "Thêm vào đơn hàng";
            this.btnThemVaoDonHang.UseVisualStyleBackColor = false;
            this.btnThemVaoDonHang.Click += new System.EventHandler(this.btnThemVaoDonHang_Click);
            // 
            // btnXoa1DichVu
            // 
            this.btnXoa1DichVu.Location = new System.Drawing.Point(140, 220);
            this.btnXoa1DichVu.Name = "btnXoa1DichVu";
            this.btnXoa1DichVu.Size = new System.Drawing.Size(128, 32);
            this.btnXoa1DichVu.TabIndex = 20;
            this.btnXoa1DichVu.Text = "Xóa 1 dịch vụ";
            this.btnXoa1DichVu.UseVisualStyleBackColor = true;
            this.btnXoa1DichVu.Click += new System.EventHandler(this.btnXoa1DichVu_Click_1);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(6, 220);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(128, 32);
            this.btnXoaTatCa.TabIndex = 19;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(312, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 66);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên sản phẩm";
            this.txtTimKiem.Size = new System.Drawing.Size(308, 27);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 20);
            this.label24.TabIndex = 40;
            this.label24.Text = "Loại dịch vụ";
            // 
            // frmDichVuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1098, 754);
            this.Controls.Add(this.cbbLoaiDichVu);
            this.Controls.Add(this.grbHoaDonThanhToan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label24);
            this.Name = "frmDichVuSuaChua";
            this.Text = "frmDichVuSuaChua";
            this.Load += new System.EventHandler(this.frmDichVuSuaChua_Load);
            this.grbHoaDonThanhToan.ResumeLayout(false);
            this.grbHoaDonThanhToan.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHangDichVu)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbbLoaiDichVu;
        private GroupBox grbHoaDonThanhToan;
        private Button btnXoaDonHang;
        private Button btnThanhToan;
        private TextBox txtTienThua;
        private TextBox txtTongTien;
        private TextBox txtGiamGia;
        private TextBox txtThanhTien;
        private ComboBox cbbKhuyenMai;
        private TextBox txtKhachThanhToan;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox txtIdHoaDon;
        private GroupBox groupBox3;
        private DataGridView dgvDanhSachDichVu;
        private GroupBox groupBox2;
        private DataGridView dgvGioHangDichVu;
        private Button btnThemVaoDonHang;
        private Button btnXoa1DichVu;
        private Button btnXoaTatCa;
        private GroupBox groupBox5;
        private TextBox txtTimKiem;
        private Label label24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}