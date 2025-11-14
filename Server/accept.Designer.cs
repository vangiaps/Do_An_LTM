namespace Server
{
    partial class accept
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPendingUsers = new ListBox();
            btnConfirm = new Button();
            btnReject = new Button();
            SuspendLayout();
            // 
            // lstPendingUsers
            // 
            lstPendingUsers.Dock = DockStyle.Bottom;
            lstPendingUsers.FormattingEnabled = true;
            lstPendingUsers.ItemHeight = 15;
            lstPendingUsers.Location = new Point(0, 118);
            lstPendingUsers.Name = "lstPendingUsers";
            lstPendingUsers.Size = new Size(584, 289);
            lstPendingUsers.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(355, 36);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(96, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(471, 36);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(96, 36);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // accept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReject);
            Controls.Add(btnConfirm);
            Controls.Add(lstPendingUsers);
            Name = "accept";
            Size = new Size(584, 407);
            Load += accept_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPendingUsers;
        private Button btnConfirm;
        private Button btnReject;
    }
}
