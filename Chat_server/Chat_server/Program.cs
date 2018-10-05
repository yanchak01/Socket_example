using System;
using System.Net.Sockets;
using System.Text;
using System.Net;


namespace Chat_server
{
    class Program
    {
        static Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 904);
            mySocket.Bind(iPEndPoint);
            mySocket.Listen(10); // кількість людей
            Socket client = mySocket.Accept();

            byte[] buffer = new byte[1024];

            client.Receive(buffer);

            string message = Encoding.ASCII.GetString(buffer);

            Console.WriteLine(message);
            Console.ReadKey();

        }
    }
}
