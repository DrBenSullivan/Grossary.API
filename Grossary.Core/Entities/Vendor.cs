using System.ComponentModel.DataAnnotations;

namespace Grossary.Core.Entities
{
	public class Vendor
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string? Name { get; set; }
		public string? ImageUri { get; set; }
	}
}
