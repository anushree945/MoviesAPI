using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Respository.Interface;

namespace MoviesAPI.Controllers
{
    /// <summary>
    /// API for retrieving movie information
    /// </summary>
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieRespository _movieRespository;

        /// <summary>
        /// Initializes <see cref="MovieController"/>
        /// </summary>
        /// <param name="logger"><see cref="ILogger"/></param>
        /// <param name="movieRespository"><see cref="IMovieRespository"/></param>
        public MovieController(ILogger<MovieController> logger, IMovieRespository movieRespository)
        {
            _logger = logger;
            _movieRespository = movieRespository;
        }

        /// <summary>
        /// Get movie list of supplied genre
        /// </summary>
        /// <param name="genre">genre of the movie</param>
        /// <returns>Movie list having specified genre</returns>
        [HttpGet]
        [Route("genre")]
        public async Task<IActionResult> Get(string genre)
        {
            try
            {
                // if invalid genre is given then return HTTP 400 error
                if(string.IsNullOrEmpty(genre))
                {
                    return BadRequest();
                }

                var movies = await _movieRespository.GetMovieByGenre(genre);

                return movies is not null && movies.Any() ? Ok(movies) : NotFound($"No movie found with {genre} genre");
            }
            catch (Exception ex)
            {
                string errorMessage = "Error in retrieving movies";
                _logger.LogError(ex, errorMessage);
                return StatusCode(500, errorMessage);
            }

        }
    }
}