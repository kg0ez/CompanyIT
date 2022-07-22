using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class AboutCompany
	{
		[Key]
		public int Id { get; set; }
		public int Value { get; set; }
		public int NumberEmployees { get; set; }

		public int AboutForeignKey { get; set; }
		[Required]
		public Company Company { get; set; } = null!;
	}
}

