using Microsoft.AspNetCore.Mvc;
using StoreSystem.Dtos.Item;
using StoreSystem.Services.IService;

namespace StoreSystem.Controllers
{
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService) { 
            _itemService = itemService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var items = _itemService.GetAllItems();

            return View(items);
        }
        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var item = _itemService.GetItem(id);

            return View(item);
        }
        [HttpGet("Create")]
        public IActionResult Create() {
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(CreateItemDto createItem)
        {
            if (ModelState.IsValid)
            {
                _itemService.Add(createItem);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            var item = _itemService.GetItem(id); 
          
            return View(item); 
        }
        [HttpPost]
        public IActionResult Update(int id,UpdateItemDto updateItem)
        {
            if (!ModelState.IsValid)
            {
                return View(updateItem); 
            }
            var existingItem = _itemService.GetItem(id);

            if (existingItem == null)
            {
                return NotFound();
            }
            _itemService.Update(id, updateItem);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var item = _itemService.GetItem(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Delete(int id,deletedItemDto deleteItem)
        {
            _itemService.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
