using AutoMapper;
using StoreSystem.Dtos.Store;
using StoreSystem.Models;

namespace StoreSystem.Profiles
{
    public class StoreProfile:Profile
    {
        public StoreProfile()
        {
            CreateMap<CreateStoreDto, Store>();
        }

    }
}
