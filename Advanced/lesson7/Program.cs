using System;
using Microsoft.Data.Sqlite;

namespace lesson7
{
    class Program
    {
        static void InsertUser(SqliteConnection connection,int id,string name,string password)
        {
            SqliteCommand cmd = new SqliteCommand($@"insert into user
                                                    values ('{id}','{name}','{password}')",connection);
            cmd.ExecuteNonQuery();
        }

        static void CreateTable(SqliteConnection connection)
        {
            SqliteCommand cmd = new SqliteCommand($@"create table
                                                    uswer(id number primary key,
                                                        name varchar(10),
                                                        password varchar (10)",connection);
             cmd.ExecuteNonQuery();
        }
        static void InitDatabase(string DataFile="data.db")
        {
            SqliteConnection connection = new SqliteConnection("Data Source =./"+DataFile);
            connection.Open();
            CreateTable(connection);
            InsertUser(connection,1,"K","star");
            InsertUser(connection,2,"D","star");
            connection.Dispose();

        }

       

        static void Main(string[] args)
        {
           CheckDatabase();

        }

        private static void CheckDatabase(string DataFile="data.db")
        {
            SqliteConnection connection = new SqliteConnection("Data Source =./"+DataFile);
            connection.Open();
            PrintAllUsers(connection);
            connection.Dispose();
        }

        private static void PrintAllUsers(SqliteConnection connection)
        {
            SqliteCommand cmd = new SqliteCommand(@"select * from user",connection);
            SqliteDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                System.Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]}");
            }
                
       
            {
                
            }
        }
    }
}
