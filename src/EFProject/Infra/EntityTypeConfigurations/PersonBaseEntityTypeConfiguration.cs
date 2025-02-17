using EFProject.Infra.Entities.Base;
using EFProject.Infra.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PersonBaseEntityTypeConfiguration<TEntity> : BaseEntityTypeConfiguration<TEntity> where TEntity : PersonBaseEntity
{
	public override void Configure(EntityTypeBuilder<TEntity> builder)
	{
		builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
		//builder.HasIndex(x => x.FirstName).IsUnique().HasDatabaseName("idx_1");
		builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);

		base.Configure(builder);
	}
}