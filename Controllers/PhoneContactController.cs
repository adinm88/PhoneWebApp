using PhoneWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhoneWebApp.Controllers
{
    public class PhoneContactController : Controller
    {
        private PhoneContactContext context { get; set; }

        public PhoneContactController(PhoneContactContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new PhoneContact());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var phoneContact = context.PhoneContacts.Find(id);
            return View(phoneContact);
        }
        [HttpPost]
        public IActionResult Edit(PhoneContact phoneContact)
        {
            if (ModelState.IsValid)
            {
                if (phoneContact.ContactId == 0)
                    context.PhoneContacts.Add(phoneContact);
                else
                    context.PhoneContacts.Update(phoneContact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (phoneContact.ContactId == 0) ? "Add" : "Edit";
                return View(phoneContact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var phoneContact = context.PhoneContacts.Find(id);
            return View(phoneContact);
        }
        [HttpPost]
        public IActionResult Delete(PhoneContact phoneContact)
        {
            context.PhoneContacts.Remove(phoneContact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [Route ("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
