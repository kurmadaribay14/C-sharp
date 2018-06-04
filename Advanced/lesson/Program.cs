using System;
using System.IO;
using System.Text;

namespace lesson
{
    class Program
    {
        static void Write()
        {
          //  String name = "Hello";
            string str = "Hello Kurma!\r\n";
            FileStream f =new FileStream("someFile.txt", FileMode.Create);
         //   StreamWriter sw = new StreamWriter (f);
            byte [] bytesArray= UTF8Encoding.UTF8.GetBytes(str);
            for (int i=0; i<2; i++)
                f.Write(bytesArray,0,bytesArray.Length);
           
           // System.Console.WriteLine(str);
            //sw.WriteLine(name);
            f.Dispose();
           Console.WriteLine(str);
             
        }
        static void Read()
        {
            FileStream f =new FileStream("someFile.txt", FileMode.Open);
           // StreamReader sr = new StreamReader (f);
            byte [] buffer = new byte [32];
            int actuallyread =0;
           // while(actuallyread=f.Read[buffer,0,32]==32)
            while((actuallyread=f.Read(buffer,0,buffer.Length))==buffer.Length)
            {
	            string str = UTF8Encoding.UTF8.GetString(buffer);
	            System.Console.Write(str);
            }
            if (actuallyread!=0)
            {
                string left =UTF8Encoding.UTF8.GetString(buffer,0,actuallyread);
                System.Console.Write(left);
            }
            
//bitconverter
            //System.Console.WriteLine(b);
           // System.Console.WriteLine($"Can read:(fs.CanRead)");
            //System.Console.WriteLine($"Can seak:(fs.CanSeak)");
            
            
        }
        static void Main(string[] args)
        {
           
            //System.Console.WriteLine("Write your name:");
           // string name = Console.ReadLine();
            //System.Console.WriteLine(name);
           // FileStream fs =new FileStream(name+".txt", FileMode.CreateNew);
          // Write ();
           //Read ();
            while (true)
                {
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
}


