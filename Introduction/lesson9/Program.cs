using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
           Matrix m = new Matrix("M",3,3);
         //  Matrix n = new Matrix("N",3,3);
           Matrix result = m+m++;
           System.Console.WriteLine(m);
           System.Console.WriteLine(m++);
           System.Console.WriteLine(result);
          
        }
    }
}
