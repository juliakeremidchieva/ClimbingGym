using ClimbingGym.Infrastructure.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimbingGym.Infrastructure.Data
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
    }
}
