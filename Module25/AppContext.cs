using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserCredential> UserCredentials { get; set; }

        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=EF;Trusted_Connection=True; Trust Server Certificate = true;");
        }
    }
}
