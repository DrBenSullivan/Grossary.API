namespace Grossary.Core.Entities
{
	public class Vendor
	{
		public Guid Id { get; } = Guid.NewGuid();
		public required string Name { get; set; }
		public required string ImageUri { get; set; }


		// Navigation properties.
		public ICollection<Product> Products { get; set; } = [];
	}
}
