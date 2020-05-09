using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 13000);
            string message = "i am Client";
            // chuyển text sang mảng byte
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            // gửi mess tới server
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Sent: {0}", message);
            data = new Byte[256];
            String responseData = String.Empty;
            // dọc dữ liệu phản hồi từ sơ vờ
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);
            stream.Close();
            client.Close();
            Console.ReadLine();
        }
    }
}
