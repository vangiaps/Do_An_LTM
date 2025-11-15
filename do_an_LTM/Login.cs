using Client;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        // Khai báo các biến (đã gộp và loại bỏ trùng lặp)
        private Connect connect = new Connect();
        private TcpClient serverConnect = null;

        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            // Sử dụng phiên bản code có xử lý Exception và cập nhật UI
            try
            {
                serverConnect = await Task.Run(() =>
                    // Chú ý: IP này được lấy từ phiên bản thứ 2
                    // Bạn hãy kiểm tra lại xem IP "192.168.155.102" đã đúng chưa
                    connect.ClientConnect("192.168.1.217", 9999)
                );
                lblStatus.Text = "Da ket noi"; // Giữ lại phần cập nhật trạng thái
            }
            catch (SocketException)
            {
                lblStatus.Text = "khong ket noi"; // Giữ lại phần xử lý lỗi cụ thể
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            // chuyen sang dang ki
            register.FormClosed += new FormClosedEventHandler(register_FormClosed);
            register.Show();
        }

        private void register_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            // Giữ lại toàn bộ phần logic đăng nhập (vì phiên bản HEAD không có)
            if (serverConnect == null || !serverConnect.Connected)
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
            buttonLogin.Enabled = false;

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
            catch (Exception ex)
            {
                MessageBox.Show("loi");
                lblStatus.Text = "mat ket noi";
            }
            finally
            {
                buttonLogin.Enabled = true; 
            }
        }
    }
}