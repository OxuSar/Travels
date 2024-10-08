using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Travel.Controllers
{
    [Authorize]
    public class AdminController: Controller
    {

    }
}
