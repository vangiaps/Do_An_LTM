using System;
using System.Threading.Tasks; // Vẫn cần Task
using System.Windows.Forms;

namespace Server
{
    public partial class Server_qly_taiKhoan : Form
    {
        ServerNetwork server = new ServerNetwork();
        public Server_qly_taiKhoan()
        {
            InitializeComponent();
        }

        private void Server_qly_taiKhoan_Load(object sender, EventArgs e)
        {
            // hiển thị luôn trang qly tk khi khởi động
            LoadControlToPanel(new ucAccountManagement());
            Task.Run(() =>
            {
                server.StartServer();
            });

            this.Text = "Server - Đang chạy...";
        }
        private void LoadControlToPanel(Control userControl)
        {
            // 1. Xóa tất cả mọi thứ đang có trong panel
            panelMainContent.Controls.Clear();

            // 2. Thiết lập cho control mới
            userControl.Dock = DockStyle.Fill; // Cho nó tự lấp đầy panel

            // 3. Thêm control mới vào panel
            panelMainContent.Controls.Add(userControl);
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            // 1. Tạo một thể hiện mới của màn hình Quản lý
            ucAccountManagement uc = new ucAccountManagement();

            // 2. Tải nó vào panel chính
            LoadControlToPanel(uc);
        }

        private void btnLichSuDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Tạo một thể hiện mới của màn hình Lịch sử
            ucLoginHistory uc = new ucLoginHistory();

            // 2. Tải nó vào panel chính
            LoadControlToPanel(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accept uc = new accept();

            // 2. Tải nó vào panel chính
            LoadControlToPanel(uc);
        }
    }
}
