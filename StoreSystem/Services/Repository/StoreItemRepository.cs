using StoreSystem.Data;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;

namespace StoreSystem.Services.Repository
{
    public class StoreItemRepository:IStoreItemRepository
    {
        private readonly AppDbContext _db;
        public StoreItemRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<StoreItem> GetAll()
        {
            var storeItems = _db.storeItems.ToList();
            return storeItems;
        }
        public void Add(StoreItem storeItem)
        {
            _db.storeItems.Add(storeItem);
            _db.SaveChanges();
        }
        public void Update(StoreItem storeItem) {
            _db.storeItems.Update(storeItem);
            _db.SaveChanges();
        }
        public void Delete(StoreItem storeItem) {
            _db.storeItems.Remove(storeItem);
            _db.SaveChanges();
        }
    }
}
