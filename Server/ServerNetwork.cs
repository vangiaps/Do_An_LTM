using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    class ServerNetwork
    {
        private TcpListener serverListener;

        // (Trong tương lai, bạn có thể thêm các event ở đây
        //  để báo cho Form biết khi có client kết nối)

        // Hàm này sẽ chạy và "dừng" để chờ client
        public void StartServer()
        {
            try
            {
                serverListener = new TcpListener(IPAddress.Any, 9999);
                serverListener.Start();

                // Vòng lặp vô tận để chờ client
                while (true)
                {
                    // Chờ client kết nối
                    TcpClient client = serverListener.AcceptTcpClient();

                    // Đã có client kết nối (test thành công)
                    // (Sau này chúng ta sẽ xử lý client ở đây)
                    Task.Run(() =>
                    {
                        HandleClient(client);
                    });
                }
            }
            catch (SocketException ex)
            {
                // (Xử lý lỗi...)
            }
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                MessageBox.Show("client ket noi ");
            }
            catch(Exception ex)
            {

            }
        }
    }
}
