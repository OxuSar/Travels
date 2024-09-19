using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Travel.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> About()
        {
            // Здесь можно выполнять асинхронные операции, например, запросы к базе данных
            await Task.Delay(1000); // Пример асинхронной операции

            return View();
        }
    }
}
