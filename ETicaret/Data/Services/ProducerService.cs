using ETicaret.Data.Base;
using ETicaret.Models;

namespace ETicaret.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducerService
    {
        public ProducerService(AppDbContext context) : base(context)
        {

        }
    }
}