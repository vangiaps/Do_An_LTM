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
        
        public TcpClient ClientConnect( string ip, int port)
        {
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            return client;
        }
    }
}
