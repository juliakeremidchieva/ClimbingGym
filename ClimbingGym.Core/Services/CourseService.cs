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

        public async Task<CoachViewModel> GetCoach(Guid id)
        {
            return await repo.All<Coach>()
                   .Where(c => c.Id == id)
                    .Select(c => new CoachViewModel()
                    {
                        Id = c.Id,
                        Introduction = c.Introduction,
                        Name = c.Name,
                        YearsOfExperience = c.YearsOfExperience
                    })
                .FirstAsync();

        }

        public async Task<IEnumerable<CourseListViewModel>> GetCoachCourses(Guid id)
        {
            return await repo.All<Course>()
                .Where(c => c.CoachId == id)
                .Select(c => new CourseListViewModel()
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
                .ToListAsync();
        }

        public async Task<CourseDetailViewModel> GetCourse(Guid id)
        {
            return await repo.All<Course>()
                .Where(c => c.Id == id)
                .Include(c => c.Coach)
                .Select(c => new CourseDetailViewModel()
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
