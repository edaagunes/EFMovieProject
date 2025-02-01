using EFProject.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DirectorEntityConfiguration : PersonBaseEntityTypeConfiguration<DirectorEntity>
{
	public override void Configure(EntityTypeBuilder<DirectorEntity> builder)
	{
		builder.ToTable("Directors");
		builder.Property(d => d.FullName)
				.HasMaxLength(150)
				.HasColumnName("FullName");

		// One Director has many Movies (One-To-Many) --> Making in MovieEntityConfiguration
		//builder.HasMany(d=>d.Movies).WithOne(m=>m.Director).HasForeignKey(m => m.DirectorId);

		base.Configure(builder);
	}
}
