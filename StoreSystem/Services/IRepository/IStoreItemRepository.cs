using StoreSystem.Models;

namespace StoreSystem.Services.IRepository
{
    public interface IStoreItemRepository
    {
        public IEnumerable<StoreItem> GetAll();
        public void Add(StoreItem storeItem);
        public void Update(StoreItem storeItem);

    }
}
