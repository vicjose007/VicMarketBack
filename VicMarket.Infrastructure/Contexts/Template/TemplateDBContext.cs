using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VicMarket.Domain.BaseModel.BaseEntity;
using VicMarket.Domain.Entities;

namespace VicMarket.Infrastructure.Contexts.VicMarket
{
    public class VicMarketDbContext : DbContext, IVicMarketDbContext
    {
        public VicMarketDbContext(DbContextOptions<VicMarketDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public DbSet<T> GetDbSet<T>() where T : class, IBaseEntity => Set<T>();

        ChangeTracker IVicMarketDbContext.ChangeTracker()
        {
            return base.ChangeTracker;
        }
    }
}
