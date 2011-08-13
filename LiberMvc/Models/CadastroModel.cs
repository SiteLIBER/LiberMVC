using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class CadastroModel
	{
		public Usuario Usuario { get; set; }

		[DisplayName("Desejo me filiar agora")]
		public bool DesejaFiliacao { get; set; }
	}

}