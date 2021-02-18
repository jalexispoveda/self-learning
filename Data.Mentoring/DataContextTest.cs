using Data.Mentoring.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Mentoring
{
    public class DataContextTest : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JD8S44H;Database=CEA8;Trusted_Connection=True;");
        }
        // public DbSet<Country> country { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
