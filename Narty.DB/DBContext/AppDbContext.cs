using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB.DbConext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> BasicItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}