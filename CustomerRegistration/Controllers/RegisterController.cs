using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerRegistration.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerRegistration.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult ViewFormData()
        {
            List<SelectListItem> contactTypes = new List<SelectListItem>() {
                new SelectListItem {
                    Text = "By Phone", Value = "1"
                },
                new SelectListItem {
                    Text = "By Email", Value = "2"
                },
                new SelectListItem {
                    Text = "By Surface Mail", Value = "3"
                },
            };

            ViewBag.ContactTypes = contactTypes;
            return View();
        }

        [HttpPost]
        public IActionResult ViewFormData(RegistrationModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome", registrationModel);
            }

            return View(registrationModel);
        }

        [HttpGet]
        public IActionResult Welcome(RegistrationModel registrationModel)
        {
            return View(registrationModel);
        }
    }
}
