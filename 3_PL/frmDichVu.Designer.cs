namespace _3_PL
{
    partial class frmDichVu
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
            this.cbbLoaiDichVuDV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvDichVuDV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnShowDV = new System.Windows.Forms.Button();
            this.txtGiaTienDV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemDV = new System.Windows.Forms.Button();
            this.txtTimKiemDV = new System.Windows.Forms.TextBox();
            this.txtTenDichVuDV = new System.Windows.Forms.TextBox();
            this.txtIdDichVuDV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbLoaiDichVuDV
            // 
            this.cbbLoaiDichVuDV.FormattingEnabled = true;
            this.cbbLoaiDichVuDV.Items.AddRange(new object[] {
            "Trống",
            "Sửa chữa",
            "Bảo hành/Bảo dưỡng",
            "Đổi trả"});
            this.cbbLoaiDichVuDV.Location = new System.Drawing.Point(236, 237);
            this.cbbLoaiDichVuDV.Name = "cbbLoaiDichVuDV";
            this.cbbLoaiDichVuDV.Size = new System.Drawing.Size(363, 28);
            this.cbbLoaiDichVuDV.TabIndex = 73;
            this.cbbLoaiDichVuDV.Text = "Trống";
            this.cbbLoaiDichVuDV.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiDichVuDV_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 72;
            this.label13.Text = "Loại dịch vụ :";
            // 
            // dgvDichVuDV
            // 
            this.dgvDichVuDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVuDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDichVuDV.Location = new System.Drawing.Point(95, 421);
            this.dgvDichVuDV.Name = "dgvDichVuDV";
            this.dgvDichVuDV.RowHeadersWidth = 51;
            this.dgvDichVuDV.RowTemplate.Height = 29;
            this.dgvDichVuDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVuDV.Size = new System.Drawing.Size(896, 206);
            this.dgvDichVuDV.TabIndex = 70;
            this.dgvDichVuDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVuDV_CellClick);
            this.dgvDichVuDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVuDV_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenDichVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "tenDichVu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "loaiDichVu";
            this.dataGridViewTextBoxColumn3.HeaderText = "loaiDichVu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "GiaTien";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(745, 286);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(255, 59);
            this.btnSuaDV.TabIndex = 69;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(745, 204);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(255, 59);
            this.btnThemDV.TabIndex = 68;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnShowDV
            // 
            this.btnShowDV.Location = new System.Drawing.Point(745, 120);
            this.btnShowDV.Name = "btnShowDV";
            this.btnShowDV.Size = new System.Drawing.Size(255, 59);
            this.btnShowDV.TabIndex = 63;
            this.btnShowDV.Text = "Show";
            this.btnShowDV.UseVisualStyleBackColor = true;
            this.btnShowDV.Click += new System.EventHandler(this.btnShowDV_Click);
            // 
            // txtGiaTienDV
            // 
            this.txtGiaTienDV.Location = new System.Drawing.Point(236, 302);
            this.txtGiaTienDV.Name = "txtGiaTienDV";
            this.txtGiaTienDV.Size = new System.Drawing.Size(363, 27);
            this.txtGiaTienDV.TabIndex = 67;
            this.txtGiaTienDV.TextChanged += new System.EventHandler(this.txtGiaTienDV_TextChanged);
            this.txtGiaTienDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTienDV_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemDV);
            this.groupBox2.Controls.Add(this.txtTimKiemDV);
            this.groupBox2.Location = new System.Drawing.Point(95, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 72);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm ";
            // 
            // btnTimKiemDV
            // 
            this.btnTimKiemDV.Location = new System.Drawing.Point(527, 21);
            this.btnTimKiemDV.Name = "btnTimKiemDV";
            this.btnTimKiemDV.Size = new System.Drawing.Size(117, 37);
            this.btnTimKiemDV.TabIndex = 25;
            this.btnTimKiemDV.Text = "Tìm kiếm";
            this.btnTimKiemDV.UseVisualStyleBackColor = true;
            this.btnTimKiemDV.Click += new System.EventHandler(this.btnTimKiemDV_Click);
            // 
            // txtTimKiemDV
            // 
            this.txtTimKiemDV.Location = new System.Drawing.Point(17, 31);
            this.txtTimKiemDV.Name = "txtTimKiemDV";
            this.txtTimKiemDV.PlaceholderText = "Nhập mã hoặc tên dịch vụ";
            this.txtTimKiemDV.Size = new System.Drawing.Size(472, 27);
            this.txtTimKiemDV.TabIndex = 25;
            // 
            // txtTenDichVuDV
            // 
            this.txtTenDichVuDV.Location = new System.Drawing.Point(236, 183);
            this.txtTenDichVuDV.Name = "txtTenDichVuDV";
            this.txtTenDichVuDV.Size = new System.Drawing.Size(363, 27);
            this.txtTenDichVuDV.TabIndex = 65;
            // 
            // txtIdDichVuDV
            // 
            this.txtIdDichVuDV.Location = new System.Drawing.Point(236, 120);
            this.txtIdDichVuDV.Name = "txtIdDichVuDV";
            this.txtIdDichVuDV.ReadOnly = true;
            this.txtIdDichVuDV.Size = new System.Drawing.Size(363, 27);
            this.txtIdDichVuDV.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Giá tiền :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "Tên dịch vụ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(114, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 59;
            this.label17.Text = "IDDichVu :";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1098, 754);
            this.Controls.Add(this.cbbLoaiDichVuDV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvDichVuDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.btnShowDV);
            this.Controls.Add(this.txtGiaTienDV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTenDichVuDV);
            this.Controls.Add(this.txtIdDichVuDV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbLoaiDichVuDV;
        private Label label13;
        private DataGridView dgvDichVuDV;
        private Button btnSuaDV;
        private Button btnThemDV;
        private Button btnShowDV;
        private TextBox txtGiaTienDV;
        private GroupBox groupBox2;
        private Button btnTimKiemDV;
        private TextBox txtTimKiemDV;
        private TextBox txtTenDichVuDV;
        private TextBox txtIdDichVuDV;
        private Label label14;
        private Label label16;
        private Label label17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}