using System.ComponentModel.DataAnnotations;

namespace Grossary.Core.Entities
{
	public class Vendor
	{
		[Key]
		public Guid Id { get; private set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; private set; } = string.Empty;

		[MaxLength(500)]
		public string? ImageUri { get; set; }
	}
}
