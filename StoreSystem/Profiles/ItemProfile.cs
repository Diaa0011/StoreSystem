using AutoMapper;
using StoreSystem.Dtos.Item;
using StoreSystem.Models;

namespace StoreSystem.Profiles
{
    public class ItemProfile:Profile
    {
        public ItemProfile()
        {
            CreateMap<CreateItemDto, Item>();
            CreateMap<Item, ReadItemDto>();
            CreateMap<Item, UpdateItemDto>();
            CreateMap<UpdateItemDto, Item>();
        }
    }
}
