using System;

namespace lesson6
{
    public class Shape
    {
            public virtual int Area {get{return 0;}}
        }
     public class Circle:Shape
    {
        public int Radius {get;set;}

        public int GetArea()
        {
            return (int)System.Math.PI + Radius + Radius;
        }
    }

    public class Rectangle:Shape
    {
        
        public int Width {get; set;}

        public int Height {get; set;}

        public int GetArea1()
        {
            return Width + Height;
        }

        public Rectangle (int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea() 
        {
            return Width+Height;
        }

        public int GetWidth()
        {
            return Width;
        }

    }

    public class Box:Rectangle
    {
        public Box (int side): base (side,side)
        {

        }
    }
}
