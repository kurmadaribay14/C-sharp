using System;

namespace lesson3
{
    class Program1
    {
        static void Main (string[] args)
        {
            int []a = new int [5];
            Random r = new Random();
            for (int i=0;i<5;i++)
            a[i] = r.Next(0,100);

            int minValue = a[0];
            for (int i=0;i<5;i++)
            {
                if (minValue<a[i])
                {
                    minValue = a[i];
                    
                }

            }
            System.Console.Write(minValue);
            }
        }

    }


