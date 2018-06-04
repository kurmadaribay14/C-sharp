using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;

namespace task4
{
    class Program
    {
        public class PenHolder
    {
        Pen [] _pens;
        
        public PenHolder()
        {
            _pens = new Pen[6];
            _pens[0] = new BluePen() { _color = "blue", _hardness = "HB", _price = 10};
            _pens[1] = new YellowPen() { _color = "yellow", _hardness = "H", _price = 15};
            _pens[2] = new GreenPen() { _color = "green", _hardness = "B", _price = 20};
            _pens[3] = new YellowPen() { _color = "yellow", _hardness = "H", _price = 15};
            _pens[4] = new GreenPen() { _color = "green", _hardness = "B", _price = 20};
            _pens[5] = new BluePen() { _color = "blue", _hardness = "HB", _price = 10};
            
            Array.Sort(_pens);
        }
        public IEnumerator GetEnumerator()// определяет правила перебора коллекции; чтобы класс (коллекцию) можно было скормить циклу
        {
            for(int i = 0; i<_pens.Length; i++)
            {
                yield return (_pens[i]);//для возвращения поочерёдно каждого элемента.
            }
        }
        static void Main(string[] args)
        {
             PenHolder ph = new PenHolder();
            
            foreach (Pen pen in ph)
            {
                Console.WriteLine(pen);
            }
          
        }
        }
    }
}
