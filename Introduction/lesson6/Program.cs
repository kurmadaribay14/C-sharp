using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Human [] hs = new Human [2];

            hs [0] = new Human (){Name = "Askar", Age = 19};
            hs [1] = new Student (){Name = "Kurma", Age = 18, University = "SDU"};
            foreach (var h in hs)
            {
                System.Console.WriteLine(h);
            }
        }
    }
}
