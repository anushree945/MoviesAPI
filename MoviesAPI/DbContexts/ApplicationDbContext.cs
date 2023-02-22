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
                Title = "Mr. India",
                Genre = "Fantasy",
                ReleaseYear = 1988
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Title = "Golmaal",
                Genre = "Comedy",
                ReleaseYear = 2005
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Title = "Swades",
                Genre = "Drama",
                ReleaseYear = 2003
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Title = "A Wednesday",
                Genre = "Thriller",
                ReleaseYear = 2008
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Title = "Bhool Bhulaiyaa",
                Genre = "Comedy",
                ReleaseYear = 2007
            });
        }
    }
}
