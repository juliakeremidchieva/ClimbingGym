using ClimbingGym.Core.Models;
using ClimbingGym.Core.Models.Routes;

namespace ClimbingGym.Core.Contracts
{
    public interface IRouteService
    {
        Task<IEnumerable<SectorsListViewModel>> GetSectors();
        Task<IEnumerable<RoutesListViewModel>> GetRoutes(Guid sectorId);
        Task<bool> AddRoute(UserRoutesListViewModel model);
    }
}
