using System.ComponentModel.DataAnnotations;

namespace ClimbingGym.Core.Models.Courses
{
    public class CoachViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int YearsOfExperience { get; set; }
        public string Introduction { get; set; }
    }
}
