using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            var tcpEndPoint = new IPEndPoint(ip, port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                tcpSocket.Connect(tcpEndPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine("1." + ex.Message);
                Console.ReadLine();
                
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your message: ");
                    var message = Console.ReadLine();
                    var data = Encoding.UTF8.GetBytes(message);
                    tcpSocket.Send(data);
                    //System.Threading.Thread.Sleep(500);
                    if (message.Equals("exit")) break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("2." + ex.Message);
                    Console.ReadLine();
                    break;
                }

                var buffer = new byte[256];
                int size;
                var answer = new StringBuilder();

                do
                {
                    try
                    {
                        size = tcpSocket.Receive(buffer);
                        answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("3." + ex.Message);
                        Console.ReadLine();
                        break;
                    }
                }
                while (tcpSocket.Available > 0);
                Console.WriteLine(answer);
                
            }
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();

        }
    }
}
