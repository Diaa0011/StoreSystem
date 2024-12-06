using AutoMapper;
using StoreSystem.Dtos.Item;
using StoreSystem.Dtos.Store;
using StoreSystem.Dtos.StoreItem;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using StoreSystem.Services.IService;

namespace StoreSystem.Services.Service
{
    public class StoreItemService:IStoreItemService
    {
        private readonly IStoreItemRepository _storeItemRepository;
        private readonly IStoreRepository _storeRepository;

        private readonly IMapper _mapper;

        public StoreItemService(IStoreItemRepository storeItemRepository,IStoreRepository storeRepository,IMapper mapper) { 

            _storeItemRepository = storeItemRepository;
            _storeRepository = storeRepository;

            _mapper = mapper;
        }

        public IEnumerable<StoreItem> GetAllStoreItems()
        {
            var fetchedStores = _storeItemRepository.GetAll();

            var stores = _mapper.Map<IEnumerable<StoreItem>>(fetchedStores);

            return stores;
        }

        public void AddStoreItem(CreateStoreItemDto createStoreItem, StoreDetailsDto store, ReadItemDto item)
        {
            createStoreItem.itemId = item.Id;
            createStoreItem.storeId = store.Id;

            var storeItem = _mapper.Map<StoreItem>(createStoreItem);

            var storeItems = _storeRepository.GetStore(store.Id).Items;

            bool itemExists = false;

            foreach (var itemUpSert in storeItems)
            {
                if (storeItem.itemId == itemUpSert.itemId)
                {
                    itemUpSert.Quantity += storeItem.Quantity; 
                    _storeItemRepository.Update(itemUpSert);    
                    itemExists = true;  
                    break;  
                }
            }

            if (!itemExists)
            {
                _storeItemRepository.Add(storeItem);
            }

        }
    }
}
