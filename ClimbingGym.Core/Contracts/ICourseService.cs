using ClimbingGym.Core.Models.Courses;

namespace ClimbingGym.Core.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseListViewModel>> GetCourses();
        Task<CourseDetailViewModel> GetCourse(Guid id);
        Task<CoachViewModel> GetCoach(Guid id);
        Task<IEnumerable<CourseListViewModel>> GetCoachCourses(Guid id);

    }
}
