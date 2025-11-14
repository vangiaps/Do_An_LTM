using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Server
{
    public partial class accept : UserControl
    {
        public accept()
        {
            InitializeComponent();
        }

        private void accept_Load(object sender, EventArgs e)
        {
            ServerNetwork.OnClientPendingConfirmation += HandlePendingClient;
        }
        private void HandlePendingClient(string username)
        {
            if (this.InvokeRequired)
            {
                // Gọi lại chính hàm này, nhưng trên luồng UI
                this.Invoke(new Action<string>(HandlePendingClient), username);
                return;
            }
            lstPendingUsers.Items.Add(username);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            RespondToClient("PASS");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            RespondToClient("REJECTED");
        }

        private void RespondToClient(string message)
        {
            if (lstPendingUsers.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một client.");
                return;
            }

            string username = lstPendingUsers.SelectedItem.ToString();
            TcpClient client;

            // Lấy client ra khỏi "Phòng chờ"
            if (ServerNetwork.PendingClients.TryRemove(username, out client))
            {
                try
                {
                    // Gửi phản hồi (PASS hoặc REJECTED)
                    NetworkStream stream = client.GetStream();
                    byte[] responseData = Encoding.UTF8.GetBytes(message);
                    stream.Write(responseData, 0, responseData.Length);

                    // Xong nhiệm vụ, BÂY GIỜ mới đóng kết nối
                    stream.Close();
                    client.Close();

                    // Xóa user khỏi ListBox
                    lstPendingUsers.Items.Remove(username);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi phản hồi: " + ex.Message);
                    // (Có thể client đã tự đóng kết nối)
                }
            }
        }
    }
}
