using ClimbingGym.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingGym.Areas.Admin.Controllers
{
    [Authorize(Roles = UserConstant.Roles.Administrator)]
    [Area("Admin")]
    public class BaseController : Controller
    {
        
    }
}
