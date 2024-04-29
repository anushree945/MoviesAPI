using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.DbContexts
{
    /// <summary>
    /// EF DbContext class
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Initializes <see cref="ApplicationDbContext"/>
        /// </summary>
        /// <param name="options">DbContextOptions</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Table name
        /// </summary>
        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                T = "Mr. India",
                G = "Fantasy",
                ReleaseYear = 1988
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                T = "Golmaal",
                G = "Comedy",
                ReleaseYear = 2005
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                T = "Swades",
                G = "Drama",
                ReleaseYear = 2003
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                T = "A Wednesday",
                G = "Thriller",
                ReleaseYear = 2008
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                T = "Bhool Bhulaiyaa",
                G = "Comedy",
                ReleaseYear = 2007
            });
        }
    }
}
