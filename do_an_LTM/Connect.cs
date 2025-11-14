using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    class Connect
    {
        public void ClientConnect()
        {
            TcpClient client = new TcpClient();

            try
            {
                // --- 1. Thử kết nối ---
                // "127.0.0.1" là IP của máy bạn, 9999 là port
                client.Connect("192.168.155.102", 9999);

                // --- 2. Báo thành công ---
                // Nếu dòng trên chạy qua mà không lỗi, tức là đã kết nối thành công
                MessageBox.Show("Kết nối Server thành công!", "Thành công");

                // (Chúng ta không gửi hay nhận gì cả, chỉ test kết nối)
            }
            catch (SocketException)
            {
                // --- 3. Báo thất bại ---
                // Lỗi này xảy ra nếu Server chưa chạy hoặc bị tường lửa chặn
                MessageBox.Show("Không thể kết nối đến Server!", "Thất bại");
            }
            finally
            {
                // --- 4. Luôn đóng kết nối ---
                if (client.Connected)
                {
                    client.Close();
                }
            }
        }
    }
}
