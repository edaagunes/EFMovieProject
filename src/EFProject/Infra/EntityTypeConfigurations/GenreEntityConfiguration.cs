using EFProject.Infra.Entities;
using EFProject.Infra.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Infra.EntityTypeConfigurations
{
	public class GenreEntityConfiguration : BaseEntityTypeConfiguration<GenreEntity>
	{
		public override void Configure(EntityTypeBuilder<GenreEntity> builder)
		{
			builder.ToTable("Genres",schema:"ef");
			builder.Property(x => x.Name).HasColumnName("Name").IsRequired(true).HasMaxLength(100);

			base.Configure(builder);
		}
	}
}
