using System.ComponentModel.DataAnnotations;

namespace Task4.Models
{
	public class FeedBack
	{
		[Key]
		public int FeedbackId { get; set; }

		[Required]
		[StringLength(50)]
		public string EmailContent { get; set; }

		public DateTime SubmissionDateTime { get; set; } = DateTime.Now;
		
	}
}
