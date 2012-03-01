using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("Contas", Schema = "liber")]
	public class Conta
	{
		[Key]
		public int ContaID { get; set; }

		[DataType(DataType.Currency)]
		public float Valor { get; set; }

		[DataType(DataType.MultilineText), StringLength(200)]
		public string Descricao { get; set; }

		public DateTime Data { get; set; }

		[DataType(DataType.Currency)]
		public float Saldo { get; set; }

		public DateTime CriadoEm { get; set; }

		[ForeignKey("Pessoa")]
		public int? PessoaID { get; set; }

		public virtual Pessoa Pessoa { get; set; }

	}
}
