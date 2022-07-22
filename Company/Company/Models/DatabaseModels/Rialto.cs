using System;
using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class Rialto
	{
		[Key]
		public int Id { get; set; }
		public int Cost { get; set; }
		public int NumberShares { get; set; }

		public int RialtoForeignKey { get; set; }
		[Required]
		public Company? Company { get; set; }
	}
}

