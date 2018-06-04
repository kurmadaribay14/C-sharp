using System;

namespace ConsoleApplication
{
    internal class Car
    {
     
        public float EngineVolume { get; internal set; }
        public int HorsePowers { get; internal set; }
        public string Manufacture { get; internal set; }
        public DateTime ManufactureDate { get; internal set; }
        public string Model { get; internal set; }
        public object TypeOfCar { get; internal set; }
        public object TypeOfPower { get; internal set; }
    }

}