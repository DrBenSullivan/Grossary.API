using Grossary.Core.Enums;

namespace Grossary.Core.Entities
{
	public class ProductRelationship
	{
		public Guid Id { get; } = Guid.NewGuid();
		public required Guid SourceProductId { get; set; }
		public required Guid TargetProductId { get; set; }
		public ProductComparator Relationship { get; private set; }
		public DateTime CreatedAt { get; private set; } = DateTime.Now;
		public required virtual Product SourceProduct { get; set; }
		public required virtual Product TargetProduct { get; set; }

	}
}
