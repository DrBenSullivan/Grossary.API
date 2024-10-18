using Grossary.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grossary.Infrastructure.Persistence.Configuration
{
	public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
	{
		public void Configure(EntityTypeBuilder<Vendor> builder)
		{
			builder.ToTable("Vendors");
			builder.HasKey(v => v.Id);
			builder.Property(v => v.Id).ValueGeneratedOnAdd();
			builder.Property(v => v.Name).HasMaxLength(100).IsRequired();
			builder.Property(v => v.ImageUri).HasMaxLength(500).IsRequired(false);
			builder.HasMany(v => v.Products).WithOne(p => p.Vendor).HasForeignKey(p => p.VendorId).OnDelete(DeleteBehavior.Cascade);
		}
	}
}