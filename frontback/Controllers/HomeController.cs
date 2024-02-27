using frontback.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace frontback.Controllers
{
    public class HomeController : Controller
    {
        private readonly PronioDbContext _context;

        public HomeController(PronioDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {


            var sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}
