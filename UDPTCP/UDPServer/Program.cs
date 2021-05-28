using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8081;
            var udpEndPoint = new IPEndPoint(ip, port);
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);
            while (true)
            {
                var buffer = new byte[256];
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);

                Console.WriteLine(data);
                udpSocket.SendTo(Encoding.UTF8.GetBytes("Success"), senderEndPoint);
                
                if (data.ToString().Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                    break;
            }
        }
    }
}
