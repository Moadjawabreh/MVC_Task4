using Microsoft.AspNetCore.Mvc;
using Task4.Data;
using Task4.Models;

namespace Task4.Controllers
{
    public class ManagerController : Controller
    {
        private ApplicationDbContext _context;
        public ManagerController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {

            User? user = _context.Users.Find(HttpContext.Session.GetInt32("LiveUser"));

            return View(user);
        }

    }
}
