using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;
using Ritual.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ritual.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;

        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

        [HttpPost]
        public IActionResult Contacts(string Name, string NumberPhone, string Mess)
        {
            Messege messege = new Messege();
            messege.Name = Name;
            messege.NumberPhone = NumberPhone;
            messege.FullMessege = Mess;
            messege.TimeMess = DateTime.Now;
            dataManager.Mes.SaveServiceItem(messege);
            return View();
        }
        public IActionResult Example()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageExample"));
        }
        public IActionResult Grave()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageGrave"));
        }

     
        public IActionResult Car()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageCar"));
        }
        public IActionResult RitualTable()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageRitualTable"));
        }
        public IActionResult AboutUs()
        {

            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageAboutUs"));
        }





    }
}
