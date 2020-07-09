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
        public DbSet<Login> Logins { get; set; }
       
    }
}
