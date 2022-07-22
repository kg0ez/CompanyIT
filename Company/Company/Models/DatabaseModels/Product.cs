using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Description { get; set; }

		public int CompanyId { get; set; }
		[Required]
		public Company? Company { get; set; }
	}
}

