using System;
using Library;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {y
           Computer c  = new Computer();
           c._processor = new Processor();
           c._videocard = new VideoCard();

            c._processor._model = "ACER";
            c._processor._frequency = 450;

           c._memory = 6;

           c._videocard._memory = 10;

           System.Console.WriteLine(c._processor._frequency);
           System.Console.WriteLine(c._memory);
           System.Console.WriteLine(vc._memory);



        }
    }
}
