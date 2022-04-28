using ClimbingGym.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    public class  RouteController: BaseController
    {
        private readonly IRouteService service;

        public RouteController(IRouteService _service)
        {
            service = _service;
        }

        public async Task<IActionResult> Index()
        {
            var sectors = await service.GetSectors();

            return View(sectors);
        }

        public async Task<IActionResult> RoutesList(Guid id)
        {
            var routes = await service.GetRoutes(id);

            return View(routes);
        }
    }
}
