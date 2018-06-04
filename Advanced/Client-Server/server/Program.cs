using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
 
namespace server
{
    class Program
    {
        static void Main (string [] args)
        {
            Socket s = new Socket (AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
           // IPAddress IPAddress = new IPAddress()
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),5000);//0x7f000001
            s.Bind (endPoint);      
            System.Console.WriteLine("Port received!");
            s.Listen(100);
            System.Console.WriteLine("Listen started!");
            Socket clientSocket = s.Accept();
            System.Console.WriteLine("Connection accepted!");
            byte [] buffer = new byte [1024];
            while(true)
           { 
               clientSocket.Receive(buffer);
              // System.Console.WriteLine(bytesReceived);
               string message = UTF8Encoding.UTF8.GetString(buffer);
               System.Console.WriteLine(message);
               if(message.EndsWith("End"))
                    break;      
           }
           
           
           System.Console.WriteLine("Message Received!");
           clientSocket.Send(UTF8Encoding.UTF8.GetBytes("Message Successfully Received! End"));
           System.Console.WriteLine("Message Sent");
           clientSocket.Dispose();
           System.Console.WriteLine("Client Socket closed");
           s.Dispose();
           System.Console.WriteLine("Socket closed");

        }
    }
}



