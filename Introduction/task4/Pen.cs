using System;
using System.Collections;

namespace task4
{
    public class Comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Pen leftPen= x as Pen;
            Pen rightPen = y as Pen;
            return leftPen._price - rightPen._price ;
        }
    }
    public class Pen : IComparable
    {
        public string _color { get; set; }
        public int _price { get; set; }
        
        public int CompareTo(object obj)
        {
            Pen p = obj as Pen;
            return _price - p._price;
        }
        public override string ToString()
        {
            return $"{_color}";
        }
    }
    
    
}


