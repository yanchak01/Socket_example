using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Chat_client
{
    class Client
    {
        static Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            mySocket.Connect("192.168.0.103", 904);

            string message = Console.ReadLine();

            byte[] buffer = Encoding.ASCII.GetBytes(message);

            mySocket.Send(buffer);

            Console.ReadLine();
            
        }
    }
}
