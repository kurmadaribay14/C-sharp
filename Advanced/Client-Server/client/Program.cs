using System;
//using System.Net;
using System.Net.Sockets;
using System.Text;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket (AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            s.Connect("127.0.0.1",5000);
            System.Console.WriteLine("Your Question?");
            string Question = System.Console.ReadLine();
            string message = DateTime.Now.ToString();
            s.Send(UTF8Encoding.UTF8.GetBytes(message));
            System.Console.WriteLine("Message Sent!");
            byte [] buffer = new byte [1024];
            while(true)
            {
                //System.Console.WriteLine("Cycling");
                s.Receive(buffer);
                string messageReceived = UTF8Encoding.UTF8.GetString(buffer);
                System.Console.WriteLine(messageReceived);
                if(message.EndsWith("End"))
                    break;
            }
            s.Dispose();
    }
        }
    }

