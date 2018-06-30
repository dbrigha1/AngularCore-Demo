using Microsoft.EntityFrameworkCore;

namespace AngularWebApp.Models
{
    public class WebAppContext : DbContext
    {
        
        public WebAppContext(DbContextOptions<WebAppContext> options) : base (options) {}


        public DbSet<Person> Persons {get; set;} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebApp.db");
        }
    }
}