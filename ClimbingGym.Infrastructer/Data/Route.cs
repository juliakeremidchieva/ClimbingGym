using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimbingGym.Infrastructure.Data
{
    public class Route
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid SectorId { get; set; } 
        [ForeignKey(nameof(SectorId))]
        public Sector Sector { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        [Required]
        [StringLength(25)]
        public string Grade { get; set; }
        [Required]
        [StringLength(25)]
        public string Color { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateTo { get; set; }
    }
}