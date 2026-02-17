using Microsoft.AspNetCore.Mvc;

namespace PhoneWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
