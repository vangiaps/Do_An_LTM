// Ghi đè file này lên file Form1.Designer.cs của bạn
// Namespace này phải khớp với project của bạn
namespace do_an_LTM
{
    // Thêm các using này vào
    using System.Drawing;
    using System.Windows.Forms;

    partial class Login
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
            panelLeft = new Panel();
            labelProjectTitle = new Label();
            linkLabel1 = new LinkLabel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(0, 122, 204);
            labelTitle.Location = new Point(422, 70);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(196, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Login to System";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(380, 150);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(84, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(380, 220);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(79, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top;
            textBoxUsername.Font = new Font("Segoe UI", 14F);
            textBoxUsername.Location = new Point(384, 174);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(280, 32);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Font = new Font("Segoe UI", 14F);
            textBoxPassword.Location = new Point(384, 244);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(280, 32);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top;
            buttonLogin.BackColor = Color.FromArgb(0, 122, 204);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(384, 308);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(280, 45);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 122, 204);
            panelLeft.Controls.Add(labelProjectTitle);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 461);
            panelLeft.TabIndex = 6;
            // 
            // labelProjectTitle
            // 
            labelProjectTitle.Dock = DockStyle.Fill;
            labelProjectTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectTitle.ForeColor = Color.White;
            labelProjectTitle.Location = new Point(0, 0);
            labelProjectTitle.Name = "labelProjectTitle";
            labelProjectTitle.Size = new Size(280, 461);
            labelProjectTitle.TabIndex = 0;
            labelProjectTitle.Text = "WELLCOME\r\n";
            labelProjectTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(540, 285);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have a account?\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(panelLeft);
            Controls.Add(linkLabel1);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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

        // Thêm khai báo cho các control mới
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelProjectTitle;
        private LinkLabel linkLabel1;
    }
}