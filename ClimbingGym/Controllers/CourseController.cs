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

        public async Task<IActionResult> Details(Guid id)
        {

            var course = await service.GetCourse(id);

            return View(course);
        }

        public async Task<IActionResult> Coach(Guid id)
        {
            var coach = await service.GetCoach(id);

            return View(coach);
        }

        public async Task<IActionResult> CoachCourses(Guid id)
        {
            var coachCourses = await service.GetCoachCourses(id);
            return View(coachCourses);
        }
    }
}
