using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models;
using ClimbingGym.Core.Models.Routes;
using ClimbingGym.Infrastructure.Data;
using ClimbingGym.Infrastructure.Data.Identity;
using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace ClimbingGym.Core.Services
{
    public class RouteService : IRouteService
    {
        private readonly IApplicationDbRepository repo;
        public RouteService(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public async Task<Route> GetRouteById(Guid id)
        {
            return await repo.GetByIdAsync<Route>(id);
        }

        public async Task<IEnumerable<RoutesListViewModel>> GetRoutes(Guid sectorId)
        {
            return await repo.All<Route>()
                .Where(r => r.SectorId == sectorId)
                .Include(r => r.Sector)
                .Select(r => new RoutesListViewModel()
                {
                    Id = r.Id,
                    SectorId = r.SectorId,
                    Color = r.Color,
                    SectorName = r.Sector.Name,
                    Name = r.Name,
                    Description = r.Description,
                    Grade = r.Grade,
                    DateFrom = r.DateFrom,
                    DateTo = r.DateTo
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<SectorsListViewModel>> GetSectors()
        {
            return await repo.All<Sector>()
                .Select(s => new SectorsListViewModel()
                {
                    SectorId = s.Id,
                    Name = s.Name
                })
                .OrderBy(s => s.Name)
                .ToListAsync();
        }
    }
}
