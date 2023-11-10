namespace _3_PL
{
    partial class frmHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_tenhang = new System.Windows.Forms.TextBox();
            this.txb_idhang = new System.Windows.Forms.TextBox();
            this.lb_hovatennv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_danhsach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_suahang = new System.Windows.Forms.Button();
            this.btn_themhang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txb_tenhang);
            this.groupBox1.Controls.Add(this.txb_idhang);
            this.groupBox1.Controls.Add(this.lb_hovatennv);
            this.groupBox1.Controls.Add(this.lb_manv);
            this.groupBox1.Location = new System.Drawing.Point(233, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // txb_tenhang
            // 
            this.txb_tenhang.Location = new System.Drawing.Point(217, 117);
            this.txb_tenhang.Name = "txb_tenhang";
            this.txb_tenhang.Size = new System.Drawing.Size(245, 27);
            this.txb_tenhang.TabIndex = 25;
            // 
            // txb_idhang
            // 
            this.txb_idhang.Location = new System.Drawing.Point(217, 60);
            this.txb_idhang.Name = "txb_idhang";
            this.txb_idhang.ReadOnly = true;
            this.txb_idhang.Size = new System.Drawing.Size(255, 27);
            this.txb_idhang.TabIndex = 24;
            // 
            // lb_hovatennv
            // 
            this.lb_hovatennv.AutoSize = true;
            this.lb_hovatennv.Location = new System.Drawing.Point(48, 124);
            this.lb_hovatennv.Name = "lb_hovatennv";
            this.lb_hovatennv.Size = new System.Drawing.Size(144, 20);
            this.lb_hovatennv.TabIndex = 22;
            this.lb_hovatennv.Text = "Tên Hãng Sản Phẩm:";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(56, 58);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(136, 20);
            this.lb_manv.TabIndex = 21;
            this.lb_manv.Text = "ID Hãng Sản Phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.txb_timkiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgv_danhsach);
            this.groupBox2.Location = new System.Drawing.Point(233, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Location = new System.Drawing.Point(202, 54);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(406, 27);
            this.txb_timkiem.TabIndex = 29;
            this.txb_timkiem.TextChanged += new System.EventHandler(this.txb_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 57);
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
            this.Column3,
            this.Column2});
            this.dgv_danhsach.Location = new System.Drawing.Point(133, 91);
            this.dgv_danhsach.Name = "dgv_danhsach";
            this.dgv_danhsach.RowHeadersWidth = 51;
            this.dgv_danhsach.RowTemplate.Height = 29;
            this.dgv_danhsach.Size = new System.Drawing.Size(475, 168);
            this.dgv_danhsach.TabIndex = 0;
            this.dgv_danhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsach_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Hãng Điện Thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "STT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Hãng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btn_suahang);
            this.groupBox3.Controls.Add(this.btn_themhang);
            this.groupBox3.Location = new System.Drawing.Point(717, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btn_suahang
            // 
            this.btn_suahang.Location = new System.Drawing.Point(42, 153);
            this.btn_suahang.Name = "btn_suahang";
            this.btn_suahang.Size = new System.Drawing.Size(185, 66);
            this.btn_suahang.TabIndex = 1;
            this.btn_suahang.Text = "Sửa";
            this.btn_suahang.UseVisualStyleBackColor = true;
            this.btn_suahang.Click += new System.EventHandler(this.btn_suahang_Click);
            // 
            // btn_themhang
            // 
            this.btn_themhang.Location = new System.Drawing.Point(42, 49);
            this.btn_themhang.Name = "btn_themhang";
            this.btn_themhang.Size = new System.Drawing.Size(185, 66);
            this.btn_themhang.TabIndex = 0;
            this.btn_themhang.Text = "Thêm";
            this.btn_themhang.UseVisualStyleBackColor = true;
            this.btn_themhang.Click += new System.EventHandler(this.btn_themhang_Click);
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1203, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHang";
            this.Text = "frmHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txb_tenhang;
        private TextBox txb_idhang;
        private Label lb_hovatennv;
        private Label lb_manv;
        private DataGridView dgv_danhsach;
        private Button btn_suahang;
        private Button btn_themhang;
        private TextBox txb_timkiem;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}