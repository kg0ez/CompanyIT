using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = null!;
        public int ProductId { get; set; }
		[Required]
        public Product? Product { get; set; }
    }
}

