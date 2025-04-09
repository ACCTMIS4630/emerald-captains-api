using emerald.captains.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace emerald.captains.Data
{
    public class StoreContext : DbContext{
        public StoreContext(DbContextOptions<StoreContext> options): base(options){ }
        public DbSet<Item> Items { get; set; }
    }
}
