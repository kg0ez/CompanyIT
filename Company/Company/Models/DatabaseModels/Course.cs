using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Course
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public List<Student> Students { get; set; } = new();

        public int CompanyId { get; set; }
		[Required]
        public Company? Company { get; set; }
    }
}

