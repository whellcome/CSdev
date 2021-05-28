using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8082;
            var udpEndPoint = new IPEndPoint(ip, port);
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);
            while (true)
            {
                Console.Write("Enter your message: ");
                var message = Console.ReadLine();
                var recieverEndPoint = new IPEndPoint(ip, 8081);
                udpSocket.SendTo(Encoding.UTF8.GetBytes(message), recieverEndPoint);
                if (message.Equals("exit")) break;
                
                var buffer = new byte[256];
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, recieverEndPoint.Port);
                do
                {
                    udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);

                Console.WriteLine(data);
            }
        }
    }
}
