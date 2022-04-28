using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingGym.Core.Models.Courses
{
    public class CourseListViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        [Required]
        public Guid CoachId { get; set; }
        public string CoachName { get; set; }
    }
}
