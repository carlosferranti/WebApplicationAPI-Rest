using Domain;
using Microsoft.EntityFrameworkCore;
using System;

//using DbContext = Microsoft.EntityFrameworkCore.DbContext;
//using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100);
            //modelBuilder.Entity<Produto>().Property(p => p.Quantidade).HasMaxLength(80);
            //modelBuilder.Entity<Produto>().Property(p => p.Status).HasMaxLength(80);
           
            //base.OnModelCreating(modelBuilder);
        }

       

    }
}
