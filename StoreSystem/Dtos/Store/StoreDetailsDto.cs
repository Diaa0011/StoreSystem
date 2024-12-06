using StoreSystem.Dtos.StoreItem;
using StoreSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.Store
{
    public class StoreDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber {  get; set; }
        [Range(-90, 90)]
        public double Latitude { get; set; }

        [Range(-180, 180)]
        public double Longitude { get; set; }
        public List<Models.StoreItem> Items { get; set; }
    }
}
