using Microsoft.EntityFrameworkCore;

namespace lasttask
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }   
        public DbSet<Car> Cars { get; set; }      
        public DbSet<Color> Colors { get; set; }
        public DbSet<RefColorCar> RefColorCar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ./data.db");
        }
    }
}