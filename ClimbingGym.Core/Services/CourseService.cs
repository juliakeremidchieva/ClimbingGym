using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models.Courses;
using ClimbingGym.Infrastructure.Data;
using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClimbingGym.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly IApplicationDbRepository repo;

        public CourseService(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public async Task<CourseDetailViewModel> GetCourse(Guid id)
        {
            return await repo.All<Course>()
                .Where(c => c.Id == id)
                .Include(c => c.Coach)
                .Select(c => new CourseDetailViewModel()
                {
                    Id = c.Id,
                    CoachId = c.CoachId,
                    CoachName = c.Coach.Name,
                    Name = c.Name,
                    Description = c.Description,
                    EndDate = c.EndDate,
                    Price = c.Price,
                    StartDate = c.StartDate
                })
                .FirstAsync();
        }

        public async Task<IEnumerable<CourseListViewModel>> GetCourses()
        {
            return await repo.All<Course>()
                .Include(c => c.Coach)
                .Select(c => new CourseListViewModel()
                {
                    Name = c.Name,
                    EndDate = c.EndDate,
                    CoachId = c.CoachId,
                    CoachName = c.Coach.Name,
                    Description = c.Description,
                    Id = c.Id,
                    Price = c.Price,
                    StartDate = c.StartDate
                })
                .ToListAsync();
        }
    }
}
