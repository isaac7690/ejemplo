using Microsoft.AspNetCore.Mvc;

namespace ejemplo.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
