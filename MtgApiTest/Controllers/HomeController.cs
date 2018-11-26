using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MtgApiTest.Models;
using MtgApiManager.Lib.Service;

namespace MtgApiTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string cardName)
        {
            if (cardName != null)
            {
                CardService service = new CardService();
                var result = service.Where(x => x.Name, cardName).All();
                var value = result.Value;
                ViewBag.results = value;
            }

            return View();
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
