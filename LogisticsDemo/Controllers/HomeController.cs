using LogisticsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LogisticsDemo.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogisticsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityService _cityService;

        public HomeController(ILogger<HomeController> logger, ICityService cityService)
        {
            _logger = logger;
            this._cityService = cityService;
        }
        

        public IActionResult Index()
        {
            //ViewBag.cities = new SelectList(_cityService.getCityList(), "Id", "Name");
            List<Cities> c = _cityService.getCityList();
            return View("Index",c);

        }
       [HttpGet]
        public ActionResult getZone(string fromCity, string toCity)
        {
            
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
