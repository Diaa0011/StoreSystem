using AutoMapper;
using StoreSystem.Dtos.Item;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using StoreSystem.Services.IService;

namespace StoreSystem.Services.Service
{
    public class ItemService:IItemService
    {
        private readonly IItemRepsitory _itemRepository;
        public readonly IMapper _mapper;
        private readonly string _uploadsFolder;

        public ItemService(IItemRepsitory itemRepository,IMapper mapper)
        {

            _itemRepository = itemRepository;
            _mapper = mapper;

            _uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

        }
        public IEnumerable<ReadItemDto> GetAllItems()
        {
            var itemList =_itemRepository.GetAllItems();

            var items = _mapper.Map<IEnumerable<ReadItemDto>>(itemList);

            return items;
        }
        public ReadItemDto GetItem(int Id) {
            var itemFromRepo = _itemRepository.GetItem(Id);

            var item = _mapper.Map<ReadItemDto>(itemFromRepo);

            return item;
        }
        public void Add(CreateItemDto createItem, IFormFile imageFile)
        {
            string uniqueFileName = null;

            if (imageFile != null && imageFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                     imageFile.CopyTo(fileStream);
                }
            }
            createItem.ImagePath = uniqueFileName != null ? Path.Combine("images", uniqueFileName) : null;

            var createdItem = _mapper.Map<Item>(createItem);

            _itemRepository.Add(createdItem);
        }
        public void Update(int id, UpdateItemDto updateItem,IFormFile imageFile)
        {
            var item = _itemRepository.GetItem(id);

            if (item == null)
            {
                throw new Exception("Item not found");
            }
            if (imageFile != null && imageFile.Length > 0)
            {
                string uniqueFileName = null;
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }

                updateItem.ImagePath = Path.Combine("images", uniqueFileName);
            }

            var updatededItem = _mapper.Map<Item>(updateItem);

            updatededItem.Id = id;

            _mapper.Map(updateItem, item);

            _itemRepository.Update(item);
        }

        public void Delete(int id)
        {
            var item = _itemRepository.GetItem(id);


            if (item == null)
            {
                throw new Exception("Item not found");
            }

            _itemRepository.Delete(id);
        }
    }
}
