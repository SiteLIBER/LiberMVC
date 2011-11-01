using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class Menu
	{
		[Key]
		public int MenuID { get; set; }

		public int? RootID { get; set; }

		[StringLength(50)]
		public string Titulo { get; set; }

		[ForeignKey("RootID")]
		public virtual Menu Root { get; set; }
	}
}
