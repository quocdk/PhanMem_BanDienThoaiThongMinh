namespace _3_PL
{
    partial class FrmTong
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
            button1 = new Button();
            btnBanHang = new Button();
            btnQuanLyCuaHang = new Button();
            btnDichVu = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            plChuaTatCaForm = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(-1, 68);
            button1.Name = "button1";
            button1.Size = new Size(208, 65);
            button1.TabIndex = 0;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = SystemColors.ButtonHighlight;
            btnBanHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBanHang.Location = new Point(-1, 131);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(208, 65);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnQuanLyCuaHang
            // 
            btnQuanLyCuaHang.BackColor = SystemColors.ButtonHighlight;
            btnQuanLyCuaHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyCuaHang.Location = new Point(-2, 257);
            btnQuanLyCuaHang.Name = "btnQuanLyCuaHang";
            btnQuanLyCuaHang.Size = new Size(208, 65);
            btnQuanLyCuaHang.TabIndex = 3;
            btnQuanLyCuaHang.Text = "Quản lý cửa hàng";
            btnQuanLyCuaHang.UseVisualStyleBackColor = false;
            btnQuanLyCuaHang.Click += btnQuanLyCuaHang_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.BackColor = SystemColors.ButtonHighlight;
            btnDichVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDichVu.Location = new Point(-2, 194);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(208, 65);
            btnDichVu.TabIndex = 2;
            btnDichVu.Text = "Dịch vụ sửa chữa";
            btnDichVu.UseVisualStyleBackColor = false;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(-1, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 581);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(-2, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 70);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // plChuaTatCaForm
            // 
            plChuaTatCaForm.AutoSize = true;
            plChuaTatCaForm.Location = new Point(210, 73);
            plChuaTatCaForm.Name = "plChuaTatCaForm";
            plChuaTatCaForm.Size = new Size(1280, 720);
            plChuaTatCaForm.TabIndex = 6;
            plChuaTatCaForm.Paint += plChuaTatCaForm_Paint;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1494, 798);
            Controls.Add(plChuaTatCaForm);
            Controls.Add(btnQuanLyCuaHang);
            Controls.Add(btnDichVu);
            Controls.Add(btnBanHang);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmBanHang";
            Text = "FrmBanHang";
            Load += FrmBanHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnBanHang;
        private Button btnQuanLyCuaHang;
        private Button btnDichVu;
        private Panel panel1;
        private Panel panel2;
        private Panel plChuaTatCaForm;
    }
}