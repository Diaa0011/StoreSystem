using Microsoft.EntityFrameworkCore;
using StoreSystem.Data;
using StoreSystem.Dtos.Store;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;

namespace StoreSystem.Services.Repository
{
    public class StoreRepository:IStoreRepository
    {
        private readonly AppDbContext _db;

        public StoreRepository(AppDbContext db) {
            _db = db;
        }

        public IEnumerable<Store> GetAllStores()
        {
            var stores = _db.stores.FromSqlRaw("SELECT * FROM Stores").ToList();

            return stores;
        }
        public Store GetStore(int id)
        {
            var store = _db.stores
                    .Include(s => s.Items)
                    .ThenInclude(si => si.Item)// Include StoreItems with the Store
                    .FirstOrDefault(s => s.Id == id);
            return store;
        }
        public void Add(Store store)
        {
            _db.stores.Add(store);
            _db.SaveChanges();
        }
        public void Update(Store store)
        {
            _db.stores.Update(store);
            _db.SaveChanges();
        }
        public void Delete(Store store) 
        { 
            _db.stores.Remove(store);
            _db.SaveChanges();
        }


    }
}
