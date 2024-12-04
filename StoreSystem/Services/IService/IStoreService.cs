using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IStoreService
    {
        public IEnumerable<Store> GetStores();
    }
}
