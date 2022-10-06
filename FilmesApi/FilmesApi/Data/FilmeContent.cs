using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;


namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }
        public DbSet<Filme> Filmes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Filme>(v =>

            {

                v.ToTable("filmes");

                v.HasKey(v => v.Id);



            });

        }
    }
}
