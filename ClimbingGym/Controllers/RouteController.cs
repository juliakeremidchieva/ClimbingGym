using ClimbingGym.Core.Constants;
using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models.Routes;
using ClimbingGym.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClimbingGym.Controllers
{
    public class  RouteController: BaseController
    {
        private readonly IRouteService service;
        private readonly UserManager<ApplicationUser> userManager;

        public RouteController(IRouteService _service, UserManager<ApplicationUser> _userManager)
        {
            service = _service;
            userManager = _userManager;
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

        public async Task<IActionResult> MyRoutes(Guid routeId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserRoutesListViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await service.AddRoute(model, userId))
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
