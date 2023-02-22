namespace MoviesAPI.Models
{
    /// <summary>
    /// DTO for Movie Table
    /// </summary>
    public class MovieDto
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of the movie
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Genre of the movie
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Year when the movie was released
        /// </summary>
        public int ReleaseYear { get; set; }
    }
}
