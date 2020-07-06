using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapPhimOOSD.Models
{
    public class DatabaseDbContext:DbContext
    {
        public DatabaseDbContext(DbContextOptions options): base(options)
        {

        }
        DbSet<Login> Logins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasData(
                new Login() { Id = Guid.NewGuid(), userName = "John", password = "Developer", role = "New York", sessionId = "12345" });
        }
    }
}
