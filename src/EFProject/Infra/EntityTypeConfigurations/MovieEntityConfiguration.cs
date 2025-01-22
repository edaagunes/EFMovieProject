using EFProject.Infra.Entities;
using EFProject.Infra.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MovieEntityConfiguration : BaseEntityTypeConfiguration<MovieEntity>
{
	public override void Configure(EntityTypeBuilder<MovieEntity> builder)
	{
		builder.ToTable("Movies", schema: "ef");
		builder.Property(x => x.Name).IsRequired(true).HasMaxLength(200);
		builder.Property(x => x.ViewCount).HasDefaultValue(1);

		// One Director has many Movies (One-To-Many)
		builder.HasOne(m => m.Director).WithMany(d => d.Movies).HasForeignKey(m => m.DirectorId);

		// One Genre has many Movies (One-To-Many)
		builder.HasOne(m => m.Genre).WithMany(d => d.Movies).HasForeignKey(m => m.DirectorId);

		// One Movie has many Actors (Many-To-Many)
		builder.HasMany(m => m.Actors).WithMany(d => d.Movies).UsingEntity(j => j.ToTable("MovieActors"));

		base.Configure(builder);
	}
}