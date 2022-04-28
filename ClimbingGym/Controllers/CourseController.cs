using ClimbingGym.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseService service;

        public CourseController(ICourseService _service)
        {
            service = _service;
        }
        public async Task<IActionResult> Index()
        {

            var courses = await service.GetCourses();

            return View(courses);
        }
    }
}
