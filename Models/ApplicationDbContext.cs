using Microsoft.EntityFrameworkCore;
namespace hamroStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)//base calls constructor of parent class
        {
            
        }
        public DbSet<Product> Products { get; set; }//product.cs should be in models
    }
}
