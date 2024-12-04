using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IItemService
    {
        public IEnumerable<Item> GetItems();
    }
}
