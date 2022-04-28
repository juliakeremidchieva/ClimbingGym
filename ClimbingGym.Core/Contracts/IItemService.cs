using ClimbingGym.Core.Models.Items;
using ClimbingGym.Infrastructure.Data;

namespace ClimbingGym.Core.Contracts
{
    public interface IItemService
    {
        Task<IEnumerable<ItemsListViewModel>> GetItems();
        Task<bool> RentItem(ItemsListViewModel model);
        Task<Item> GetItemById(Guid id);

    }
}
