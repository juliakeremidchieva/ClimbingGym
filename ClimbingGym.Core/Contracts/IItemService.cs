using ClimbingGym.Core.Models.Items;
using ClimbingGym.Infrastructure.Data;

namespace ClimbingGym.Core.Contracts
{
    public interface IItemService
    {
        Task<IEnumerable<ItemsListViewModel>> GetItems();
        Task<bool> RentItem(Item item);
        Task<Item> GetItemById(Guid id);

    }
}
