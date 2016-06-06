using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concret
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
