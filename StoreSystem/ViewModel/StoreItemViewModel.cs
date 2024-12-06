using StoreSystem.Dtos.Item;
using StoreSystem.Dtos.Store;
using StoreSystem.Models;

namespace StoreSystem.ViewModel
{
    public class StoreItemViewModel
    {
        public IEnumerable<StoreDetailsDto> Stores { get; set; }
        public IEnumerable<ReadItemDto> Items { get; set; }
    }
}
