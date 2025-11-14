namespace Server
{
    partial class Server_qly_taiKhoan
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            button3 = new Button();
            btnLichSuDangNhap = new Button();
            btnQuanLyTaiKhoan = new Button();
            panelMainContent = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 48);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 413);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(btnLichSuDangNhap);
            panel4.Controls.Add(btnQuanLyTaiKhoan);
            panel4.Location = new Point(3, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 177);
            panel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 110);
            button3.Name = "button3";
            button3.Size = new Size(191, 55);
            button3.TabIndex = 2;
            button3.Text = "Xác nhận";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnLichSuDangNhap
            // 
            btnLichSuDangNhap.Dock = DockStyle.Top;
            btnLichSuDangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichSuDangNhap.Location = new Point(0, 55);
            btnLichSuDangNhap.Name = "btnLichSuDangNhap";
            btnLichSuDangNhap.Size = new Size(191, 55);
            btnLichSuDangNhap.TabIndex = 1;
            btnLichSuDangNhap.Text = "Lịch sử đăng nhập";
            btnLichSuDangNhap.UseVisualStyleBackColor = true;
            btnLichSuDangNhap.Click += btnLichSuDangNhap_Click;
            // 
            // btnQuanLyTaiKhoan
            // 
            btnQuanLyTaiKhoan.Dock = DockStyle.Top;
            btnQuanLyTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyTaiKhoan.Location = new Point(0, 0);
            btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            btnQuanLyTaiKhoan.Size = new Size(191, 55);
            btnQuanLyTaiKhoan.TabIndex = 0;
            btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            btnQuanLyTaiKhoan.Click += btnQuanLyTaiKhoan_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Location = new Point(200, 54);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(584, 407);
            panelMainContent.TabIndex = 2;
            // 
            // Server_qly_taiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(784, 461);
            Controls.Add(panelMainContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Server_qly_taiKhoan";
            Text = "Server";
            Load += Server_qly_taiKhoan_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMainContent;
        private Panel panel4;
        private Button button3;
        private Button btnLichSuDangNhap;
        private Button btnQuanLyTaiKhoan;
    }
}
