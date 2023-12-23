using System.ComponentModel.DataAnnotations;

namespace Task4.Models
{
	public class Department
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }

		public ICollection<User> Users { get; set; }
	}
}
