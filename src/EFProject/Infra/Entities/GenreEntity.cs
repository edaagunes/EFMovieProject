using EFProject.Infra.Entities.Base;

namespace EFProject.Infra.Entities
{
	public class GenreEntity : BaseEntity
	{
		public string Name { get; set; }
		public virtual ICollection<MovieEntity> Movies { get; set; }
	}
}
