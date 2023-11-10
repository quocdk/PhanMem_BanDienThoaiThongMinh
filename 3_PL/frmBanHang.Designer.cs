namespace FrmDuAn1
{
    partial class frmBanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnTangSoLuong = new Button();
            btnThemVaoGioHang = new Button();
            btnGiamSoLuong = new Button();
            btnXoaGioHang = new Button();
            btnXoaSp = new Button();
            dgvGioHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            cbbLoaiDt = new ComboBox();
            cbbHangSp = new ComboBox();
            txtTkSp = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnTkSp = new Button();
            dgvSp = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtTongTien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSdtKh = new TextBox();
            label4 = new Label();
            txtTienThua = new TextBox();
            label3 = new Label();
            txtKhachThanhToan = new TextBox();
            label2 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnThanhToan = new Button();
            label9 = new Label();
            txtTenKh = new TextBox();
            label13 = new Label();
            cbbKhuyenMai = new ComboBox();
            label15 = new Label();
            txtGiamGia = new TextBox();
            label14 = new Label();
            label17 = new Label();
            txtKhachPhaiTra = new TextBox();
            label16 = new Label();
            txtSlSp = new TextBox();
            label19 = new Label();
            btnHuyDonHang = new Button();
            txtDiaChi = new TextBox();
            labeldc = new Label();
            lablegt = new Label();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSp).BeginInit();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, -2);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 0;
            label1.Text = "Bán hàng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1000, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(btnTangSoLuong);
            groupBox1.Controls.Add(btnThemVaoGioHang);
            groupBox1.Controls.Add(btnGiamSoLuong);
            groupBox1.Controls.Add(btnXoaGioHang);
            groupBox1.Controls.Add(btnXoaSp);
            groupBox1.Controls.Add(dgvGioHang);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(25, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 288);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giỏ hàng";
            // 
            // btnTangSoLuong
            // 
            btnTangSoLuong.Location = new Point(290, 238);
            btnTangSoLuong.Name = "btnTangSoLuong";
            btnTangSoLuong.Size = new Size(115, 29);
            btnTangSoLuong.TabIndex = 5;
            btnTangSoLuong.Text = "Tăng số lượng";
            btnTangSoLuong.UseVisualStyleBackColor = true;
            btnTangSoLuong.Click += btnTangSoLuong_Click;
            // 
            // btnThemVaoGioHang
            // 
            btnThemVaoGioHang.Location = new Point(554, 238);
            btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            btnThemVaoGioHang.Size = new Size(153, 29);
            btnThemVaoGioHang.TabIndex = 4;
            btnThemVaoGioHang.Text = "Thêm vào đơn hàng";
            btnThemVaoGioHang.UseVisualStyleBackColor = true;
            btnThemVaoGioHang.Click += btnThemVaoGioHang_Click;
            // 
            // btnGiamSoLuong
            // 
            btnGiamSoLuong.Location = new Point(421, 238);
            btnGiamSoLuong.Name = "btnGiamSoLuong";
            btnGiamSoLuong.Size = new Size(120, 29);
            btnGiamSoLuong.TabIndex = 3;
            btnGiamSoLuong.Text = "Giảm số lượng";
            btnGiamSoLuong.UseVisualStyleBackColor = true;
            btnGiamSoLuong.Click += btnGiamSoLuong_Click;
            // 
            // btnXoaGioHang
            // 
            btnXoaGioHang.Location = new Point(152, 238);
            btnXoaGioHang.Name = "btnXoaGioHang";
            btnXoaGioHang.Size = new Size(119, 29);
            btnXoaGioHang.TabIndex = 2;
            btnXoaGioHang.Text = "Xóa giỏ hàng";
            btnXoaGioHang.UseVisualStyleBackColor = true;
            btnXoaGioHang.Click += btnXoaGioHang_Click;
            // 
            // btnXoaSp
            // 
            btnXoaSp.Location = new Point(23, 238);
            btnXoaSp.Name = "btnXoaSp";
            btnXoaSp.Size = new Size(113, 29);
            btnXoaSp.TabIndex = 1;
            btnXoaSp.Text = "Xóa sản phẩm";
            btnXoaSp.UseVisualStyleBackColor = true;
            btnXoaSp.Click += btnXoaSp_Click;
            // 
            // dgvGioHang
            // 
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeight = 29;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            dgvGioHang.Location = new Point(23, 28);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.RowTemplate.Height = 29;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(684, 204);
            dgvGioHang.TabIndex = 0;
            dgvGioHang.CellValueChanged += dgvGioHang_CellValueChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbLoaiDt);
            groupBox2.Controls.Add(cbbHangSp);
            groupBox2.Controls.Add(txtTkSp);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnTkSp);
            groupBox2.Controls.Add(dgvSp);
            groupBox2.Location = new Point(25, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 308);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // cbbLoaiDt
            // 
            cbbLoaiDt.FormattingEnabled = true;
            cbbLoaiDt.Location = new Point(544, 82);
            cbbLoaiDt.Name = "cbbLoaiDt";
            cbbLoaiDt.Size = new Size(163, 28);
            cbbLoaiDt.TabIndex = 8;
            cbbLoaiDt.SelectedIndexChanged += cbbLoaiDt_SelectedIndexChanged;
            // 
            // cbbHangSp
            // 
            cbbHangSp.FormattingEnabled = true;
            cbbHangSp.Location = new Point(161, 84);
            cbbHangSp.Name = "cbbHangSp";
            cbbHangSp.Size = new Size(151, 28);
            cbbHangSp.TabIndex = 7;
            cbbHangSp.SelectedIndexChanged += cbbHangSp_SelectedIndexChanged;
            // 
            // txtTkSp
            // 
            txtTkSp.Location = new Point(23, 31);
            txtTkSp.Name = "txtTkSp";
            txtTkSp.PlaceholderText = "Nhập tên sản phẩm";
            txtTkSp.Size = new Size(504, 27);
            txtTkSp.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 87);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 5;
            label8.Text = "Loại điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 90);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 4;
            label7.Text = "Hãng sản phẩm";
            // 
            // btnTkSp
            // 
            btnTkSp.Location = new Point(573, 31);
            btnTkSp.Name = "btnTkSp";
            btnTkSp.Size = new Size(134, 29);
            btnTkSp.TabIndex = 2;
            btnTkSp.Text = "Tìm kiếm";
            btnTkSp.UseVisualStyleBackColor = true;
            btnTkSp.Click += btnTkSp_Click;
            // 
            // dgvSp
            // 
            dgvSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSp.ColumnHeadersHeight = 29;
            dgvSp.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column5 });
            dgvSp.Location = new Point(15, 128);
            dgvSp.Name = "dgvSp";
            dgvSp.RowHeadersWidth = 51;
            dgvSp.RowTemplate.Height = 29;
            dgvSp.Size = new Size(692, 162);
            dgvSp.TabIndex = 1;
            dgvSp.CellClick += dgvSp_CellClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã sản phẩm";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Tên sản phẩm";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Đơn giá";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số lượng tồn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(195, 267);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(169, 27);
            txtTongTien.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 460);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 26;
            label6.Text = "Tiền thừa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 422);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 25;
            label5.Text = "Khách thanh toán";
            // 
            // txtSdtKh
            // 
            txtSdtKh.Location = new Point(195, 116);
            txtSdtKh.Name = "txtSdtKh";
            txtSdtKh.Size = new Size(169, 27);
            txtSdtKh.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 270);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 24;
            label4.Text = "Tổng tiền";
            // 
            // txtTienThua
            // 
            txtTienThua.Enabled = false;
            txtTienThua.Location = new Point(195, 457);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.Size = new Size(169, 27);
            txtTienThua.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 120);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 23;
            label3.Text = "Số điện thoại";
            // 
            // txtKhachThanhToan
            // 
            txtKhachThanhToan.Location = new Point(195, 419);
            txtKhachThanhToan.Name = "txtKhachThanhToan";
            txtKhachThanhToan.Size = new Size(169, 27);
            txtKhachThanhToan.TabIndex = 31;
            txtKhachThanhToan.TextChanged += txtKhachThanhToan_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 80);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 22;
            label2.Text = "Tên khách hàng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(376, 270);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 32;
            label11.Text = "VND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 422);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 33;
            label10.Text = "VND";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(270, 519);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 20;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 460);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 34;
            label9.Text = "VND";
            // 
            // txtTenKh
            // 
            txtTenKh.Location = new Point(195, 77);
            txtTenKh.Name = "txtTenKh";
            txtTenKh.Size = new Size(169, 27);
            txtTenKh.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 307);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 37;
            label13.Text = "Khuyến mãi";
            // 
            // cbbKhuyenMai
            // 
            cbbKhuyenMai.FormattingEnabled = true;
            cbbKhuyenMai.Location = new Point(195, 303);
            cbbKhuyenMai.Name = "cbbKhuyenMai";
            cbbKhuyenMai.Size = new Size(169, 28);
            cbbKhuyenMai.TabIndex = 38;
            cbbKhuyenMai.SelectedIndexChanged += cbbKhuyenMai_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 345);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 39;
            label15.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Enabled = false;
            txtGiamGia.Location = new Point(195, 342);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(169, 27);
            txtGiamGia.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(376, 345);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 41;
            label14.Text = "VND";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(47, 384);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 42;
            label17.Text = "Khách phải trả";
            // 
            // txtKhachPhaiTra
            // 
            txtKhachPhaiTra.Enabled = false;
            txtKhachPhaiTra.Location = new Point(195, 381);
            txtKhachPhaiTra.Name = "txtKhachPhaiTra";
            txtKhachPhaiTra.Size = new Size(169, 27);
            txtKhachPhaiTra.TabIndex = 43;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(376, 384);
            label16.Name = "label16";
            label16.Size = new Size(40, 20);
            label16.TabIndex = 44;
            label16.Text = "VND";
            // 
            // txtSlSp
            // 
            txtSlSp.Enabled = false;
            txtSlSp.Location = new Point(195, 230);
            txtSlSp.Name = "txtSlSp";
            txtSlSp.Size = new Size(169, 27);
            txtSlSp.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(47, 233);
            label19.Name = "label19";
            label19.Size = new Size(137, 20);
            label19.TabIndex = 45;
            label19.Text = "Số lượng sản phẩm";
            // 
            // btnHuyDonHang
            // 
            btnHuyDonHang.Location = new Point(79, 519);
            btnHuyDonHang.Name = "btnHuyDonHang";
            btnHuyDonHang.Size = new Size(119, 29);
            btnHuyDonHang.TabIndex = 47;
            btnHuyDonHang.Text = "Hủy đơn hàng";
            btnHuyDonHang.UseVisualStyleBackColor = true;
            btnHuyDonHang.Click += btnHuyDonHang_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(195, 193);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(169, 27);
            txtDiaChi.TabIndex = 51;
            // 
            // labeldc
            // 
            labeldc.AutoSize = true;
            labeldc.Location = new Point(47, 196);
            labeldc.Name = "labeldc";
            labeldc.Size = new Size(55, 20);
            labeldc.TabIndex = 49;
            labeldc.Text = "Địa chỉ";
            // 
            // lablegt
            // 
            lablegt.AutoSize = true;
            lablegt.Location = new Point(47, 159);
            lablegt.Name = "lablegt";
            lablegt.Size = new Size(65, 20);
            lablegt.TabIndex = 48;
            lablegt.Text = "Giới tính";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(lablegt);
            groupBox3.Controls.Add(labeldc);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(btnHuyDonHang);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(txtSlSp);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtKhachPhaiTra);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtGiamGia);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(cbbKhuyenMai);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtTenKh);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtKhachThanhToan);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtTienThua);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtSdtKh);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTongTien);
            groupBox3.Location = new Point(779, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(471, 602);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin đơn hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbNu);
            panel2.Controls.Add(rbNam);
            panel2.Location = new Point(196, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 37);
            panel2.TabIndex = 52;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(103, 6);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 1;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Checked = true;
            rbNam.Location = new Point(6, 6);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "frmBanHang";
            Text = "BanHang";
            Load += BanHang_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSp).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Button btnThemVaoGioHang;
        private Button btnGiamSoLuong;
        private Button btnXoaGioHang;
        private Button btnXoaSp;
        private DataGridView dgvGioHang;
        private GroupBox groupBox2;
        private ComboBox cbbLoaiDt;
        private ComboBox cbbHangSp;
        private TextBox txtTkSp;
        private Label label8;
        private Label label7;
        private Button btnTkSp;
        private DataGridView dgvSp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Button btnTangSoLuong;
        private TextBox txtTongTien;
        private Label label6;
        private Label label5;
        private TextBox txtSdtKh;
        private Label label4;
        private TextBox txtTienThua;
        private Label label3;
        private TextBox txtKhachThanhToan;
        private Label label2;
        private Label label11;
        private Label label10;
        private Button btnThanhToan;
        private Label label9;
        private TextBox txtTenKh;
        private Label label13;
        private ComboBox cbbKhuyenMai;
        private Label label15;
        private TextBox txtGiamGia;
        private Label label14;
        private Label label17;
        private TextBox txtKhachPhaiTra;
        private Label label16;
        private TextBox txtSlSp;
        private Label label19;
        private Button btnHuyDonHang;
        private TextBox txtDiaChi;
        private Label labeldc;
        private Label lablegt;
        private GroupBox groupBox3;
        private Panel panel2;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
    }
}