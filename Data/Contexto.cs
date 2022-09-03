using Domain;
using Microsoft.EntityFrameworkCore;
using System;

//using DbContext = Microsoft.EntityFrameworkCore.DbContext;
//using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }



    }
}
