using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    /// <summary>
    /// Model for Movie table
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Unique Id acts as primary key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Title of the movie
        /// </summary>
        [Required]
        public string T { get; set; }

        /// <summary>
        /// Genre of the movie
        /// </summary>
        [Required]
        public string G { get; set; }

        /// <summary>
        /// Year when the movie was released
        /// </summary>
        public int ReleaseYear { get; set; }
    }
}
