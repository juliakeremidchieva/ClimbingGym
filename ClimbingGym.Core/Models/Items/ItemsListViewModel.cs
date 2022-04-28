using System.ComponentModel.DataAnnotations;

namespace ClimbingGym.Core.Models.Items
{
    public class ItemsListViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
