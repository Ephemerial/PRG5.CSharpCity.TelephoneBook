using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRG5.CSharpCity.TelephoneBook.Data;
using PRG5.CSharpCity.TelephoneBook.MVC2.Models;

namespace PRG5.CSharpCity.TelephoneBook.MVC2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            TelephoneBookViewModel model = new TelephoneBookViewModel();

            model.Everyone = new Data.TelephoneBook().GetContactInfo().OrderByDescending(p => p.LastName).ToList();
            
            return View("FubarOnzinView", model);
        }
    }
}
