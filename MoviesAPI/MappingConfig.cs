using AutoMapper;
using MoviesAPI.Models;

namespace MoviesAPI
{
    /// <summary>
    /// DTO mapper
    /// </summary>
    public class MappingConfig
    {
        /// <summary>
        /// Map model to DTO class
        /// </summary>
        /// <returns>Mapping Configuration</returns>
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MovieDto, Movie>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
