using M2DB_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace M2DB_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Alkoholok()
        {
            return View(Services.AlkoholService.GetAlkohol());
        }
        public IActionResult AlkoholokDTOs()
        {
            return View(Services.AlkoholService.GetAlkoholDTOs());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
