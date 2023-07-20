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
        public IActionResult Cities()
        {
            var cities = _context.Address.Select(c => c.City).Distinct();
            return Json(cities);
        }
        public IActionResult Districts(string city)
        {
            var districts=_context.Address.Where(d=>d.City == city).Select(d=>d.SiteId).Distinct();
            return Json(districts);
        }
        public IActionResult Roads(string siteId)
        {
            var roads = _context.Address.Where(r => r.SiteId == siteId).Select(r=>r.Road);
            return Json(roads);
        }
    }
}
