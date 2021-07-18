using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;

namespace Ritual.Controllers
{
    public class DifferentController : Controller
    {
        private readonly DataManager dataManager;

        public DifferentController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Dif.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageDifferent");
            return View(dataManager.Dif.GetServiceItems());
        }
    }
}
