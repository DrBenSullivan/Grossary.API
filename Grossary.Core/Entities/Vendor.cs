namespace Grossary.Core.Entities
{
	public class Vendor
	{
		public Guid Id { get; } = Guid.NewGuid();
		public string Name { get; set; }
		public string ImageUri { get; set; }


		// Navigation properties.
		public ICollection<Product> Products { get; set; } = [];
	}
}
