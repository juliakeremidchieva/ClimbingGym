using ClimbingGym.Infrastructer.Data.Common;
using ClimbingGym.Infrastructure.Data;

namespace ClimbingGym.Infrastructer.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
