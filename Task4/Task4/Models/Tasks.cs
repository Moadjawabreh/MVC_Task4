using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task4.Models
{
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

		public int EmployeeId { get; set; }


		[ForeignKey("EmployeeId")]
		public User Employee { get; set; }
	}
}
