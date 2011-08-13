using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.Collections;
using System.Collections.Generic;

namespace LiberMvc.Models
{
	public class FiliacaoModel
	{
		public Pessoa Pessoa { get; set; }

		[ScaffoldColumn(false)]
		public IEnumerable<EstadoCivil> ListaEstadoCivil { get; set; }

		[ScaffoldColumn(false)]
		public IEnumerable<GrauInstrucao> ListaGrauInstrucao { get; set; }

		public IDictionary<string, string> ListaEstados = Listas.Estados;
		
		public Filiado Filiado { get; set; }
	}
}