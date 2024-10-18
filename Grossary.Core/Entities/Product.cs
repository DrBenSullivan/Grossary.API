namespace Grossary.Core.Entities
{
	public class Product
	{
		public Guid Id { get; } = Guid.NewGuid();
		public string Barcode { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string? ImageUri { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime LastUpdatedAt { get; set; }

		// Foreign keys.
		public Guid VendorId { get; set; }

		// Navigation properties.
		public virtual Vendor Vendor { get; set; }
	}
}
