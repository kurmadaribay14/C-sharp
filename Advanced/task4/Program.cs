using System;
using Microsoft.Data.Sqlite;

namespace task4
{
    class Program
    {

          static void CreateDatabase(string DataFile="dl.db")
          {
            SqliteConnection connection = new SqliteConnection("Data source = ./"+ DataFile);
            connection.Open();
            Create(connection);
            connection.Close();
        }
        static void InserttData(string DataFile="dl.db")
          {
            SqliteConnection connection = new SqliteConnection("Data source = ./"+ DataFile);
            connection.Open();
            Insert(connection);
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
                    System.Console.WriteLine("Table of students created!");
                    break;
                    case "2":
                    SqliteCommand cmd2 = new SqliteCommand($"create table gr(g_id number primary key, g_name varchar(20), adv varchar(30), s_id int, foreign key(s_id) references stu(id))",connection);
                    cmd2.ExecuteNonQuery();
                    System.Console.WriteLine("Table of groups created!");
                    break;
        }
        }
        static void Insert(SqliteConnection connection){
            System.Console.WriteLine("Want you insert in to 1-Student or 2-Group?");
            string c = Console.ReadLine();
            switch(c)
                {
                    case "1":
                    System.Console.WriteLine("Enter id:");
                    string id=Console.ReadLine();
                    System.Console.WriteLine("Enter student name:");
                    string s_name=Console.ReadLine();
                    System.Console.WriteLine("Enter age:");
                    string s_age=Console.ReadLine();
                    SqliteCommand cmd = new SqliteCommand($"insert into stu values ({id},'{s_name}','{s_age}')",connection);
                    cmd.ExecuteNonQuery();
                    break;
                    case "2":
                    System.Console.WriteLine("Enter group id:");
                    string g_id=Console.ReadLine();
                    System.Console.WriteLine("Enter group name:");
                    string g_name=Console.ReadLine();
                    System.Console.WriteLine("Enter group advisor:");
                    string adv=Console.ReadLine();
                    System.Console.WriteLine("Enter student id:");
                    string s_id=Console.ReadLine();
                    SqliteCommand cmd2 = new SqliteCommand($"insert into gr values ({g_id}, '{g_name}', '{adv}', {s_id})",connection);
                    cmd2.ExecuteNonQuery();
                    break;
            
        }
        }
       static void CheckDatabase1(string DataFile = "dl.db"){
            SqliteConnection connection = new SqliteConnection("Data Source = ./" + DataFile);
            connection.Open();
            RetrieveStu(connection);
            connection.Close();
        }

        static void CheckDatabase2(string DataFile = "dl.db"){
            SqliteConnection connection = new SqliteConnection("Data Source = ./" + DataFile);
            connection.Open();
            RetrieveGr(connection);
            connection.Close();
        }
        static void Delete(SqliteConnection connection){
            System.Console.WriteLine("Want you delete from 1-Student or 2-Group?");
            string d = Console.ReadLine();
            switch(d)
                {
                    case "1": 
                    Console.Write("Enter name(in table): "); 
                    string Sname = Console.ReadLine(); 
                    SqliteCommand cmd = new SqliteCommand($"delete from stu where s_name = '{Sname}'", connection);  
                    cmd.ExecuteNonQuery(); 
                    System.Console.WriteLine("Student's name is deleted");
                    break;
                    case "2":
                    Console.Write("Enter name(in table): "); 
                    string Gname = Console.ReadLine(); 
                    SqliteCommand cmd2 = new SqliteCommand($"delete from gr where g_name = '{Gname}'", connection);  
                    cmd2.ExecuteNonQuery(); 
                    System.Console.WriteLine("Group's name is deleted");
                    break;
        }
        }

        static void DeleteDatabase(string DataFile = "dl.db"){
            SqliteConnection connection = new SqliteConnection("Data Source = ./" + DataFile);
            connection.Open();
            RetrieveStu(connection);
            RetrieveGr(connection);
            Delete(connection);
            connection.Close();
        }

        
        static void RetrieveGr(SqliteConnection connection){
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.WriteLine("Groups:");
            System.Console.WriteLine("--------------------------------------------------------");
            SqliteCommand cmd = new SqliteCommand($"select * from gr",connection);
            SqliteDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                System.Console.WriteLine($"{dr[0]} - {dr[1]} {dr[2]} {dr[3]}");
            }
        }

        static void RetrieveStu(SqliteConnection connection){
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.WriteLine("Students:");
            System.Console.WriteLine("--------------------------------------------------------");
            SqliteCommand cmd = new SqliteCommand($"select * from stu",connection);
            SqliteDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                System.Console.WriteLine($"{dr[0]} - {dr[1]} {dr[2]}");
            }
        }

        static void Update(SqliteConnection connection){
            System.Console.WriteLine("Want you update 1-Student or 2-Group?");
            string t = Console.ReadLine();
            switch(t)
                {
                    case "1": 
                    Console.Write("Enter name(in table): "); 
                    string name = Console.ReadLine(); 
                    Console.Write("Enter new name: "); 
                    string name2 = Console.ReadLine();  
                    SqliteCommand cmd = new SqliteCommand($"update stu set s_name='{name2}' where s_name='{name}'", connection);  
                    cmd.ExecuteNonQuery(); 
                    System.Console.WriteLine("Name updated");
                    break;
                    case "2":
                    Console.Write("Enter name(in table): "); 
                    string n = Console.ReadLine(); 
                    Console.Write("Enter new name: "); 
                    string n2 = Console.ReadLine();  
                    SqliteCommand cmd2 = new SqliteCommand($"update gr set g_name='{n2}' where g_name='{n}'", connection);  
                    cmd2.ExecuteNonQuery(); 
                    System.Console.WriteLine("Name updated");
                    break;
        }
        }

        static void UpdateDatabase(string DataFile = "dl.db"){
            SqliteConnection connection = new SqliteConnection("Data Source = ./" + DataFile);
            connection.Open();
            RetrieveStu(connection);
            RetrieveGr(connection);
            Update(connection);
            connection.Close();
        }
            
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter option:\n1.Create table\n2.Insert data\n3.Update data\n4.Delete data\n5.Show all datas\n6.Exit\n" );
            string choice=Console.ReadLine();

                switch(choice)
                {
                    
                    case "1": 
                    CreateDatabase();
                    CheckDatabase1();
                    break;
                    case "2":
                    InserttData();
                    CheckDatabase1();
                    CheckDatabase2();
                    break;
                    case "3":
                    UpdateDatabase();
                    break;
                    case "4":
                    DeleteDatabase();
                    break;
                    case "5":
                    CheckDatabase1();
                    CheckDatabase2();
                    break;
                    case "6":
                    return;
                    

                }
            }

           
        }
    }


    

 