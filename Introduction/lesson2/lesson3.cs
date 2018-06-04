using System;

namespace lesson3
{
    class Program1
    {
        static void Main (string[] args)
        {
            Random r = new Random();
            byte [,] matrix = new byte[10,10];
            byte [] sections = new byte [5];
            sections [0] =10;
            for (i=2; i<5; i++)
            sections [1] =20;
            sections [2] =40;
            sections [3] =60;
            sections [4] =80;

            for (int i=0;i<5;i++) //sections
            {
                int window = 10/5; // get number of columns divided by number of sections 
                int cells = window*10; //number of rows multiplied by window size
                int numberOfFilledCells = cells*sections[i]/100;
                for (int j=0; j<numberOfFilledCells; j++)
                {
                    int step = 10/5;
                    int column = r.Next(i*step,i*step+step);
                    int row = r.Next(0,9);
                    while(matrix[row,column]!=0);
                    {
                      column = r.Next(i*step,i*step+step);
                      row = r.Next(0,9);
                    }

                    matrix[row,column] = (byte)r.Next(1,10);
                }
            }
            for (int i=0;i<10;i++){
                for (int j=0;j<10;j++)
                    System.Console.Write(matrix[i,j]+" ");
                System.Console.WriteLine();

            }
        }

    }

}