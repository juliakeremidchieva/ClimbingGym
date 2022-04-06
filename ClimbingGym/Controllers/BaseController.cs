using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
