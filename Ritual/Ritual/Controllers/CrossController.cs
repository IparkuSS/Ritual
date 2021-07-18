using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;

namespace Ritual.Controllers
{
    public class CrossController : Controller
    {
        private readonly DataManager dataManager;

        public CrossController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
           
            if (id != default)
            {
                return View("Show", dataManager.Cross.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageCross");
            return View(dataManager.Cross.GetServiceItems());
        }
    }
}
