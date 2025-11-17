namespace Server
{
    partial class ucLoginHistory
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
            panel1 = new Panel();
            listBoxHistory = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxHistory);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 476);
            panel1.TabIndex = 0;
            // 
            // listBoxHistory
            // 
            listBoxHistory.Dock = DockStyle.Top;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(0, 0);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(667, 164);
            listBoxHistory.TabIndex = 0;
            // 
            // ucLoginHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucLoginHistory";
            Size = new Size(667, 543);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBoxHistory;
    }
}
