﻿using ETicaret.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor_Movie>().HasKey(ma => new
            {
                ma.ActorId,
                ma.MovieId
            });

            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(m => m.MovieId);


            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(m => m.ActorId);



            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
