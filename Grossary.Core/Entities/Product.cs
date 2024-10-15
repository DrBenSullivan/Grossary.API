using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grossary.Core.Entities
{
	public class Product
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public int Barcode { get; set; }
		[Required]
		[MaxLength(100)]
		public string? Name { get; set; }
		[Required]
		[Range(0, double.MaxValue)]
		public double Price { get; set; }
		public string? ImageUri { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime LastUpdatedAt { get; set; }
		[ForeignKey("Vendor")]
		public Guid VendorId { get; set; }

	}
}
