using Microsoft.EntityFrameworkCore;

namespace MiniProject005.Models
{
    public class Context : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public Context(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
