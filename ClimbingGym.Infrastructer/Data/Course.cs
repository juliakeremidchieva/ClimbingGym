using ClimbingGym.Infrastructure.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimbingGym.Infrastructure.Data
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        [Required]
        public Guid CoachId { get; set; }
        [ForeignKey(nameof(CoachId))]
        public Coach Coach { get; set; }
        [Required]
        public int Capacity { get; set; }
        public IList<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}