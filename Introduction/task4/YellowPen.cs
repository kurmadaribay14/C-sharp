using System;
using System.Collections;

namespace task4
{
    public class YellowPen : Pen
    {
        public string _hardness { get; set; }
        public override string ToString()
        {
            return $"{_color} {_hardness}";
        }
    }
}