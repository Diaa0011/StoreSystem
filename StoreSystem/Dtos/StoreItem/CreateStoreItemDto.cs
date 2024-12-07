using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Dtos.StoreItem
{
    public class CreateStoreItemDto
    {
        [Range(1, 10000, ErrorMessage = "Quantity must be greater than 0.")]
        public int quantity {  get; set; }
        public int itemId { get; set; }
        public int storeId {  get; set; } 
    }
}
