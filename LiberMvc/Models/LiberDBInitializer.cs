using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace LiberMvc.Models
{
#if DEBUG
	public class LiberDBInitializer : DropCreateDatabaseIfModelChanges<DB>
#else
	public class LiberDBInitializer : CreateDatabaseIfNotExists<LiberDB> // trocar ao ir pro ar
#endif
	{
		protected override void Seed(LiberDB context)
		{

			base.Seed(context);

			#region GrauInstrucao

			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 1, Descricao = "Ensino Fundamental (1ª a 8ª)" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 2, Descricao = "Ensino Médio (Colegial)" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 3, Descricao = "Ensino Médio (Magistério)" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 4, Descricao = "Superior - Técnica" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 5, Descricao = "Superior - Graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 6, Descricao = "Especialização e extensão" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 7, Descricao = "Pós-graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 8, Descricao = "MBA" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 9, Descricao = "Mestrado" });
			context.GrauInstrucao.Add(new GrauInstrucao { GrauInstrucaoID = 10, Descricao = "Doutorado" });

			#endregion

			#region EstadoCivil

			context.EstadoCivil.Add(new EstadoCivil { EstadoCivilID = 1, Descricao = "Solteiro (a)" });
			context.EstadoCivil.Add(new EstadoCivil { EstadoCivilID = 2, Descricao = "Casado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { EstadoCivilID = 3, Descricao = "Divorciado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { EstadoCivilID = 4, Descricao = "Viúvo (a)" });
			context.EstadoCivil.Add(new EstadoCivil { EstadoCivilID = 5, Descricao = "Outros" });

			#endregion

			#region 

			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 1, Descricao = "Blog" });
			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 2, Descricao = "Artigo" });

			#endregion

			#region Save

			context.SaveChanges();

			#endregion

		}
	}
}