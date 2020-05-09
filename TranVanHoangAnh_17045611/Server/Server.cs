using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Byte[] bytes = new Byte[256];
            String data = null;
            while (true)
            {
                Console.Write("Waiting for a connection... ");             
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");
                data = null;
                NetworkStream stream = client.GetStream();
                int i;
                // Lặp lại để nhận tất cả dữ liệu được gửi bởi clinet
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // chuyển byte sang ASSCII
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", data);

                    // dữ liệ client gửi đến
                    data = data.ToUpper();

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    // gửi lại phản hồi
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Sent: {0}", data);
                }

                client.Close();
                Console.ReadLine();
            }
        }
    }
}
