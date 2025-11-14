using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class DatabaseManager
    {
        public static bool DataUser(string username, string password)
        {
            if (username == "hello" && password == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
