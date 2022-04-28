using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    public class CourseController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
