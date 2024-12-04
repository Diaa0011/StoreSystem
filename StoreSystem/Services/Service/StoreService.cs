using StoreSystem.Data;
using StoreSystem.Models;
using StoreSystem.Services.IRepository;
using StoreSystem.Services.IService;
using System.Collections.Generic;

namespace StoreSystem.Services.Service
{
    public class StoreService: IStoreService
    {   
        private readonly IStoreRepository _storeRepo;
        public StoreService(IStoreRepository storeRepo)
        {
            _storeRepo = storeRepo;
        }

        public IEnumerable<Store> GetStores()
        {
            return _storeRepo.GetAllStores();
        }
    }
}
