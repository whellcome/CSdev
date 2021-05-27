using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            var tcpEndPoint = new IPEndPoint(ip, port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);
            var listener = tcpSocket.Accept();
            while (true)
            {
                
                var buffer = new byte[256];
                int size;
                var data = new StringBuilder();
                do
                {
                    try
                    {
                        size = listener.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    }
                    catch (Exception)
                    {
                        //Console.WriteLine("1." + ex.Message);
                        //Console.ReadLine();
                        break;
                    }
                }
                while (listener.Available > 0);

                Console.WriteLine(data);
                
                if (String.Equals(data.ToString(), "exit", StringComparison.InvariantCultureIgnoreCase)) break;
                try
                {
                    listener.Send(Encoding.UTF8.GetBytes("Success"));
                }
                catch (Exception)
                {
                    //Console.WriteLine("1." + ex.Message);
                    //Console.ReadLine();
                    break;
                }
            }
            try
            {
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("1." + ex.Message);
                Console.ReadLine();

            }
        }
    }
}
