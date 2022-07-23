using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Surname { get; set; } = null!;
		public string Name { get; set; } = null!;
		public string Patronymic { get; set; } = null!;
		public string? Phone { get; set; }

		public int CompanyId { get; set; }
		[Required]
		public Company? Company { get; set; }
	}
	public class Employee : User
	{
		public int Salary { get; set; }
		public string Post { get; set; } = null!;
	}
	public class Manager : User
	{
		public string? Departament { get; set; }
	}
}

