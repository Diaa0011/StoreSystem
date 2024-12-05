using StoreSystem.Models;

namespace StoreSystem.Services.IRepository
{
    public interface IStoreRepository
    {
        public IEnumerable<Store> GetAllStores();
        public void Add(Store store);
    }
}
