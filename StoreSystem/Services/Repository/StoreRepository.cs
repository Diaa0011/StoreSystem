using Microsoft.EntityFrameworkCore;
using StoreSystem.Data;
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


    }
}
