using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [Range(-90, 90)]
        public double Latitude { get; set; }

        [Range(-180, 180)]
        public double Longitude { get; set; }

    }
}
