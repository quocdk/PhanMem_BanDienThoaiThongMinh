namespace FrmDuAn1
{
    partial class frmHoaDon
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
            groupBox1 = new GroupBox();
            dgvHoaDon = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            dtpNgayTao = new DateTimePicker();
            label2 = new Label();
            cbbTk = new ComboBox();
            txtTkHd = new TextBox();
            btnTk = new Button();
            groupBox2 = new GroupBox();
            DgvHoaDonCT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvHoaDonCT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 41);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hóa đơn";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHoaDon);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbbTk);
            groupBox1.Controls.Add(txtTkHd);
            groupBox1.Controls.Add(btnTk);
            groupBox1.Location = new Point(33, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1185, 313);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column5, Column7, Column8 });
            dgvHoaDon.Location = new Point(16, 97);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(1137, 204);
            dgvHoaDon.TabIndex = 14;
            dgvHoaDon.CellDoubleClick += dgvHoaDon_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID hóa đơn";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tên khách hàng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ngày tạo";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Tổng tiền";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column5
            // 
            Column5.HeaderText = "Khuyến mãi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Giảm giá";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Khách phải trả";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(179, 59);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(270, 27);
            dtpNgayTao.TabIndex = 11;
            dtpNgayTao.ValueChanged += dtpNgayTao_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 62);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày tạo";
            // 
            // cbbTk
            // 
            cbbTk.FormattingEnabled = true;
            cbbTk.Items.AddRange(new object[] { "Tên khách hàng", "Số điện thoại" });
            cbbTk.Location = new Point(466, 25);
            cbbTk.Name = "cbbTk";
            cbbTk.Size = new Size(151, 28);
            cbbTk.TabIndex = 9;
            // 
            // txtTkHd
            // 
            txtTkHd.Location = new Point(103, 26);
            txtTkHd.Name = "txtTkHd";
            txtTkHd.PlaceholderText = "Tìm kiếm hóa đơn";
            txtTkHd.Size = new Size(346, 27);
            txtTkHd.TabIndex = 8;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(623, 24);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(94, 29);
            btnTk.TabIndex = 7;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvHoaDonCT);
            groupBox2.Location = new Point(33, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1185, 241);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // DgvHoaDonCT
            // 
            DgvHoaDonCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvHoaDonCT.ColumnHeadersHeight = 29;
            DgvHoaDonCT.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            DgvHoaDonCT.Location = new Point(19, 26);
            DgvHoaDonCT.Name = "DgvHoaDonCT";
            DgvHoaDonCT.RowHeadersWidth = 51;
            DgvHoaDonCT.RowTemplate.Height = 29;
            DgvHoaDonCT.Size = new Size(1134, 204);
            DgvHoaDonCT.TabIndex = 13;
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
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmHoaDon";
            Text = "HoaDon";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvHoaDonCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTkHd;
        private Button btnTk;
        private DateTimePicker dtpNgayTao;
        private Label label2;
        private ComboBox cbbTk;
        private DataGridView dgvHoaDon;
        private DataGridView DgvHoaDonCT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}