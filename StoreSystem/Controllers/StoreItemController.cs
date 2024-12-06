using Microsoft.AspNetCore.Mvc;
using StoreSystem.Dtos.StoreItem;
using StoreSystem.Services.IService;
using StoreSystem.ViewModel;

namespace StoreSystem.Controllers
{
    [Route("[controller]")]
    public class StoreItemController : Controller
    {
        private readonly IStoreService _storeService;
        private readonly IItemService _itemService;
        private readonly IStoreItemService _storeItemService;
        public StoreItemController(IItemService itemService,IStoreService storeService ,IStoreItemService storeItemService)
        {
            _itemService = itemService;
            _storeService = storeService;

            _storeItemService = storeItemService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var stores = _storeService.GetStores();
            var items = _itemService.GetAllItems();
            var page_Store_items = new StoreItemViewModel
            {
                Stores = stores,
                Items = items
            };
            return View(page_Store_items);
        }
        [HttpPost]
        public IActionResult Index(CreateStoreItemDto createDto, string action)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            // Fetch the store and item based on the IDs
            var store = _storeService.GetStoreDetails(createDto.storeId);
            var item = _itemService.GetItem(createDto.itemId);

            if (store == null || item == null)
            {
                ModelState.AddModelError("", "Invalid Store or Item selection.");
                return RedirectToAction("Index");
            }

            if (action == "Add")
            {
                // Use the DTO directly to add the store-item relationship
                _storeItemService.AddStoreItem(createDto, store, item);
            }
            

            return RedirectToAction("Index");
        }
    }
}
