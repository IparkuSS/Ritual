using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Ritual.Domain;
using Ritual.Domain.Entities;
using Ritual.Services;

namespace Ritual.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WhreatController : Controller
    {
    private readonly DataManager dataManager;
    private readonly IWebHostEnvironment hostingEnvironment;
    public WhreatController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
    {
        this.dataManager = dataManager;
        this.hostingEnvironment = hostingEnvironment;
    }

    public IActionResult Edit(Guid id)
    {
        var entity = id == default ? new Wreath() : dataManager.Wreath.GetWreathsId(id);
        return View(entity);
    }
    [HttpPost]
    public IActionResult Edit(Wreath model, IFormFile titleImageFile)
    {
        if (ModelState.IsValid)
        {
            if (titleImageFile != null)
            {
                model.TitleImagePath = titleImageFile.FileName;
                using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                {
                    titleImageFile.CopyTo(stream);
                }
            }
            dataManager.Wreath.SaveWreath(model);
            return RedirectToAction(nameof(HomeController.IndexWhres), nameof(HomeController).CutController());
        }
        return View(model);
    }

    [HttpPost]
    public IActionResult Delete(Guid id)
    {
        dataManager.Wreath.DeleteWreath(id);
        return RedirectToAction(nameof(HomeController.IndexWhres), nameof(HomeController).CutController());
    }
    }
}
