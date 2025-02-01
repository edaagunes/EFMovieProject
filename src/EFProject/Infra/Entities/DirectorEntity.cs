using EFProject.Infra.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Infra.Entities
{
	public class DirectorEntity:PersonBaseEntity
	{
		public string FullName { get; set; }
		public virtual ICollection<MovieEntity> Movies { get; set; }
	}
}
