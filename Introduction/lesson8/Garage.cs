using System;
using System.Collections;


namespace lesson8
{
    public class GarageEnumarator : IEnumerator
    {
        Car [] _cars;
        int _index = -1;
        public GarageEnumarator(Car []cars)
        {
            _cars = cars;
        }
        public object Current{
            get{return _cars[_index];}
        }

        public bool MoveNext()
        {
            if(_index<_cars.Length-1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
    public class Garage:IEnumarable
    {
        Car redCar = new Car ("Merceses");
        Car blueCar = new Car ("BMW");
       
        public IEnumerator GetEnumerator()
        {
            //return new GarageEnumerator(_cars);
            for(int i=0;i<_cars.Length;i++)
            yield return redCar;
        }
        

    }

    
}