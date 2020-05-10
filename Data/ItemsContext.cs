using Microsoft.EntityFrameworkCore;

namespace RESTful.Data
{
    public class ItemsContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options) { }
    }
}
