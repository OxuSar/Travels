using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class DestinationControlle : Controller
    {
        public async Task<IActionResult> Destination()
        {
            return View();
        }
    }
}
