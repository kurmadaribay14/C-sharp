using System;
using Microsoft.EntityFrameworkCore;

namespace lesson10
{
    class Program
    {
        static void InsertGroup(string name)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Group g = new Group(){name="GR1"};
                ctx.Groups.Add(g);
                ctx.SaveChanges();

            }
        }

        static void ListGroups()
        {
            using(var ctx = new ApplicationDbContext())
            {
                foreach(var item in ctx.Groups)
                {
                    System.Console.WriteLine($"{item.id} {item.name}");
                    foreach (var student in item.Students)
                    {
                        System.Console.WriteLine($"\t{student.id} {student.name}");
                    }
                }
            }
        }

        static void DeleteGroup(int groupID)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Group g = ctx.Groups.Find(groupID);
                ctx.Groups.Remove(g);
                ctx.SaveChanges();
            }
        }

        static Group GetGroup(int groupID)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Group g = ctx.Groups.Find(groupID);
                return g;
            }

        }

        static void UpdateGroup(int groupID,string newName)
        {
            using(var ctx = new ApplicationDbContext())
            {
                Group gr = ctx.Groups.Find(groupID);
                gr.name = newName;
                ctx.SaveChanges();
            }
        }
        static void UpdateDetachedGroup(Group g)
        {
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Update<Group>(g);
                ctx.SaveChanges();
            }
        }

        static void AddStudent (string Name, Group g)
        {
             using(var ctx = new ApplicationDbContext())
            {
                ctx.Attach(g);
                Student st = new Student();
                st.name = Name;
                st.StudentGroup = g;
                ctx.Students.Add(st); 
                ctx.SaveChanges();
            }
        }

         static void ListStudents()
        {
            using(var ctx = new ApplicationDbContext())
            {
                System.Console.WriteLine("Students: ");
                foreach(var student in ctx.Students.Include(st=>st.StudentGroup))
                {
                    System.Console.WriteLine($"{student.id} {student.name}");
                }
            }
        }

        static void Main(string[] args)
        {
            //Group g = GetGroup(1);
            //AddStudent("Student 1",g);
            //g.name = "New Group";
           // UpdateDetachedGroup(g);
            ListGroups();
            //ListStudents();
            //System.Console.WriteLine(g.name);
            //Console.WriteLine("Enter group name!");
            //InsertGroup(Console.ReadLine());
            //ListGroups();
            //UpdateGroup(Int32.Parse(Console.ReadLine()),Console.ReadLine());
            //ListGroups();
            //DeleteGroup(Int32.Parse(Console.ReadLine()));
        }
    }
}
