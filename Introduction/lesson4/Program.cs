using System;

namespace lesson4
{
    class Program
    {
       
        static void PrintArray (int [] a)
        {
            foreach (int value in a)
                System.Console.WriteLine(value+" ");
            System.Console.WriteLine();
        }

        static void Swap (ref int left, ref int right)
        {
            int temp= left;
            left= right;
            right = left;

        }
        
        static int [] CreateArray(int size)
        {
            int [] a = new int [size];
            Random r = new Random();
            for (int i=0;i<a.Length;i++)
                a[i]=r.Next(1,10);
            return a;
            
        }
       
        static void Main(string[] args)
        {

            int [] array = CreateArray(10);

            PrintArray(array);
           
		//bubble sort 
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for (int i = 0; i<array.Length-1;i++)
                {
                    if (array[i]>array[i+1])
                    {
                        Swap (ref array[i], ref array[i+1]);
                        sorted = false;
                    }
                }
            }
            PrintArray(array);
        }
    }
    }