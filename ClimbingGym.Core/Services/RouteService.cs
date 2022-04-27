using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models;
using ClimbingGym.Infrastructure.Data;
using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClimbingGym.Core.Services
{
    public class RouteService : IRouteService
    {
        private readonly IApplicationDbRepository repo;

        public RouteService(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<SectorsListViewModel>> GetSectors()
        {
            return await repo.All<Sector>()
                .Select(s => new SectorsListViewModel()
                {
                    SectorId = s.Id,
                    Name = s.Name
                })
                .ToListAsync();
        }
    }
}
