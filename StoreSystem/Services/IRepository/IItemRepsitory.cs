using StoreSystem.Models;

namespace StoreSystem.Services.IRepository
{
    public interface IItemRepsitory
    {
        public IEnumerable<Item> GetAllItems();
        public Item GetItem(int id);
        public void Add(Item item);
        public void Update(Item item);
        public void Delete(int id);
    }
}
