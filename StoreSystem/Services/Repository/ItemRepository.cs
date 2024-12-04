using Microsoft.EntityFrameworkCore;
using StoreSystem.Data;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;

namespace StoreSystem.Services.Repository
{
    public class ItemRepository:IItemRepsitory
    {
        private readonly AppDbContext _db;
        public ItemRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Item> GetAllStores()
        {
            var items = _db.items.FromSqlRaw("SELECT * FROM Items").ToList();

            return items;
        }
    }
}
