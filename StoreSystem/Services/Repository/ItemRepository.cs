using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoreSystem.Data;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StoreSystem.Services.Repository
{
    public class ItemRepository:IItemRepsitory
    {
        private readonly AppDbContext _db;
        public ItemRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Item> GetAllItems()
        {
            var items = _db.items.FromSqlRaw("SELECT * FROM Items").ToList();

            return items;
        }
        public Item GetItem(int id)
        {
            var item = _db.items.FromSqlRaw($"SELECT * FROM Items WHERE Id = {id}").FirstOrDefault();

            return item;
        
        }
        public void Add(Item item)
        {
            var sql = "INSERT INTO Items (Name, Description, Price) VALUES (@p0, @p1, @p2)";

            _db.Database.ExecuteSqlRaw(sql, item.Name,item.Description,item.Price);
        }
        public void Update(Item item) {
            var sql = @"UPDATE Items
                      SET
                          Name = @Name,
                          Description = @Description,
                          Price = @Price
                      WHERE Id = @Id;";
            _db.Database.ExecuteSqlRaw(sql,
                    new SqlParameter("@Id", item.Id),
                    new SqlParameter("@Name", item.Name),
                    new SqlParameter("@Description", item.Description),
                    new SqlParameter("@Price", item.Price));
        }
        public void Delete(int id)
        {
            var sql = "DELETE FROM Items WHERE Id = @Id";

            _db.Database.ExecuteSqlRaw(sql, new SqlParameter("@Id", id));
        }
    }
}
