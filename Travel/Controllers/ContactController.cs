using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
