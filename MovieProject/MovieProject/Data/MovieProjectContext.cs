using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieProject.Models;

namespace MovieProject.Data
{
    public class MovieProjectContext : DbContext
    {
        public MovieProjectContext (DbContextOptions<MovieProjectContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Casting> Castings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Directing> Directings { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieCategory> MoviesCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TrailerContainer> TrailerContainers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Casting>().ToTable("Casting");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Directing>().ToTable("Directing");
            modelBuilder.Entity<Director>().ToTable("Director");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<MovieCategory>().ToTable("MovieCategory");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<TrailerContainer>().ToTable("TrailerContainer");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Vote>().ToTable("Vote");

            modelBuilder.Entity<MovieCategory>()
                .HasKey(a => new { a.MovieId, a.CategoryId });
            modelBuilder.Entity<Casting>()
                .HasKey(b => new { b.MovieId, b.ActorId });
            modelBuilder.Entity<Directing>()
                .HasKey(c => new { c.MovieId, c.DirectorId });
            modelBuilder.Entity<Order>()
                .HasKey(d => new { d.MovieId, d.UserId });
            modelBuilder.Entity<Rating>()
                .HasKey(e => new { e.MovieId, e.VoteId });
        }
        //public DbSet<MovieProject.Models.Movie> Movie { get; set; } = default!;
    }
}
