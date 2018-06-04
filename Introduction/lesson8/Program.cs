using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier[] ss = new Soldier[3];
            ss[0] = new Soldier("Tom",1);
            ss[1] = new Soldier("Dan",2);
            ss[2]= new Soldier("Ban",3);
            //Barrack br = new Barrack();
            //foreach (Soldier ss in br)

            Array.Sort(ss);
            for (int i=0; i<ss.Length;i++)
            {
                System.Console.WriteLine(ss[i]+" ");
            }
            //int []a = new int [10];
            //foreach (int element in a)
              //  System.Console.WriteLine(element);



           // Box b = new Box(){Width=10,Height=20};
            //IInchesMeasurable sm = (IInchesMeasurable)b;
            //System.Console.WriteLine(b.GetWidth());
            //System.Console.WriteLine(sm.GetWidth());
           // System.Console.WriteLine(b.WidthInInches);
        }
    }
}
