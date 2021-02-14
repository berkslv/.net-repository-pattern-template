using Core.Utilities.Security.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Utilities.Security.DataAccess.Concrete.EntityFramework.Contexts
{
    /// <summary>
    /// SecurityContext olarak veritabanı bağlantısı ve map işlemini yapar. EF kullanır.
    /// </summary>
    public class SecurityContext : DbContext
    {
        /// <summary>
        /// Veritabanı bağlantısı kurar.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;database=super;user=root;password=1234");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}