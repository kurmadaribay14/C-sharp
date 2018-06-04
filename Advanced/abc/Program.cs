using System;
using Microsoft.Data.Sqlite;

namespace abc
{
    class Program
    {

          static void InitDatabase(string DataFile="team2.db")
          {
            SqliteConnection connection = new SqliteConnection("Data source = ./"+ DataFile);
            connection.Open();
            Create(connection);
           // InsertDataGroups(connection);
            InsertDataStudents(connection);
            connection.Close();
        }
        static void Create(SqliteConnection connection){
            System.Console.WriteLine("Want you create 1-Student or 2-Group?");
            string s = Console.ReadLine();
            switch(s)
                {
                    case "1": 
                    SqliteCommand cmd = new SqliteCommand($"create table stu(id number primary key, s_name varchar(20), s_age number)", connection);
                    cmd.ExecuteNonQuery();
                    break;
                    case "2":
                    SqliteCommand cmd2 = new SqliteCommand($"create table gr(g_id number primary key, g_name varchar(20), advisor varchar(30)), foreign key(s_id) references stu(id)",connection);
                    cmd2.ExecuteNonQuery();
                    break;
        }
        }
        static void InsertDataGroups(SqliteConnection connection){
            System.Console.WriteLine("Enter group id:");
            string g_id=Console.ReadLine();
            System.Console.WriteLine("Enter group name:");
            string g_name=Console.ReadLine();
            System.Console.WriteLine("Enter group advisor:");
            string adv=Console.ReadLine();
            System.Console.WriteLine("Enter student id:");
            string s_id=Console.ReadLine();
            SqliteCommand cmd = new SqliteCommand($"insert into gr values ({g_id}, '{g_name}', '{adv}', {s_id})",connection);
            cmd.ExecuteNonQuery();
            
        }
        static void InsertDataStudents(SqliteConnection connection){
            System.Console.WriteLine("Please, write the name of Student:");
            string s_name=Console.ReadLine();
            System.Console.WriteLine("Enter id:");
            string id=Console.ReadLine();
            System.Console.WriteLine("Enter age:");
            string s_age=Console.ReadLine();
            SqliteCommand cmd = new SqliteCommand($"insert into stu values ({id},'{s_name}','{s_age}')",connection);
            cmd.ExecuteNonQuery();
        }
      
        static void CheckDatabase(string DataFile = "team2.db"){
            SqliteConnection connection = new SqliteConnection("Data Source = ./" + DataFile);
            connection.Open();
            RetrieveTables(connection);
            //RetrieveStudents(connection);
            //DeleteDataStudents(connection, "Anna");
            UpdateStudents(connection);
            connection.Close();
        }
        static void DeleteDataStudents(SqliteConnection connection, string Sname){
            SqliteCommand cmd = new SqliteCommand($"delete from stu where s_name = '{Sname}'", connection);
            cmd.ExecuteNonQuery();
            System.Console.WriteLine("Group's name is deleted");
        }
        static void RetrieveTables(SqliteConnection connection){
            System.Console.WriteLine("--------------------------------------------------------");
            SqliteCommand cmd = new SqliteCommand($"select * from stu",connection);
            SqliteDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                System.Console.WriteLine($"{dr[0]} - {dr[1]} {dr[2]}");
            }
        }
        static void UpdateStudents(SqliteConnection connection){
            Console.Write("Enter name(in table): "); 
            string name = Console.ReadLine(); 
            Console.Write("Enter new name: "); 
            string name2 = Console.ReadLine();  
            SqliteCommand cmd = new SqliteCommand($"update stu set s_name='{name2}' where s_name='{name}'", connection);  
            cmd.ExecuteNonQuery(); 
            System.Console.WriteLine("Name updated");
        }
        static void Main(string[] args)
        {
           
            //while(true)
           // {
            Console.WriteLine("Enter option:\n1.Create Student\n2.Update information\n3.Delete student\n4.Show all contacts\n5.Exit\n" );
            string choice=Console.ReadLine();
                switch(choice)
                {
                    case "1": 
                    InitDatabase();
                    CheckDatabase();
                    break;
                    case "2":
                    CheckDatabase();
                    break;
                    
                    

                }
            //}

           
        }
    }


    }

 