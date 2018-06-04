using System;
using Microsoft.EntityFrameworkCore;

namespace lesson10
{
    class ApplicationDbContext:DbContext
    {
        public DbSet<Group> Groups {get;set;}
        public DbSet<Student> Students {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =./data.db");
        }
       
    }
}