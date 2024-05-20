using Microsoft.EntityFrameworkCore;
using spering1.Models;

namespace spering1.DataAccesLayer
{
    public class SperingContext : DbContext
    {
        public SperingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CA-R214-PC05\\SQLEXPRESS;Database=spering;Trusted_Connection=True;");
            base.OnConfiguring(options);
        }
    }
}
