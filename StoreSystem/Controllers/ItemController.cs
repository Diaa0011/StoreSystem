using Microsoft.AspNetCore.Mvc;
using StoreSystem.Services.IService;

namespace StoreSystem.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService) { 
            _itemService = itemService;
        }
        public IActionResult Index()
        {
            var items = _itemService.GetItems();
            return View(items);
        }
    }
}
