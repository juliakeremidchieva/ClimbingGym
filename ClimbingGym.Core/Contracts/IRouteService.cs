using ClimbingGym.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingGym.Core.Contracts
{
    public interface IRouteService
    {
        Task<IEnumerable<SectorsListViewModel>> GetSectors();
        Task<IEnumerable<RoutesListViewModel>> GetRoutes(Guid sectorId);
    }
}
