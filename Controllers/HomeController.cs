using Microsoft.AspNetCore.Mvc;
using MSIT147_09_Ajax_hw.Models;
using System.Diagnostics;

namespace MSIT147_09_Ajax_hw.Controllers
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
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult checkAccount()
        {
            return View();
        }
        public IActionResult loadAddress()
        {
            return View();
        }
      
        public IActionResult preview()
        {
            return View();
        }
        public IActionResult loadAddressAsync()
        {
            return View();
        }
        public IActionResult autoComplete()
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