using ETicaret.Data.Base;
using ETicaret.Models;

namespace ETicaret.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        {

        }

    }
}