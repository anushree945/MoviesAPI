using MoviesAPI.Models;

namespace MoviesAPI.Respository.Interface
{
    /// <summary>
    /// Movie repository
    /// </summary>
    public interface IMovieRespository
    {
        /// <summary>
        /// Get movie on basis of given genre
        /// </summary>
        /// <param name="genre">genre of the movie</param>
        /// <returns>List of movies of given genre</returns>
        Task<IEnumerable<MovieDto>> GetMovieByGenre(string genre);
    }
}
