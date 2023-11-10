namespace _3_PL
{
    partial class frmLoaiDT
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_danhsach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_tenloaidt = new System.Windows.Forms.TextBox();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.lb_hovatennv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(702, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 565);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(42, 153);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(185, 66);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(42, 49);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(185, 66);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.txb_timkiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgv_danhsach);
            this.groupBox2.Location = new System.Drawing.Point(132, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 298);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Location = new System.Drawing.Point(210, 49);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(234, 27);
            this.txb_timkiem.TabIndex = 29;
            this.txb_timkiem.TextChanged += new System.EventHandler(this.txb_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tìm Kiếm Theo Tên:";
            // 
            // dgv_danhsach
            // 
            this.dgv_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.STT,
            this.Column2});
            this.dgv_danhsach.Location = new System.Drawing.Point(38, 119);
            this.dgv_danhsach.Name = "dgv_danhsach";
            this.dgv_danhsach.RowHeadersWidth = 51;
            this.dgv_danhsach.RowTemplate.Height = 29;
            this.dgv_danhsach.Size = new System.Drawing.Size(483, 153);
            this.dgv_danhsach.TabIndex = 0;
            this.dgv_danhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsach_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Loại Điện Thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Loại Điện Thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txb_tenloaidt);
            this.groupBox1.Controls.Add(this.txb_id);
            this.groupBox1.Controls.Add(this.lb_hovatennv);
            this.groupBox1.Controls.Add(this.lb_manv);
            this.groupBox1.Location = new System.Drawing.Point(132, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Điện Thoại";
            // 
            // txb_tenloaidt
            // 
            this.txb_tenloaidt.Location = new System.Drawing.Point(210, 128);
            this.txb_tenloaidt.Name = "txb_tenloaidt";
            this.txb_tenloaidt.Size = new System.Drawing.Size(234, 27);
            this.txb_tenloaidt.TabIndex = 25;
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(210, 58);
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(234, 27);
            this.txb_id.TabIndex = 24;
            // 
            // lb_hovatennv
            // 
            this.lb_hovatennv.AutoSize = true;
            this.lb_hovatennv.Location = new System.Drawing.Point(36, 128);
            this.lb_hovatennv.Name = "lb_hovatennv";
            this.lb_hovatennv.Size = new System.Drawing.Size(140, 20);
            this.lb_hovatennv.TabIndex = 22;
            this.lb_hovatennv.Text = "Tên Loại Điện Thoại";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(38, 58);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(132, 20);
            this.lb_manv.TabIndex = 21;
            this.lb_manv.Text = "ID Loại Điện Thoại";
            // 
            // frmLoaiDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1098, 754);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoaiDT";
            this.Text = "frmNhaCungCap";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Button btn_sua;
        private Button btn_them;
        private GroupBox groupBox2;
        private TextBox txb_timkiem;
        private Label label2;
        private DataGridView dgv_danhsach;
        private GroupBox groupBox1;
        private TextBox txb_tenloaidt;
        private TextBox txb_id;
        private Label lb_hovatennv;
        private Label lb_manv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Column2;
    }
}