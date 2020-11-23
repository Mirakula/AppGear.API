using Microsoft.AspNetCore.Mvc;

namespace AppGear.API.Controllers
{
    public class LorawanController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}