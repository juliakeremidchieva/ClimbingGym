using ClimbingGym.Core.Constants;
using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models.Routes;
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

        public async Task<IActionResult> Add(Guid routeId)
        {
            //var 
            return Redirect("/Route/RoutesList");
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserRoutesListViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await service.AddRoute(model))
            {
                ViewData[MessageConstant.SuccessMessage] = "Succses!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Error!";
            }

            return View(model);
        }
    }
}
