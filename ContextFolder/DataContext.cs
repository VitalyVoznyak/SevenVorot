using Microsoft.EntityFrameworkCore;
using SevenVorot.Models;

namespace SevenVorot.ContextFolder
{
    public class DataContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
                DataBase=SevenVorot;
                Trusted_Connection=True;"
            );
        }
    }

}
