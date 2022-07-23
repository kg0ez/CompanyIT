using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		public string Surname { get; set; } = null!;
		public string Name { get; set; } = null!;
		public string Patronymic { get; set; } = null!;
		public string? Mail { get; set; }
		public List<Course> Courses { get; set; } = new();
	}
}

