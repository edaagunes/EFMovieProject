using EFProject.Infra.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Infra.EntityTypeConfigurations
{
	public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
	{
		public virtual void Configure(EntityTypeBuilder<TEntity> builder)
		{
			builder.HasKey(x => x.Id);
			//builder.Property(x => x.Id).HasColumnName("id");
			builder.Property(x => x.CreatedDate).HasColumnType("datetime2");
			//builder.Property(x => x.CreatedDate).HasColumnType("datetime2").HasDefaultValue(DateTime.Now).HasDefaultValueSql("getdate()");
			builder.Property(x => x.ModifiedDate).HasColumnType("datetime2").IsRequired(false);
		}
	}
}
