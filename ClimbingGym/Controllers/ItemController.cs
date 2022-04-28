using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    public class ItemController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
