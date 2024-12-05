using StoreSystem.Dtos.Store;
using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IStoreService
    {
        public IEnumerable<Store> GetStores();
        public void Add(CreateStoreDto createStore);
    }
}
