using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using StoreSystem.Services.IService;

namespace StoreSystem.Services.Service
{
    public class ItemService:IItemService
    {
        private readonly IItemRepsitory _itemRepository;
        public ItemService(IItemRepsitory itemRepository)
        {

            _itemRepository = itemRepository;

        }
        public IEnumerable<Item> GetItems()
        {
            return _itemRepository.GetAllStores();
        }
    }
}
