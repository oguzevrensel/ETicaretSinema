using ETicaret.Data.Base;
using ETicaret.Models;

namespace ETicaret.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}