using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += new FormClosedEventHandler(login_FormClosed);
            login.Show();
        }

        private void login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
