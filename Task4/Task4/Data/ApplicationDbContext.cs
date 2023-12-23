using Microsoft.EntityFrameworkCore;
using Task4.Models;

namespace Task4.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Manager> Managers { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Tasks> Tasks { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }



	}
}
