// Ghi đè file này lên file Form1.Designer.cs của bạn
// Namespace này phải khớp với project của bạn
namespace do_an_LTM
{
    // Thêm các using này vào
    using System.Drawing;
    using System.Windows.Forms;

    partial class Register
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
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            labelProjectTitle = new Label();
            panelLeft = new Panel();
            labConfirm = new Label();
            textBoxConfirm = new TextBox();
            label1 = new Label();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(195, 76);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(116, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG KÍ";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(109, 146);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Tài khoản";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(109, 216);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(78, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top;
            textBoxUsername.Font = new Font("Segoe UI", 14F);
            textBoxUsername.Location = new Point(109, 170);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(280, 32);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Font = new Font("Segoe UI", 14F);
            textBoxPassword.Location = new Point(109, 240);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(280, 32);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top;
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.FromArgb(0, 122, 204);
            buttonLogin.Location = new Point(109, 361);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(280, 45);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Đăng kí";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // labelProjectTitle
            // 
            labelProjectTitle.BackColor = Color.White;
            labelProjectTitle.Dock = DockStyle.Fill;
            labelProjectTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectTitle.ForeColor = Color.FromArgb(0, 122, 204);
            labelProjectTitle.Location = new Point(0, 0);
            labelProjectTitle.Name = "labelProjectTitle";
            labelProjectTitle.Size = new Size(280, 461);
            labelProjectTitle.TabIndex = 0;
            labelProjectTitle.Text = "CHÀO MỪNG";
            labelProjectTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 122, 204);
            panelLeft.Controls.Add(labelProjectTitle);
            panelLeft.Dock = DockStyle.Right;
            panelLeft.Location = new Point(504, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 461);
            panelLeft.TabIndex = 6;
            // 
            // labConfirm
            // 
            labConfirm.Anchor = AnchorStyles.Top;
            labConfirm.AutoSize = true;
            labConfirm.Font = new Font("Segoe UI", 12F);
            labConfirm.Location = new Point(109, 282);
            labConfirm.Name = "labConfirm";
            labConfirm.Size = new Size(140, 21);
            labConfirm.TabIndex = 7;
            labConfirm.Text = "Xác thực mật khẩu:";
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.Anchor = AnchorStyles.Top;
            textBoxConfirm.Font = new Font("Segoe UI", 14F);
            textBoxConfirm.Location = new Point(109, 306);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.PasswordChar = '●';
            textBoxConfirm.Size = new Size(280, 32);
            textBoxConfirm.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 37);
            label1.TabIndex = 9;
            label1.Text = "<<";
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(784, 461);
            Controls.Add(label1);
            Controls.Add(labConfirm);
            Controls.Add(textBoxConfirm);
            Controls.Add(panelLeft);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Giữ lại các khai báo biến của bạn
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private Label labelProjectTitle;
        private Panel panelLeft;
        private Label labConfirm;
        private TextBox textBoxConfirm;
        private Label label1;
    }
}