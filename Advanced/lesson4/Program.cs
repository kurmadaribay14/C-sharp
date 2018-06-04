//BinaryReader:
using System;
using System.IO;
using System.Text;

namespace ConsoleApplication
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


            FileStream fs = new FileStream("car.txt", FileMode.Create);
            using(BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(c.EngineVolume);
                bw.Write(c.HorsePowers);
                bw.Write(c.Manufacture);
                bw.Write(c.ManufactureDate.Ticks);
                bw.Write(c.Model);

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

                System.Console.WriteLine(c.EngineVolume);
                System.Console.WriteLine(c.HorsePowers);
                System.Console.WriteLine(c.Manufacture);
                System.Console.WriteLine(c.ManufactureDate);
                System.Console.WriteLine(c.Model);
              
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
