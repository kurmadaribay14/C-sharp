using System;
using System.IO;
using System.Text;

namespace task1
{
    class Program
    {
        static void Write()
        {
            System.Console.WriteLine("Please, write the name of file:");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("What's need to be write in file: ");
            string text = System.Console.ReadLine();
            FileStream f = new FileStream(name, FileMode.Create);
            string s = text;
            byte [] bytesArray = UTF8Encoding.UTF8.GetBytes(s);
            f.Write(bytesArray,0,bytesArray.Length);
            f.Dispose();
           
             
        }
        static void Read()
        {
            System.Console.WriteLine("Please, write the name of file must be readen:");
            string name = Console.ReadLine();
            FileStream f = new FileStream(name, FileMode.Open);
            byte [] bytesArray = new byte[f.Length];
            for (int i=0;i<f.Length;i++)
            {
                byte b = (byte)f.ReadByte();
                bytesArray[i]=b;
            }
            string s = UTF8Encoding.UTF8.GetString(bytesArray);
            System.Console.WriteLine(s);
           // StreamReader sr = new StreamReader(f);
           //bitconverter
            //System.Console.WriteLine(b);
           // System.Console.WriteLine($"Can read:(fs.CanRead)");
            //System.Console.WriteLine($"Can seak:(fs.CanSeak)");    
        }
        static void Main(string[] args)
        {
           // while (true)
            //{
                System.Console.WriteLine("Your action: A - Read, B - Write, C- Exit");
                string action = System.Console.ReadLine();
                switch(action)
                {
                    case "A":
                    Read();
                    break;
                    case "B":
                    Write();
                    break;
                    case "C":
                    return;

                }

        }   
    
    }
}


