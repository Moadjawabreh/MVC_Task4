using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Task4.Data;
using Task4.Models;

namespace Task4.Controllers
{
	public class LoginController : Controller
	{
		private ApplicationDbContext _context;
        public LoginController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index([Bind("Email", "PasswordHash")] User user)
		{

            var user1 = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (user1 != null && user1.PasswordHash== user1.PasswordHash) 
			{
           


                HttpContext.Session.SetInt32("LiveUser", user1.Id);
                
                if (user1.role == "employee") 
				{
                    return RedirectToAction("Index", "Customer");
                }
				else
				{
                    return RedirectToAction("Index", "Manager");

                }

            }
            return View();
		}

	}
}
