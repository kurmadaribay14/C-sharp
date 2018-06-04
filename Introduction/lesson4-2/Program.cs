using System;

namespace lesson4_2
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
            System.Console.WriteLine("Please, write your numbers in array: ");
            System.Console.ReadLine();
            int [] a = new int [size];
           // Random r = new Random();
            for (int i=0;i<a.Length;i++)
            {
                
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();    
            }
            return a;

            
            }
       
        static void Main(string[] args)
        {
      
            int [] array = CreateArray(10);

            PrintArray(array);
           
		//bubble sort 
            for (int i=0;i<array.Length;i++)
            {
                for (int j=0;j<array.Length;j++)
                {
                    if (array[i]<array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            PrintArray(array);
        }


        }
            
        }
    
