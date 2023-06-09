using Microsoft.AspNetCore.Mvc;
using ProjectPractise.Models;

namespace ProjectPractise.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()//contacts
        {
            return View();
        }

        public IActionResult Check(Contact contact)//contacts
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View();
        }
    }
}
