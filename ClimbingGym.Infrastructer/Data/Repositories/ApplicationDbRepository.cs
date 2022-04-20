using ClimbingGym.Infrastructer.Data.Common;
using ClimbingGym.Infrastructure.Data;

namespace ClimbingGym.Infrastructer.Data.Repositories
{
    public class ApplicationDbRepository : Repository, IApplicationDbRepository
    {
        public ApplicationDbRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
