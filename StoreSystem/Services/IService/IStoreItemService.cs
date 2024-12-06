using StoreSystem.Dtos.Item;
using StoreSystem.Dtos.Store;
using StoreSystem.Dtos.StoreItem;
using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IStoreItemService
    {
        public IEnumerable<StoreItem> GetAllStoreItems();
        public void AddStoreItem(CreateStoreItemDto createStoreItem, StoreDetailsDto store, ReadItemDto item);

    }
}
