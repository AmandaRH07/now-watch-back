using Microsoft.EntityFrameworkCore;
using NowWatch.Data.Mappings;
using NowWatch.Data.Models;

namespace NowWatch.Data.Context
{
    public class BdContext : DbContext
    {
        public DbSet<User> UserMaps { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NW;Trusted_Connection=True");
         }
   }
}
