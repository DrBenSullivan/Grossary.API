using Grossary.Core.Entities;
using Grossary.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grossary.Infrastructure.Persistence.Configuration
{
	public class ProductRelationshipConfiguration : IEntityTypeConfiguration<ProductRelationship>
	{
		public void Configure(EntityTypeBuilder<ProductRelationship> builder)
		{
			builder.ToTable("ProductRelationships");
			builder.HasKey(r => r.Id);
			builder.Property<ProductComparator>(r => r.Relationship).IsRequired();
			builder.Property(r => r.CreatedAt).IsRequired();
			builder.HasOne(r => r.SourceProduct).WithMany().HasForeignKey(r => r.SourceProductId).IsRequired().OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(r => r.TargetProduct).WithMany().HasForeignKey(r => r.TargetProductId).IsRequired().OnDelete(DeleteBehavior.Restrict);
		}
	}
}