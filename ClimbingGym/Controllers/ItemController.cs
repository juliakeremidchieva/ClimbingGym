using ClimbingGym.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    public class ItemController : BaseController
    {
        private readonly IItemService service;

        public ItemController(IItemService _service)
        {
            service = _service;
        }
        public async Task<IActionResult> Index()
        {

            var items = await service.GetItems();

            return View(items);
        }
        //public async Task<IActionResult> Rent(Guid id)
        //{
        //    var item = await service.GetItemById(id);
        //    var hasEnoughItems = await service.RentItem(item);
        //}
    }
}
