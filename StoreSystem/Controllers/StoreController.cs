using Microsoft.AspNetCore.Mvc;
using StoreSystem.Dtos.Store;
using StoreSystem.Services.IService;
using StoreSystem.Services.Service;

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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateStoreDto createStore)
        {
            if (ModelState.IsValid)
            {
                _storeService.Add(createStore);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}
