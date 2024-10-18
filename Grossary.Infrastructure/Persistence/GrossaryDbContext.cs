using System.Reflection;
using Grossary.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Grossary.Infrastructure.Persistence
{
	public class GrossaryDbContext : DbContext
	{
		public GrossaryDbContext(DbContextOptions<GrossaryDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<ProductRelationship> ProductRelationships { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			 modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
