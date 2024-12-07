using AutoMapper;
using StoreSystem.Data;
using StoreSystem.Dtos.Store;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using StoreSystem.Services.IService;
using System.Collections.Generic;

namespace StoreSystem.Services.Service
{
    public class StoreService: IStoreService
    {   
        private readonly IStoreRepository _storeRepo;
        private readonly IStoreItemRepository _storeItemRepo;
        private readonly IMapper _mapper;
        public StoreService(IStoreRepository storeRepo, IStoreItemRepository storeItemRepo, IMapper mapper)
        {
            _storeRepo = storeRepo;
            _storeItemRepo = storeItemRepo;
            _mapper = mapper;
        }

        public IEnumerable<StoreDetailsDto> GetStores()
        {
            var retrievedStores = _storeRepo.GetAllStores();

            var stores = _mapper.Map<IEnumerable<StoreDetailsDto>>(retrievedStores);

            return stores;
        }
        public StoreDetailsDto GetStoreDetails(int id)
        {
            var retrievedStore = _storeRepo.GetStore(id);
            

            var store = _mapper.Map<StoreDetailsDto>(retrievedStore);

            return store;

        }
        public void Add(CreateStoreDto createStore) {
            
            var storeToAdd = _mapper.Map<Store>(createStore);
        
            _storeRepo.Add(storeToAdd);
        }

        public void Update(int id, UpdateStoreDto updateStore)
        {
            var storeToUpdate = _mapper.Map<Store>(updateStore);

            storeToUpdate.Id = id;

            _storeRepo.Update(storeToUpdate);
        }

        public void Delete(int id) {
            var storeToDelete = _storeRepo.GetStore(id);

            var store = _mapper.Map<Store>(storeToDelete);
            var storeItemsList = store.Items.ToList();
            foreach(var storeItem in storeItemsList)
            {
                _storeItemRepo.Delete(storeItem);
            }

            _storeRepo.Delete(store);
        }

    }
}
