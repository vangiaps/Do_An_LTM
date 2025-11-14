using Client;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        Connect connect = new Connect();
        private TcpClient serverConnect = null;

        public Login()
        {
            InitializeComponent();
        }
        private async void Login_Load(object sender, EventArgs e)
        {
            try
            {
                serverConnect = await Task.Run(() =>
                connect.ClientConnect("192.168.155.102", 9999)
                );
                lblStatus.Text = "Da ket noi";
            }
            catch(SocketException)
            {
                lblStatus.Text = "khong ket noi";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            // chuyen sang dang ki\
            register.FormClosed += new FormClosedEventHandler(register_FormClosed);
            register.Show();
        }

        private void register_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (serverConnect== null || !serverConnect.Connected)
            {
                MessageBox.Show("chua ket noi den server");
                return;
            }

            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("nhap day du tai khoan mat khau");
                return;
            }
            try
            {
                await connect.SendLoginRequest(serverConnect, user, pass);

                // 2. NHẬN PHẢN HỒI #1 (Chạy trên luồng nền)
                string response1 = await Task.Run(() =>
                    connect.ReceiveResponse(serverConnect)
                );

                if (response1 == "WAITING_CONFIRMATION")
                {
                    lbltb.Text = "Đăng nhập đúng. Đang chờ admin xác nhận...";
                    string response2 = await Task.Run(() =>
                    connect.ReceiveResponse(serverConnect)
                );
                    if (response2 == "PASS")
                    {
                        MessageBox.Show("Admin đã xác nhận. Đăng nhập thành công!");
                        lblStatus.Text = "san sang";
                    }
                    else // (Là "REJECTED")
                    {
                        MessageBox.Show("Admin đã từ chối yêu cầu đăng nhập.");
                        lblStatus.Text = "bi tu choi";
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi");
                lblStatus.Text = "mat ket noi";
            }
        }

    }
}
