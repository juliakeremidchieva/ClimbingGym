using System.ComponentModel.DataAnnotations;

namespace ClimbingGym.Infrastructure.Data
{
    public class Sector
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(2)]
        public string Name { get; set; }
        public ICollection<Route> Routes { get; set; } = new List<Route>();
    }
}