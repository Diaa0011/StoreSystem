namespace StoreSystem.Dtos.Item
{
    public class UpdateItemDto
    {
        public int Id { get; set; }
        public string Name { get;set; }
        public string Description { get;set; }
        public decimal Price {  get;set; }
        public string? ImagePath { get; set; }
    }
}
