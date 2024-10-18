using Grossary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grossary.Infrastructure.Persistence.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Products");
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Id).ValueGeneratedOnAdd();
			builder.Property(p => p.Barcode).HasMaxLength(13).IsRequired();
			builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
			builder.Property(p => p.Price).IsRequired();
			builder.Property(p => p.ImageUri).HasMaxLength(500).IsRequired(false);
			builder.Property(p => p.CreatedAt).IsRequired().ValueGeneratedOnAdd();
			builder.Property(p => p.LastUpdatedAt).ValueGeneratedOnAddOrUpdate();
			builder.HasOne(p => p.Vendor).WithMany(v => v.Products).HasForeignKey(p => p.VendorId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}