using System;
namespace lesson1
{
    class Program
    {
        static void Main (string[] args)
        {
       
            if (args.Length>0)
            System.Console.Writeline ("Hello "+args[0]+"!");
		else 
            System.Console.Writeline ('Hello World!');

           
		
        }
    }
}
