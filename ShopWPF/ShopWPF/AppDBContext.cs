using Microsoft.EntityFrameworkCore;
using ShopWPF.Models;

namespace ShopWPF
{
    public class AppDBContext : DbContext
    {
        
        public DbSet<Product> Shop { get; set; }   

        public AppDBContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server=localhost;port=3306;username=root;password=root;database=shop");
        }

    }
}
