using ClimbingGym.Core.Models.Courses;

namespace ClimbingGym.Core.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListViewModel>> GetCourses();
    }
}
