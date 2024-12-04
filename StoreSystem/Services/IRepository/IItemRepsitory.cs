using StoreSystem.Models;

namespace StoreSystem.Services.IRepository
{
    public interface IItemRepsitory
    {
        public IEnumerable<Item> GetAllStores();
    }
}
