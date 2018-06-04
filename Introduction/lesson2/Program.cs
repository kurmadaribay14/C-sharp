using System;
using System.Globalization;

namespace lesson1
{
    class Program
    {
        static void Main (string[] args)
        {
            int [,] twoDimensionalArray ;
            
             twoDimensionalArray = new int[3,10];
                Random r = new Random();
   // twoDimensionalArray.GetLength(0);
           // string[,] str = new string [3,10];
                 for (int i=0; i<3; i++)
		              for (int j=0; j<10; j++)
		            twoDimensionalArray[i,j] = r.Next(0,100);

                for (int i=0; i<3; i++){
		            for (int j=0; j<10; j++)
                 System.Console.Write(twoDimensionalArray[i,j]+" ");
                 System.Console.WriteLine();
                 
            
           
   
        
        }
    }
}
