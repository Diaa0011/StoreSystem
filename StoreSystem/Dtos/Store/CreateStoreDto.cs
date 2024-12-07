using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.Store
{
    public class CreateStoreDto
    {
        [Required(ErrorMessage = "Store name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "Address can't exceed 250 characters.")]
        public string Address {  get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        //[RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Phone number must be valid.")]
        public string PhoneNumber {  get; set; }
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
