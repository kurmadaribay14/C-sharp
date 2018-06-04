using System;
using System.Collections;

namespace enumarationforbarrack
{
    public class barrack:soldier
    {
       public  string name;
       public int id;
       public barrack(string name,int id): base(name,id)
        {
            this.name = name;
            this.id = id;
        }
        
    }

    public class company:IEnumerable
    {
        private barrack[] barracks;

        public company()
        {
            barracks = new barrack[]{new barrack("mark",12),new barrack("tom",23)};
        }

        IEnumerator IEnumerable.GetEnumerator()//обозночяем что именно это считатель
        {
            return barracks.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            company com = new company();
            soldiercompany soldcom = new soldiercompany();
            foreach (barrack b in com)
            {
                Console.WriteLine(b.name);
            }
            foreach(soldier s in soldcom)
            {
                Console.WriteLine(s.name);
            }
        
        }
    }
    
}
