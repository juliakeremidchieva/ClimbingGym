using ClimbingGym.Core.Contracts;
using ClimbingGym.Core.Models.Items;
using ClimbingGym.Infrastructure.Data;
using ClimbingGym.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClimbingGym.Core.Services
{
    public class ItemService : IItemService
    {
        private readonly IApplicationDbRepository repo;

        public ItemService(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<ItemsListViewModel>> GetItems()
        {
            return await repo.All<Item>()
                .Select(i => new ItemsListViewModel()
                {
                    Price = i.Price,
                    Description = i.Description,
                    Id = i.Id,
                    Name = i.Name,
                    Quantity = i.Quantity
                })
                .ToListAsync();
        }
    }
}
