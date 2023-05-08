using ETicaret.Models;

namespace ETicaret.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Task UpdateAsync(Actor newActor);

        Task DeleteAsync(int id);
    }
}