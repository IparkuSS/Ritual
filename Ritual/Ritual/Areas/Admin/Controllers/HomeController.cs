using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ritual.Domain;

namespace Ritual.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        public IActionResult IndexWhres()
        {
            return View(dataManager.Wreath.getWreaths());
        }


        public IActionResult IndexCross()
        {
            return View(dataManager.Cross.GetServiceItems());
        }

    

        public IActionResult IndexDifferent()
        {
            return View(dataManager.Dif.GetServiceItems());
        }

        public IActionResult IndexMonument()
        {
            return View(dataManager.Mon.GetServiceItems());
        }



        public IActionResult IndexBascet()
        {

            return View(dataManager.Mes.GetServiceItems());
        }


        public IActionResult IndexInitMon()
        {
            return View(dataManager.IM.GetServiceItems());
        }
    }

}
