using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;

namespace Ritual.Controllers
{
    public class MonumentController : Controller
    {
        private readonly DataManager dataManager;

        public MonumentController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Mon.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageMonument");
            return View(dataManager.Mon.GetServiceItems());
        }
    }
}
