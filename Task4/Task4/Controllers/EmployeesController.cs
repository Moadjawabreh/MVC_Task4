using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Task4.Data;
using Task4.Models;

namespace Task4.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {

            return View(_context.Users.ToList());
        }


        public IActionResult SearchByName(string SearchItem)
        {
            
            var searchResults = _context.Users
                .Where(u => u.UserName.Contains(SearchItem, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return View(searchResults);
        }


        public IActionResult Create()
        {

            IEnumerable<SelectListItem> DepartmentList = _context.Departments.ToList().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });
            ViewBag.DepartmentList = DepartmentList;

            return View();
        }
        [HttpPost]
        public IActionResult Create(User user )
        {
        
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }



    }
}
