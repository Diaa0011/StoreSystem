using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.Store
{
    public class DeleteStoreDto
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
