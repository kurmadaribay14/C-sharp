using System;
using System.Collections;

namespace task4
{
    public class GreenPen : Pen
    {
        public string _hardness { get; set; }
        public override string ToString() //Возвращает строковое представление текущего объекта
        {
            return $"{_color} {_hardness}";
        }
    }
}