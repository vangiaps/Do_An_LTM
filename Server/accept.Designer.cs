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
            reset = new Button();
            SuspendLayout();
            // 
            // lstPendingUsers
            // 
            lstPendingUsers.Dock = DockStyle.Bottom;
            lstPendingUsers.FormattingEnabled = true;
            lstPendingUsers.Location = new Point(0, 159);
            lstPendingUsers.Margin = new Padding(3, 4, 3, 4);
            lstPendingUsers.Name = "lstPendingUsers";
            lstPendingUsers.Size = new Size(667, 384);
            lstPendingUsers.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(406, 48);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(110, 48);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(538, 48);
            btnReject.Margin = new Padding(3, 4, 3, 4);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(110, 48);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // reset
            // 
            reset.Location = new Point(27, 112);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 3;
            reset.Text = "button1";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // accept
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(reset);
            Controls.Add(btnReject);
            Controls.Add(btnConfirm);
            Controls.Add(lstPendingUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "accept";
            Size = new Size(667, 543);
            Load += accept_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPendingUsers;
        private Button btnConfirm;
        private Button btnReject;
        private Button reset;
    }
}
