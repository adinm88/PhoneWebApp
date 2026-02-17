using System.Diagnostics;
using PhoneWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using PhoneWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PhoneWebApp.Controllers
{
    public class HomeController : Controller
    {
        private PhoneContactContext context {  get; set; }

        public HomeController(PhoneContactContext ctx) => context = ctx;
        public IActionResult Index()
        {
            var phoneContacts = context.PhoneContacts.ToList();
            return View(phoneContacts);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
