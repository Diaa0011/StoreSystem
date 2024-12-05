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
        public ItemService(IItemRepsitory itemRepository,IMapper mapper)
        {

            _itemRepository = itemRepository;
            _mapper = mapper;
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
        public void Add(CreateItemDto CreateItem)
        {
            var createdItem = _mapper.Map<Item>(CreateItem);

            _itemRepository.Add(createdItem);
        }
        public void Update(int id, UpdateItemDto updateItem)
        {
            var item = _itemRepository.GetItem(id);

            if (item == null)
            {
                throw new Exception("Item not found");
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
