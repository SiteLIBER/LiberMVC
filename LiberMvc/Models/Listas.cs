using System.Collections.Generic;

namespace LiberMvc.Models
{
	public class Listas
	{
		public static IDictionary<string, string> Estados = new Dictionary<string, string> 
		{
			{ "AC", "Acre" },
			{ "AL", "Alagoas" },
			{ "AM", "Amazonas" },
			{ "AP", "Amapá" },
			{ "BA", "Bahia" },
			{ "CE", "Ceará" },
			{ "DF", "Distrito Federal" },
			{ "ES", "Espírito Santo" },
			{ "GO", "Goiás" },
			{ "MA", "Maranhão" },
			{ "MG", "Minas Gerais" },
			{ "MS", "Mato Grosso do Sul" },
			{ "MT", "Mato Grosso" },
			{ "PA", "Pará" },
			{ "PB", "Paraíba" },
			{ "PE", "Pernambuco" },
			{ "PI", "Piauí" },
			{ "PR", "Paraná" },
			{ "RJ", "Rio de Janeiro" },
			{ "RN", "Rio Grande do Norte" },
			{ "RO", "Rondônia" },
			{ "RR", "Roraima" },
			{ "RS", "Rio Grande do Sul" },
			{ "SC", "Santa Catarina" },
			{ "SP", "São Paulo" },
			{ "SE", "Sergipe" },
			{ "TO", "Tocantins" }
		};

		public static IDictionary<string, string> Sexo = new Dictionary<string, string>
		{
			{ "F", "Feminino" },
			{ "M", "Masculino" }
		};

		public static IDictionary<bool, string> SimNao = new Dictionary<bool, string>
		{
			{ true, "Sim" },
			{ false, "Não" }
		};
	}
}