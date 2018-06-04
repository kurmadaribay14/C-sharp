using System;
using System.Collections;

namespace lab
{
    public class comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Pen leftPen= x as Pen;
            Pen rightPen = y as Pen;
            return leftPen._price - rightPen._price;
        }
    }
    public class Pen : IComparable
    {
        public string _color { get; set; }
        public int _price { get; set; }
        /*public string _color;
        public string _hardness;
        public int _price;

        public Pen(string color, int price)
        {
            _color = color;
            _hardness = hardness;
            _price = price;
        }*/
        public int CompareTo(object obj)
        {
            Pen p = obj as Pen;
            return p._price - _price;
        }
        public override string ToString()
        {
            return $"{_color}";
        }
    }
    public class BluePen : Pen
    {
        public string _hardness { get; set; }
        public override string ToString()
        {
            return $"{_color} {_hardness}\r\n";
        }
    }
    public class YellowPen : Pen
    {
        public string _hardness { get; set; }
        public override string ToString()
        {
            return $"{_color} {_hardness}\r\n";
        }
    }
    public class GreenPen : Pen
    {
        public string _hardness { get; set; }
        public override string ToString()
        {
            return $"{_color} {_hardness}\r\n";
        }
    }
}


