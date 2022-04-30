using ClimbingGym.Core.Models;
using ClimbingGym.Infrastructure.Data;

namespace ClimbingGym.Core.Contracts
{
    public interface IRouteService
    {
        Task<Route> GetRouteById(Guid id);
        Task<IEnumerable<SectorsListViewModel>> GetSectors();
        Task<IEnumerable<RoutesListViewModel>> GetRoutes(Guid sectorId);
    }
}
