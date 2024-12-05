using StoreSystem.Dtos.Store;
using StoreSystem.Models;

namespace StoreSystem.Services.IRepository
{
    public interface IStoreRepository
    {
        public IEnumerable<Store> GetAllStores();
        public Store GetStore(int id);
        public void Add(Store store);
        public void Update(Store store);
        public void Delete(Store store);
    }
}
