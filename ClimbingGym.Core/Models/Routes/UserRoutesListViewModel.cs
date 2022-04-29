using System.ComponentModel.DataAnnotations;

namespace ClimbingGym.Core.Models.Routes
{
    public class UserRoutesListViewModel
    {
        public string UserId { get; set; }
        public Guid Id { get; set; }
        public Guid SectorId { get; set; }
        public string SectorName { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
