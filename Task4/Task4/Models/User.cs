using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task4.Models
{
	public class User
	{
			[Key]
			public int Id { get; set; }

			[StringLength(255)]
			public string UserName { get; set; }

			[StringLength(255)]
			public string Email { get; set; }

			public DateTime Birthdate { get; set; }

			[StringLength(20)]
			public string PhoneNumber { get; set; }

			public int NationalID { get; set; }

			[StringLength(50)]
			public string Nationality { get; set; }

			[StringLength(20)]
			public string MaritalStatus { get; set; }

			public string PersonalPhoto { get; set; }

			public DateTime EntryDate { get; set; }

			public string role { get; set; }

		[StringLength(255)]
			public string PasswordHash { get; set; }

			public int DepartmentId { get; set; }

			[ForeignKey("DepartmentId")]
			public Department Department { get; set; }

			
		}
	}

