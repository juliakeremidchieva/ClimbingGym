using ClimbingGym.Core.Constants;
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
      
        public async Task<IActionResult> Rent(Guid id)
        {
            var item = await service.GetItemById(id);
            var hasEnoughItems = await service.RentItem(item);

            if (hasEnoughItems)
            {
                ViewData[MessageConstant.SuccessMessage] = "Succesfuly rented!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Not enough items!";
                return View("NotEnough", item);
            }

            return View(item);
        }
    }
}
