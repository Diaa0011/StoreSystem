using StoreSystem.Dtos.Store;
using StoreSystem.Models;

namespace StoreSystem.Services.IService
{
    public interface IStoreService
    {
        public IEnumerable<StoreDetailsDto> GetStores();
        public StoreDetailsDto GetStoreDetails(int id);
        public void Add(CreateStoreDto createStore);
        public void Update(int id, UpdateStoreDto updateStore);
        public void Delete(int id);
    }
}
