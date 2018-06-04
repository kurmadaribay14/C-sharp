using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ser2
{
    public class Program
    {
        public class Student{
        public string Name {get; set;}
        public int DateOfBirth {get; set;}
        public string PlaceOfBirth {get; set;}

        public int ID {get; set;}
        public float GPA {get; set;}
        public override string ToString()  
        {
            return($"{Name} {DateOfBirth} {PlaceOfBirth} {ID} {GPA} ");
        }  
    }
        static void Create()
        {
            Student s = new Student();
            FileStream fs = new FileStream("student.txt", FileMode.CreateNew);
            Student [] ss = new Student[2];
            ss[0] = new Student(){ID = 01, Name = "Kurma", DateOfBirth = 14071998, PlaceOfBirth = "Kyzylorda", GPA = 3.5f};
            ss[1]= new Student(){ID = 02, Name = "Askar", DateOfBirth = 18081997, PlaceOfBirth = "Taraz", GPA = 4.2f};
            XmlSerializer xmlsrl = new XmlSerializer (typeof(Student[]));
            xmlsrl.Serialize(fs,ss);
            fs.Flush();
        }

        static Student GetStudent(string filename)
        {
            Student s = new Student();
            FileStream fs = new FileStream (filename,FileMode.Open);
            XmlSerializer xmlsrl = new XmlSerializer(typeof(Student[]));

            Student [] ss = (Student[])xmlsrl.Deserialize(fs);
        
            foreach (var st in ss)
            System.Console.WriteLine(st);
            return s;
        }
        
        static void Main(string[] args)
        {
            Create();
            GetStudent("student.txt");
        }
    }
    }



            
            
            
            
        
