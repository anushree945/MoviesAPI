using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.DbContexts;
using MoviesAPI.Models;
using MoviesAPI.Respository.Interface;

namespace MoviesAPI.Respository
{
    /// <summary>
    /// Movie repository
    /// </summary>
    public class MovieRepository : IMovieRespository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes <see cref="MovieRepository"/>
        /// </summary>
        /// <param name="context"><see cref="ApplicationDbContext"/></param>
        /// <param name="mapper"><see cref="IMapper"/></param>
        public MovieRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MovieDto>> GetMovieByGenre(string genre)
        {
            var movies = await _context.Movie
                .Where(p => p.G.ToLower() == genre.ToLower())
                .ToListAsync();
            return _mapper.Map<IEnumerable<MovieDto>>(movies);
        }
    }
}
