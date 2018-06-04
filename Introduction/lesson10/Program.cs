using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson10
{
    class Program{
      /*  public class Stack<T> where T:///IEnumarable<T>     //Program//new() //struct //class
        {
            T [] array = new T[10];
            int index =0 ;
            public void Push(T value)
            {
                if(index<array.Length)
                {
                    array[index++] = value;
                }

            }
            public T Pop()
            {
                if(index>0)
                    return array[--index];
                return default(T);

            }*/

        

        static void Main(string[] args)
        {
            Random r = new Random();
            var result = Enumerable.Range(1000,1000);
            HashSet<int> elements = new HashSet<int>(result);
            var count = elements.Count;
            foreach (var element in elements)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine(count);








            /*List<int> list = new List<int>();//dynamic array
            list.Add(1);

            list.Sort();//Linked has not sort

            System.Console.WriteLine(list[0]);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);

            Stack <int> s = new Stack<int>();
            Queue <int> q = new Queue<int>();

            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1,"Kurma");
            System.Console.WriteLine(dic[77]);

            HashSet<string> hs = new HashSet<string>();//10^6 значениий
            hs.Add("Kurma");
            hs.Add("BErnard");
            hs.Add("Kurma");


            SortedList<int,string> sss = new SortedList<int,string>();
            SortedDictionary<string,string> sd = new SortedDictionary<string,string>();
            SortedSet<string> ss = new SortedSet<string>();*/


            //foreach()...............
            //System.Console.WriteLine(linkedList.);





           /* Stack<float> sf = new Stack<float>();
            //Stack<Program> sf = new Stack<Program>();
            sf.Push(3.2f);
            Stack<int> s = new Stack<int>();
            s.Push(7);
            s.Push(11);
            s.Push(5);

            int val = (int)s.Pop();
            val = (int)s.Pop();
            val = (int)s.Pop();*/
            
                    
                    
        }
        }
}
    

