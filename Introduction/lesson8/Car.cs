using System;
using System.Collections;

namespace lesson8
{
    public class CarPriceAscendingCaomparer:IComparator
    {
        
    }
    public class Car:IComparable
    {
        string _model;
        int  _price;
        public Car(string model,int price)
        {
            _model =model;
            _price = price;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return _model;
        }
    }
}