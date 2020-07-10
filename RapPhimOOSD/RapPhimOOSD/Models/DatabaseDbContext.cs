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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Quan hệ 1-1 bảng Login-Movie 

            modelBuilder.Entity<Login>()
                .HasOne<Customer>(s => s.customer)
                .WithOne(ad => ad.idAccount)
                .HasForeignKey<Customer>(ad => ad.Id);

            //Quan hệ 1-1 bảng Movie - Trailer
            modelBuilder.Entity<Movie>()
               .HasOne<Trailer>(s => s.trailerLink)
               .WithOne(ad => ad.movie)
               .HasForeignKey<Trailer>(ad => ad.Id);
        }



    }
}
