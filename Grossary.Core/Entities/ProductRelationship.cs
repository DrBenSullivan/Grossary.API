using Grossary.Core.Enums;

namespace Grossary.Core.Entities
{
	public class ProductRelationship
	{
		public Guid Id { get; } = Guid.NewGuid();
		public Guid SourceProductId { get; private set; }
		public Guid TargetProductId { get; private set; }
		public ProductComparator Relationship { get; private set; }
		public DateTime CreatedAt { get; private set; } = DateTime.Now;
		public virtual Product SourceProduct { get; set; }
		public virtual Product TargetProduct { get; set; }

	}
}
