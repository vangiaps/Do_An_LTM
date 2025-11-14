using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using Microsoft.VisualBasic.ApplicationServices;

namespace Server
{

    class ServerNetwork
    {
        private TcpListener serverListener;

        // (Trong tương lai, bạn có thể thêm các event ở đây
        //  để báo cho Form biết khi có client kết nối)

        // Hàm này sẽ chạy và "dừng" để chờ client
        // --- BƯỚC 1: TẠO "PHÒNG CHỜ" ---
        // Dùng ConcurrentDictionary để an toàn khi nhiều luồng cùng truy cập
        // Key = Tên username (string)
        // Value = Kết nối của client (TcpClient)
        public static ConcurrentDictionary<string, TcpClient> PendingClients =
            new ConcurrentDictionary<string, TcpClient>();
        // --- BƯỚC 2: TẠO SỰ KIỆN ĐỂ BÁO CHO UI ---
        // (string là username của client)
        public static event Action<string> OnClientPendingConfirmation;
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
                    Console.WriteLine("client ket noi");
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
            NetworkStream stream = null;
            string clientUsername = null; // Lưu tên user lại
            try
            {
                stream = client.GetStream();
                byte[] buffer = new byte[1024];

                // *** THÊM VÒNG LẶP NÀY ***
                // Vòng lặp này giữ cho kết nối "sống"
                while (true)
                {
                    // 1. ĐỌC dữ liệu
                    // Lệnh Read() sẽ "dừng" luồng Task này cho đến khi client gửi
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    // Nếu bytesRead = 0, client đã tự ngắt kết nối
                    if (bytesRead == 0)
                    {
                        break; // Thoát vòng lặp while(true)
                    }

                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string response = "FAIL|Invalid request";

                    // 2. XỬ LÝ (giống hệt code cũ)
                    string[] parts = request.Split('|');
                    if (parts.Length == 3 && parts[0] == "LOGIN")
                    {
                        string username = parts[1];
                        string password = parts[2];

                        if (DatabaseManager.DataUser(username, password))
                        {
                            //response = "SUCCESS";
                            byte[] responseWait = Encoding.UTF8.GetBytes("WAITING_CONFIRMATION");
                            stream.Write(responseWait, 0, responseWait.Length);

                            PendingClients.TryAdd(username, client);
                            //Báo cho Giao diện UI biết
                            OnClientPendingConfirmation?.Invoke(username);
                        }
                        else
                        {
                            response = "FAIL|Username or password incorrect";
                            // 3. GỬI PHẢN HỒI
                            byte[] responseData = Encoding.UTF8.GetBytes(response);
                            stream.Write(responseData, 0, responseData.Length);
                        }
                    }

                }
            }
            catch (IOException)
            {
                // Lỗi này xảy ra khi Client ngắt kết nối đột ngột
                // Đây là lỗi "bình thường", chỉ cần thoát.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi xu ly client: " + ex.Message);
            }
            finally
            {
                // 4. ĐÓNG KẾT NỐI
                // Code chỉ chạy đến đây KHI client ngắt kết nối (bytesRead == 0)
                // hoặc khi có lỗi IO.
                stream?.Close();
                client?.Close();
                Console.WriteLine("Mot client da ngat ket noi.");
            }
        }

    }
}
