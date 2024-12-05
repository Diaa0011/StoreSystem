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
        private readonly IMapper _mapper;
        public StoreService(IStoreRepository storeRepo,IMapper mapper)
        {
            _storeRepo = storeRepo;
            _mapper = mapper;
        }

        public IEnumerable<Store> GetStores()
        {
            return _storeRepo.GetAllStores();
        }
        public void Add(CreateStoreDto createStore) {
            var storeToAdd = _mapper.Map<Store>(createStore);
            _storeRepo.Add(storeToAdd);
        }
    }
}
