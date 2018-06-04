using System;

namespace lesson8
{
    public interface IMeasurable
    {
        float GetWidth();
        float Height {get;set;}
    }

    public interface IInchesMeasurable
    {
        float GetWidth();
        float Height {get;set;}
    }
    public class Box:IMeasurable,IInchesMeasurable
    {
        public float Width{get;set;}
        public float Height{get;set;}
        public float WidthInInches{get{return Width/1.6f;}}
        public float HeightInInches{get{return Height/1.7f;}}

        public float GetWidth()
        {
            return Width;
        }

        float IInchesMeasurable.GetWidth()
        {
            return Width/2.6f;
        }
    }
}