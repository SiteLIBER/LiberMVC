using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("AutoresPostagens", Schema = "liber")]
	public class AutorPostagem
	{
		[Key, Column(Order = 0)]
		public int AutorID { get; set; }
	
		[Key, Column(Order = 1)]
		public int PostagemID { get; set; }

		[ForeignKey("AutorID")]
		public virtual Autor Autor { get; set; }

		[ForeignKey("PostagemID")]
		public virtual Postagem Postagem { get; set; }
	}
}
