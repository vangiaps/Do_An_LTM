using System;
using System.Data.SqlClient; // <-- QUAN TRỌNG: Thêm thư viện này
using System.Data;
using Microsoft.Data.SqlClient;

namespace Server
{
    public static class DatabaseManager
    {
        // Hàm này CHỈ chứa "địa chỉ" đến CSDL
        private static string GetConnectionString()
        {
            // BẠN PHẢI SỬA LẠI DÒNG NÀY CHO ĐÚNG VỚI MÁY BẠN
            // Server=(local) -- Tên server bạn đăng nhập SSMS
            // Database=NetworkLoginDB -- Tên CSDL bạn tạo
            // Integrated Security=True -- Đăng nhập bằng tài khoản Windows
            return "Server=DESKTOP-85PII9M\\SQLEXPRESS; Database=NetworkLoginDB; Integrated Security=True;";

            // Nếu bạn dùng SQL Express, có thể nó sẽ là:
            // return "Server=.\\SQLEXPRESS; Database=NetworkLoginDB; Integrated Security=True;";
        }

        // (Code truy vấn sẽ ở dưới đây...)
        // (Đây là code tiếp theo bên trong class DatabaseManager)

        /// <summary>
        /// Hàm này kiểm tra xem username và password có khớp trong CSDL không.
        /// </summary>
        public static bool DataUser(string username, string password)
        {
            bool isValid = false;

            // Câu truy vấn SQL
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @username AND Password = @password";

            // "using" sẽ tự động đóng kết nối (conn) và câu lệnh (cmd)
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // --- BẢO MẬT RẤT QUAN TRỌNG ---
                    // Dùng Parameters để CHỐNG TẤN CÔNG SQL INJECTION
                    // Nó sẽ gửi "user" và "pass" một cách an toàn
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        // 1. Mở kết nối
                        conn.Open();

                        // 2. Thực thi câu lệnh
                        // ExecuteScalar dùng khi bạn chỉ muốn lấy 1 giá trị (ô) duy nhất
                        int count = (int)cmd.ExecuteScalar();

                        // 3. Xử lý kết quả
                        if (count == 1) // Nếu tìm thấy 1 hàng khớp
                        {
                            isValid = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Nếu lỗi (sai chuỗi kết nối, CSDL offline...)
                        // In ra cửa sổ Console của Server
                        Console.WriteLine("Loi DB (DataUser): " + ex.Message);
                    }
                } // cmd được tự động dọn dẹp ở đây
            } // conn được tự động đóng và dọn dẹp ở đây

            return isValid;
        }
    }
}