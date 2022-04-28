using ClimbingGym.Core.Models.Items;

namespace ClimbingGym.Core.Contracts
{
    public interface IItemService
    {
        Task<IEnumerable<ItemsListViewModel>> GetItems();

    }
}
