using System.ComponentModel.DataAnnotations;

namespace StoreSystem.Models
{
    public class StoreItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity {  get; set; }
        
        public int itemId { get; set; }
        public Item Item { get; set; }
        public int StoreId { get; set; }
        public Store store { get; set; }

    }
}
