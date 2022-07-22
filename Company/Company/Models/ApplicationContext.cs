using System;
using Company.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
	public class ApplicationContext:DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
		   : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Rialto>()
				.HasOne(u => u.Company)
				.WithOne(c=>c.Rialto)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<AboutCompany>()
				.HasOne(u => u.Company)
				.WithOne(c => c.AboutCompany)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<User>()
				.HasOne(u => u.Company)
				.WithMany(c => c.Users)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<Course>()
				.HasOne(u => u.Company)
				.WithMany(c => c.Courses)
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<DatabaseModels.Company>()
				.HasOne(u => u.AboutCompany)
				.WithOne(c => c.Company)
				.HasForeignKey<AboutCompany>(p => p.AboutForeignKey);
			modelBuilder.Entity<DatabaseModels.Company>()
				.HasOne(u => u.Rialto)
				.WithOne(c => c.Company)
				.HasForeignKey<Rialto>(p => p.RialtoForeignKey);
		}
		public DbSet<User> Users { get; set; } = null!;
		public DbSet<AboutEmployees> AboutEmployees  { get; set; } = null!;
		public DbSet<Product> Products  { get; set; } = null!;
		public DbSet<Customer> Customers { get; set; } = null!;
		public DbSet<Rialto> Rialtos { get; set; } = null!;
		public DbSet<AboutCompany> AboutCompanies { get; set; } = null!;
		public DbSet<Course> Courses { get; set; } = null!;
		public DbSet<Student> Students { get; set; } = null!;
		public DbSet<StudentPerformance> StudentPerformances { get; set; } = null!;
		public DbSet<DatabaseModels.Company> Companies { get; set; } = null!;
	}
}

