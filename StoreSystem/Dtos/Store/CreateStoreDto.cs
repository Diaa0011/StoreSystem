using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.Store
{
    public class CreateStoreDto
    {
        public string Name { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber {  get; set; }
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
