using EFProject.Infra.DataGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ActorEntityConfiguration : PersonBaseEntityTypeConfiguration<ActorEntity>
{
	public override void Configure(EntityTypeBuilder<ActorEntity> builder)
	{
		builder.ToTable("Actors");

		// One Actor has many Movies (Many-To-Many)
		//builder.HasMany(a => a.Movies)
		//	.WithMany(m => m.Actors)
		//	.UsingEntity(j => j.ToTable("ActorMovies"));

		//builder.HasData(DataGenerator.GenerateActors(10));

		base.Configure(builder);
	}
}