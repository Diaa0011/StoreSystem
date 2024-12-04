using Microsoft.AspNetCore.Mvc;
using StoreSystem.Services.IService;

namespace StoreSystem.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        public IActionResult Index()
        {
            var stores = _storeService.GetStores();

            return View(stores);
        }
    }
}
