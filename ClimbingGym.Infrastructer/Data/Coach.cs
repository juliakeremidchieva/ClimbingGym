using System.ComponentModel.DataAnnotations;

namespace ClimbingGym.Infrastructure.Data
{
    public class Coach
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        public int YearsOfExperience { get; set; }
        [StringLength(250)]
        public string Introduction { get; set; }
        public IList<Course> Coureses { get; set; } = new List<Course>();
    }
}