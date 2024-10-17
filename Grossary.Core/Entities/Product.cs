using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grossary.Core.Entities
{
	public class Product
	{
		[Key]
		public Guid Id { get; private set; }

		[Required]
		[RegularExpression(@"^\d{12,13}$")]
		public string Barcode { get; set; } = string.Empty;

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[Range(0, double.MaxValue)]
		public double Price { get; private set; }

		[MaxLength(500)]
		public string? ImageUri { get; set; }
		
		[Required]
		public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

		public DateTime LastUpdatedAt { get; private set; } = DateTime.UtcNow;

		[ForeignKey("Vendor")]
		public Guid VendorId { get; set; }


		// Navigation Properties
		public virtual Vendor Vendor { get; set; } = null!;


		public void UpdatePrice(double price)
		{
			Price = price;
			LastUpdatedAt = DateTime.UtcNow;
		}
	}
}
