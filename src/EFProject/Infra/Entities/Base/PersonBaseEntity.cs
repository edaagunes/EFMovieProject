using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Infra.Entities.Base
{
	public abstract class PersonBaseEntity:BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
