using Microsoft.EntityFrameworkCore;
 
namespace CrudDelicious.Models
{
    public class CrudDeliciousContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CrudDeliciousContext(DbContextOptions options) : base(options) { }

         public DbSet<Dish> Dishes { get;set;}
    }
}