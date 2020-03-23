using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using c3o.portfolio.web.Models;
using c3o.portfolio.Finhub;

namespace c3o.portfolio.web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(FinnhubService finnhubService)
        {
            this.finnhubService = finnhubService;
        }


        private FinnhubService finnhubService { get; set; }

        public IActionResult Index()
        {
            var service = new FinnhubService();

            var ridivends = service.GetDividends("AAPL");

            return View(ridivends);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";



            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
