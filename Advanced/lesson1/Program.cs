using System;

namespace lesson1
{
    class Program
    {
        static void Write ()
        {
            string str = "Hello World!\r\n";
            FileStream fs = new FileStream ("File.txt", FileMode.Create);
            byte [] bytesArray = UTF8Encoding.UTF8.GetBytes(str);
  
            
        }
    }
}
