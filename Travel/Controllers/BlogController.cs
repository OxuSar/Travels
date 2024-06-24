using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        public async Task<IActionResult> Blog()
        {
            return View();
        }
    }
}
