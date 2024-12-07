using StoreSystem.Dtos.Item;
using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IItemService
    {
        public IEnumerable<ReadItemDto> GetAllItems();
        public ReadItemDto GetItem(int id);
        public void Add(CreateItemDto CreateItem, IFormFile imageFile);
        public void Update(int id, UpdateItemDto updateItem, IFormFile imageFile);
        public void Delete(int id);
    }
}
