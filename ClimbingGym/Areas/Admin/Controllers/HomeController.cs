using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
