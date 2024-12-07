using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.Item
{
    public class CreateItemDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string Name {  get; set; }
        [StringLength(1000, ErrorMessage = "Description can't exceed 1000 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 100000, ErrorMessage = "Price must be between 0.01 and 100000.")]
        public decimal Price {  get; set; }
        public string? ImagePath { get; set; }
    }
}
