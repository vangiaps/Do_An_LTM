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
        // Giữ lại phương thức ClientConnect
        // (Sử dụng 'string' thay vì 'String' theo quy chuẩn C#)
        public TcpClient ClientConnect(string ip, int port)
        {
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            // neu loi tra ve SocketException (chú thích được giữ lại)
            return client;
        }

        // Giữ lại phương thức SendLoginRequest từ phiên bản mới
        public async Task SendLoginRequest(TcpClient client, string userName, string pass)
        {
            if (client == null || !client.Connected)
            {
                throw new Exception("Chưa kết nối đến server.");
            }
            NetworkStream stream = client.GetStream();
            string loginRequest = $"LOGIN|{userName}|{pass}";
            byte[] requestData = Encoding.UTF8.GetBytes(loginRequest);
            stream.Write(requestData, 0, requestData.Length);
        }

        // Giữ lại phương thức ReceiveResponse từ phiên bản mới
        public string ReceiveResponse(TcpClient client)
        {
            if (client == null || !client.Connected)
            {
                throw new Exception("Chưa kết nối đến server.");
            }
            NetworkStream stream = client.GetStream();
            byte[] responseBuffer = new byte[1024];
            int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);

            return Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
        }
    }
}