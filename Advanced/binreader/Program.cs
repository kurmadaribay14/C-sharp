using System;
using System.IO;
using System.Text;

namespace binreader
{
    public class Program
    {
        static void Create(){
            Car c = new Car();
            c.EngineVolume = 3.2f;
            c.HorsePowers = 200;
            c.Manufacture = "Mercedes";
            c.ManufactureDate = new DateTime(2007,1,1);
            c.Model = "C class";
            c.TypeOfCar = CarType.Sedan;
            c.TypeOfPower = PowersType.Gasoline;

            FileStream fs = new FileStream("car.txt", FileMode.Create);
            using(BinaryWriter bw = new BinaryWriter(fs)){
                bw.Write(c.EngineVolume);
                bw.Write(c.HorsePowers);
                bw.Write(c.Manufacture);
                bw.Write(c.ManufactureDate.Ticks);
                bw.Write(c.Model);
                bw.Write(Enum.GetName(typeof(CarType), c.TypeOfCar));
                bw.Write(Enum.GetName(typeof(PowersType), c.TypeOfPower));

            }
        }
        
        static Car GetCar(String filename){
            Car c = new Car();
            FileStream fs = new FileStream(filename, FileMode.Open);
            using(BinaryReader br = new BinaryReader(fs)){
                c.EngineVolume = br.ReadSingle();
                c.HorsePowers = br.ReadInt32();
                c.Manufacture = br.ReadString();
                c.ManufactureDate = new DateTime(br.ReadInt64());
                c.Model = br.ReadString();
                c.TypeOfCar = (CarType)Enum.Parse(typeof(CarType),br.ReadString());
                c.TypeOfPower = (PowersType)Enum.Parse(typeof(PowersType),br.ReadString());

                System.Console.WriteLine(c.EngineVolume);
                System.Console.WriteLine(c.HorsePowers);
                System.Console.WriteLine(c.Manufacture);
                System.Console.WriteLine(c.ManufactureDate);
                System.Console.WriteLine(c.Model);
                System.Console.WriteLine(c.TypeOfCar);
                System.Console.WriteLine(c.TypeOfPower);
           }
           return c;
         }
          static void Main(string[] args)
        {
            Create();
            Car c = GetCar("car.txt");  
        }
    }
}

    
