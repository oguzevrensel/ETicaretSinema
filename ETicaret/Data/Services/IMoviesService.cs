using ETicaret.Data.Base;
using ETicaret.Data.ViewModels;
using ETicaret.Models;

namespace ETicaret.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<MovieDropdownsVM> GetMovieDropdownsVMValues();

        Task AddMovieAsync(MovieVM entity);
    }
}