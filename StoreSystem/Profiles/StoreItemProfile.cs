using AutoMapper;
using StoreSystem.Dtos.StoreItem;
using StoreSystem.Models;

namespace StoreSystem.Profiles
{
    public class StoreItemProfile:Profile
    {
        public StoreItemProfile()
        {
            CreateMap<CreateStoreItemDto, StoreItem>();
        }
    }
}
