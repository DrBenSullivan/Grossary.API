using Grossary.Core.Entities;
using Grossary.Infrastructure.Persistence;

namespace Grossary.Infrastructure.Extensions
{
	public static class GrossaryDbContextExtensions
	{
		public static async Task SeedAsync(this GrossaryDbContext context)
		{
			if (!context.Products.Any() && !context.Vendors.Any())
			{
				var vendorA = new Vendor()
				{
					ImageUri = "https://images.fallout.wiki/e/ea/Super_Duper_Mart_Logo.png",
					Name = "Super Duper Mart"
				};

				var vendorB = new Vendor()
				{
					ImageUri = "https://images.fallout.wiki/thumb/c/c3/Decal_redrocket02.webp/499px-Decal_redrocket02.webp.png",
					Name = "Red Rocket"
				};

				var productA = new Product()
				{
					Barcode = "0",
					CreatedAt = DateTime.Now,
					ImageUri = "https://images.fallout.wiki/thumb/d/d7/Fallout4_Sugar_Bombs.png/722px-Fallout4_Sugar_Bombs.png",
					LastUpdatedAt = DateTime.Now,
					Name = "Sugar Bombs",
					Price = 3.99,
					VendorId = vendorA.Id
				};

				var productB = new Product()
				{
					Barcode = "1",
					CreatedAt = DateTime.Now,
					ImageUri = "https://images.fallout.wiki/thumb/a/a4/Nukacoladecal01_d.webp/1024px-Nukacoladecal01_d.webp.png",
					LastUpdatedAt = DateTime.Now,
					Name = "Nuka-Cola",
					Price = 1.49,
					VendorId = vendorB.Id
				};

				await context.Products.AddRangeAsync(productA, productB);
				await context.Vendors.AddRangeAsync(vendorA, vendorB);
				await context.SaveChangesAsync();
				return;
			}
		}
	}
}
