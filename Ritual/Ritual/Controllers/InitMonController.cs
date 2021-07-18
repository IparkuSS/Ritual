using Microsoft.AspNetCore.Mvc;
using Ritual.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ritual.Controllers
{
    public class InitMonController : Controller
    {
        private readonly DataManager dataManager;

        public InitMonController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.IM.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageIntilMonum");
            return View(dataManager.IM.GetServiceItems());
        }
    }
}
