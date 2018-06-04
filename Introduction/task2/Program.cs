using System;

namespace task2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int [] a = new int [10];
            Random r = new Random();
            for (int i=0;i<a.Length;i++)  
                a[i]=r.Next(1,10);
            foreach (int i in a)
                System.Console.Write(a[i]+" ");
        }
    }
}

