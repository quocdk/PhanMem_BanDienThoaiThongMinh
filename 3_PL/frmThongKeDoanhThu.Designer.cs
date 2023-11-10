namespace FrmDuAn1
{
    partial class frmThongKeDoanhThu
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
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbbThang = new ComboBox();
            cbbNam = new ComboBox();
            cbbthongke = new ComboBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            lbTongSoHoaDon = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            lbDoanhthu = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lbSoSanPhamBan = new Label();
            label12 = new Label();
            dgvSpBan = new DataGridView();
            groupBox2 = new GroupBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpBan).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 41);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh thu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 29);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 0;
            label9.Text = "Theo ngày";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 72);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 1;
            label10.Text = "Theo tháng, năm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(433, 29);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 2;
            label11.Text = "Sắp xếp theo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbbThang
            // 
            cbbThang.FormattingEnabled = true;
            cbbThang.Location = new Point(151, 69);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(90, 28);
            cbbThang.TabIndex = 4;
            // 
            // cbbNam
            // 
            cbbNam.FormattingEnabled = true;
            cbbNam.Location = new Point(283, 69);
            cbbNam.Name = "cbbNam";
            cbbNam.Size = new Size(116, 28);
            cbbNam.TabIndex = 5;
            // 
            // cbbthongke
            // 
            cbbthongke.FormattingEnabled = true;
            cbbthongke.Location = new Point(536, 26);
            cbbthongke.Name = "cbbthongke";
            cbbthongke.Size = new Size(151, 28);
            cbbthongke.TabIndex = 6;
            cbbthongke.SelectedIndexChanged += cbbthongke_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(cbbthongke);
            groupBox1.Controls.Add(cbbNam);
            groupBox1.Controls.Add(cbbThang);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(44, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTongSoHoaDon);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(92, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // lbTongSoHoaDon
            // 
            lbTongSoHoaDon.AutoSize = true;
            lbTongSoHoaDon.Location = new Point(105, 73);
            lbTongSoHoaDon.Name = "lbTongSoHoaDon";
            lbTongSoHoaDon.Size = new Size(25, 20);
            lbTongSoHoaDon.TabIndex = 1;
            lbTongSoHoaDon.Text = "30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng số hóa đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lbDoanhthu);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(405, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 73);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 2;
            label6.Text = "VND";
            // 
            // lbDoanhthu
            // 
            lbDoanhthu.AutoSize = true;
            lbDoanhthu.Location = new Point(68, 73);
            lbDoanhthu.Name = "lbDoanhthu";
            lbDoanhthu.Size = new Size(87, 20);
            lbDoanhthu.TabIndex = 1;
            lbDoanhthu.Text = "100.000.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 20);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 0;
            label5.Text = "Doanh thu";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbSoSanPhamBan);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(711, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 125);
            panel3.TabIndex = 2;
            // 
            // lbSoSanPhamBan
            // 
            lbSoSanPhamBan.AutoSize = true;
            lbSoSanPhamBan.Location = new Point(105, 73);
            lbSoSanPhamBan.Name = "lbSoSanPhamBan";
            lbSoSanPhamBan.Size = new Size(25, 20);
            lbSoSanPhamBan.TabIndex = 1;
            lbSoSanPhamBan.Text = "40";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 20);
            label12.Name = "label12";
            label12.Size = new Size(180, 20);
            label12.TabIndex = 0;
            label12.Text = "Tổng số sản phẩm đã bán";
            // 
            // dgvSpBan
            // 
            dgvSpBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpBan.ColumnHeadersHeight = 29;
            dgvSpBan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvSpBan.Location = new Point(27, 172);
            dgvSpBan.Name = "dgvSpBan";
            dgvSpBan.RowHeadersWidth = 51;
            dgvSpBan.RowTemplate.Height = 29;
            dgvSpBan.ScrollBars = ScrollBars.None;
            dgvSpBan.Size = new Size(1120, 240);
            dgvSpBan.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSpBan);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(44, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1176, 419);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê";
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
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmThongKeDoanhThu";
            Text = "ThongKeDoanhThu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpBan).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbThang;
        private ComboBox cbbNam;
        private ComboBox cbbthongke;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label lbTongSoHoaDon;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label lbDoanhthu;
        private Label label5;
        private Panel panel3;
        private Label lbSoSanPhamBan;
        private Label label12;
        private DataGridView dgvSpBan;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}