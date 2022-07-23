using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class AboutEmployees
	{
		[Key]
		public int Id { get; set; }
		public string? Street { get; set; }
		public string? Home { get; set; }
		public string? Apartment { get; set; }

		public int UserId { get; set; }
		[Required]
		public User? User { get; set; }
	}
}

