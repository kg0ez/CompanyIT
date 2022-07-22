using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Company
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<User> Users { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
        public List<Product> Products { get; set; } = new();

		public Rialto Rialto { get; set; } = null!;

		public AboutCompany AboutCompany { get; set; } = null!;
    }
}

