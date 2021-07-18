using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ritual.Domain;
using Ritual.Domain.Entities;
using Ritual.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ritual.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BascetController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public BascetController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

      
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Mes.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public IActionResult DeleteAllLines()
        {
            dataManager.Mes.DeleteAllItems();
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
