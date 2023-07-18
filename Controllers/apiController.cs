using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MSIT147_09_Ajax_hw.Models;

namespace MSIT147_09_Ajax_hw.Controllers
{
    public class apiController : Controller
    {
        private readonly DemoContext _context;

        public apiController(DemoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckAccount(string Name)
        {
            var NameExist = _context.Members.Where(n => n.Name == Name).Any();
            return Json(NameExist);
        }
    }
}
