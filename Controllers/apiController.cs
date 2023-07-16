using Microsoft.AspNetCore.Mvc;

namespace MSIT147_09_Ajax_hw.Controllers
{
    public class apiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
