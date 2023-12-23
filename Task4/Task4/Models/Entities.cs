namespace Task4.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Manager
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string UserName { get; set; }

		[Required]
		[StringLength(255)]
		public string Email { get; set; }

		[Required]
		[StringLength(20)]
		public string Password { get; set; }


	}

	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string UserName { get; set; }

		[Required]
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

		public byte[] PersonalPhoto { get; set; }

		public DateTime EntryDate { get; set; }

		[Required]
		[StringLength(255)]
		public string PasswordHash { get; set; }

		public int DepartmentId { get; set; }
		public int ManagerId { get; set; }

		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

		[ForeignKey("ManagerId")]
		public Manager Manager { get; set; }
	}

	public class Department
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }

		public ICollection<User> Users { get; set; }
	}

	public class Tasks
	{
		[Key]
		public int TaskId { get; set; }

		[Required]
		[StringLength(20)]
		public string TaskTitle { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime DueDate { get; set; }

		[Required]
		public string TaskDescription { get; set; }

		public int LevelOfImportance { get; set; }

		public int ManagerId { get; set; }
		public int EmployeeId { get; set; }

		[ForeignKey("ManagerId")]
		public Manager Manager { get; set; }

		[ForeignKey("EmployeeId")]
		public User Employee { get; set; }
	}

	public class Feedback
	{
		[Key]
		public int FeedbackId { get; set; }

		[Required]
		[StringLength(50)]
		public string EmailContent { get; set; }

		public DateTime SubmissionDateTime { get; set; }
	}

}
