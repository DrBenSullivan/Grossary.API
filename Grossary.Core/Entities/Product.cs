namespace Grossary.Core.Entities
{
	public class Product
	{
		public Guid Id { get; } = Guid.NewGuid();
		public required string Barcode { get; set; }
		public required string Name { get; set; }
		public double Price { get; set; }
		public string? ImageUri { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime LastUpdatedAt { get; set; }

		// Foreign keys.
		public Guid VendorId { get; set; }

		// Navigation properties.
		public required virtual Vendor Vendor { get; set; }
	}
}
