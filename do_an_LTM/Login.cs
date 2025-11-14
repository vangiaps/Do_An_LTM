using Client;

namespace do_an_LTM
{
    public partial class Login : Form
    {
        Connect connect = new Connect();

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            //connect.ClientConnect();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.FormClosed += new FormClosedEventHandler(register_FormClosed);
            register.Show();
        }

        private void register_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            connect.ClientConnect();
        }

    }
}
