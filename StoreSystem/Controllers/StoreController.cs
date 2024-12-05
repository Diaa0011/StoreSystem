using Microsoft.AspNetCore.Mvc;
using StoreSystem.Dtos.Store;
using StoreSystem.Services.IService;
using StoreSystem.Services.Service;

namespace StoreSystem.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var stores = _storeService.GetStores();

            return View(stores);
        }
        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {

            var store = _storeService.GetStoreDetails(id);

            return View(store);
        }
        [HttpGet("Create")]
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
        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            var store = _storeService.GetStoreDetails(id);
            return View(store);
        }

        [HttpPost("Update/{id}")]
        public IActionResult Update(int id,UpdateStoreDto updateStore) { 
            _storeService.Update(id, updateStore);
            return RedirectToAction("Index");
        }
        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var store = _storeService.GetStoreDetails(id);
            return View(store);
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id,DeleteStoreDto deleteStore) 
        {
            _storeService.Delete(id);
            return RedirectToAction("Index");
        }

        

    }
}
