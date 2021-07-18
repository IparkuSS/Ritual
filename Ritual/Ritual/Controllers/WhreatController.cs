using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;

namespace Ritual.Controllers
{
    public class WhreatController : Controller
    {
        private readonly DataManager dataManager;

        public WhreatController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Wreath.GetWreathsId(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageWhreat");
            return View(dataManager.Wreath.getWreaths());
        }
    }
}
