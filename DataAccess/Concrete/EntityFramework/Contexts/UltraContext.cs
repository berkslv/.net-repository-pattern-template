using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    /// <summary>
    /// Veritabanı ve ORM için context belirlenir.
    /// </summary>
    public class UltraContext : DbContext
    {
        /// <summary>
        /// Veritabanı bağlantısı sağlanır.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;database=super;user=root;password=1234");
        }
        
        public DbSet<Product> Products { get; set; }
    }
}