using EFProject.Infra.Entities;
using EFProject.Infra.Entities.Base;

public class ActorEntity : PersonBaseEntity
{
	public virtual ICollection<MovieEntity> Movies { get; set; }
}