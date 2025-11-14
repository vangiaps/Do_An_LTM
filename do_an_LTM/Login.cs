using Client;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_LTM
{
    public partial class Login : Form
    {
        private Connect connect = new Connect();

        // luu tru ket noi
        private TcpClient serverConnect = null;
        public Login()
        {
            InitializeComponent();
        }
        private async void Login_Load(object sender, EventArgs e)
        {
            //connect.ClientConnect();
            try
            {
                serverConnect = await Task.Run(() =>
                connect.ClientConnect("192.168.137.152", 9999)
                );

            }
            catch { }

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

        }

    }
}
