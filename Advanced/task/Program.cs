using System;
using System.IO;
using System.Text;
//using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using S
//using System.Xml.Serialization.dll;

namespace task
{
    public class Program
    {
        static void Create()
        {
            Student s = new Student();
            FileStream fs = new FileStream("student.txt", FileMode.Create);
            Student [] ss = new Student[2];
            ss[0] = new Student(){ID = 01, Name = "Kurma", DateOfBirth = 14071998, PlaceOfBirth = "Kyzylorda", GPA = 3.5f};
            ss[1]= new Student(){ID = 02, Name = "Askar", DateOfBirth = 18081997, PlaceOfBirth = "Taraz", GPA = 4.2f};
            XmlSerializer xmlsrl = new XmlSerializer (typeof(Student[]));
            xmlsrl.Serialize(fs,ss);
            fs.Flush();
        }

        static Student GetStudent(string file)
        {
            Student s =new Student();
            FileStream fs = new FileStream (file,FileMode.Open);
            XmlSerializer xmlsrl = new XmlSerializer (typeof(Student[]));
            Student [] ss = (Student[])xmlsrl.Deserialize(fs);
        
            foreach (var st in ss)
            System.Console.WriteLine(st);
            return s;
        }
        
        static void Main(string[] args)
        {
           // Create();
            GetStudent("Student.txt");
        }
    }
}


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
         
        
       