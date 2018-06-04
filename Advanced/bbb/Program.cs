using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace lasttask{
    class Program
    {
        static void InsertCompany(string Name)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Company c = new Company(){Name=Name};
                ctx.Companies.Add(c);
                ctx.SaveChanges();
            }
        }
        static void ListCompanies()
        {
            using(var ctx = new ApplicationDbContext())
            {
               System.Console.WriteLine("Companies: ");
               foreach (var item in ctx.Companies.Include(c=>c.Cars))
               {
                   System.Console.WriteLine($"{item.Id} {item.Name}");
                   foreach(var car in item.Cars)
                   {
                       System.Console.WriteLine($"\t{car.Id} {car.Name}");
                   }
               } 
            }
        }
       
        static void DeleteCompany(int companyId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Company c = ctx.Companies.Find(companyId);
                ctx.Companies.Remove(c);
                ctx.SaveChanges();
            }
        }
        static Company GetCompany(int companyId)
        {
                using(var ctx = new ApplicationDbContext())
                {   
                    Company c = ctx.Companies.Find(companyId);
                    return c;
                }
        }   
        static void UpdateCompany(int companyId,string newName)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Company company = ctx.Companies.Find(companyId);
                company.Name = newName;
                ctx.SaveChanges();
            }
        }
        static void UpdateDetachedCompany(Company c)
        {
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Update<Company>(c);
                ctx.SaveChanges();
            }
        }
        static void AddStudent(string name,Company c)
        {
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Attach(c);
                Car st = new Car();
                st.Name=name;
                st.CarCompany = c;
                ctx.Cars.Add(st);
                ctx.SaveChanges();
            }
        }
        static void ListCars()
        {
            using(var ctx = new ApplicationDbContext())
            {
                 System.Console.WriteLine("Cars: ");
                foreach(var car in ctx.Cars.Include(st=>st.CarCompany))
                {
                    System.Console.WriteLine($"{car.Id} {car.Name} {car.CarCompany.Name}");
                }
            }
        }
        static void ListDetached()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var Companies = ctx.Companies.AsNoTracking().ToList();
                foreach(var c in Companies)
                    System.Console.WriteLine(c.Name);
            }
        }
        static void CreateColor(string Color)
        {
             using(var ctx = new ApplicationDbContext())
            {
                var sub = new Color(){Name = Color};
                ctx.Add(sub);
                ctx.SaveChanges();
            }
        }
         static Color GetColor(int colorId)
        {
                using(var ctx = new ApplicationDbContext())
                {   
                    Color s = ctx.Colors.Find(colorId);
                    return s;
                }
        }  
        static void LinkColorAndStudent(Car st, Color sb)
        {
            using(var ctx = new ApplicationDbContext())
            {
               ctx.Attach(st);
               ctx.Attach(sb);
               RefColorCar rf = new RefColorCar(){RefCar = st,RefColor=sb};
               ctx.Add(rf);
               ctx.SaveChanges();
            }
        }
        static void ListCarByColor(Color s)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var cars = from st in ctx.Cars
                                join std in ctx.RefColorCar on st.Id equals std.RefCar.Id
                                join sb in ctx.Colors on std.RefColor.Id equals sb.Id
                                where sb.Id == s.Id
                                select st;
                foreach(var st in cars)
                    System.Console.WriteLine(st.Name);
            }
        }

        private static Car GetCar(int carId)
        {
             using(var ctx = new ApplicationDbContext())
                {   
                    Car s = ctx.Cars.Find(carId);
                    return s;
                }
        }
        static void Main(string[] args)
        {
           // Color s = GetColor(1);
            //ListCarByColor(s);
            // CreateColor("Color One");
            // Color s = GetColor(1);
            // Car st = GetCar(1);
            // LinkColorAndCar(st,s);
           // Company g = GetCompany(1);
          //  AddCar("Car One",g);
           // ListCompanys();
          // ListDetached();
           // ListCars();
            System.Console.WriteLine("Enter Company name:");
            InsertCompany(Console.ReadLine());
            ListCompanies();
          //  UpdateCompany(Int32.Parse(Console.ReadLine()),Console.ReadLine());
          //  ListCompanys();
         //   DeleteCompany(Int32.Parse(Console.ReadLine()));
        }

    }
}
