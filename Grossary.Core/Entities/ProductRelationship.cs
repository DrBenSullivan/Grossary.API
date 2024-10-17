using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grossary.Core.Enums;

namespace Grossary.Core.Entities
{
	public class ProductRelationship
	{
		[Key]
		public Guid Id { get; private set; }

		[Required]
		[ForeignKey("SourceProduct")]
		public Guid SourceProductId { get; private set; }

		[Required]
		[ForeignKey("TargetProduct")]
		public Guid TargetProductId { get; private set; }

		[Required]
		public ProductRelationshipType Relationship { get; private set; }

		[Required]
		public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;


		// Navigation Properties
		public virtual Product SourceProduct { get; set; } = null!;

		public virtual Product TargetProduct { get; set; } = null!;

	}
}
