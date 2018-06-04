using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.XmlSerializer;

namespace ser2
{
    public class Program
    {
        static void Main(string[] args)
        {
        
           TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"),5000);
           listener.Start();

           TcpClient client = listener.AcceptTcpClientAsync().Result;
           using(NetworkStream stream = client.GetStream())
           {
               XmlSerializer sr = new XmlSerializer(typeof(Human));
               Human hm = (Human)sr.Des
           }


    }
}
