using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace LiberMvc.Models
{
#if DEBUG
	public class LiberDBInitializer : DropCreateDatabaseIfModelChanges<LiberDB>
#else
	public class LiberDBInitializer : CreateDatabaseIfNotExists<LiberDB>
#endif
	{
		protected override void Seed(LiberDB context)
		{

			base.Seed(context);

			#region GrauInstrucao

			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Selecione o Grau de Instrução" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Fundamental (1ª a 8ª) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Fundamental (1ª a 8ª)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Colegial) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Colegial)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Magistério) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Magistério)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Técnica [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Técnica" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Graduação [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Especialização e extensão [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Especialização e extensão" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Pós-graduação [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Pós-graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "MBA [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "MBA" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Mestrado [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Mestrado" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Doutorado [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Doutorado" });

			#endregion

			#region EstadoCivil
			
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Selecione o Estado Civil" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Solteiro (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Casado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Divorciado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Viúvo (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Outros" });

			#endregion

			#region TipoPostagem

			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 1, Descricao = "Blog" });
			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 2, Descricao = "Artigos" });

			#endregion

			#region Titulos

			context.Titulos.Add(new Titulo { TituloID = 1, Nome = "Usuário", Codigo = "Usuario" });
			context.Titulos.Add(new Titulo { TituloID = 2, Nome = "Filiado", Codigo = "Filiado" });
			context.Titulos.Add(new Titulo { TituloID = 3, Nome = "Administrador", Codigo = "Admin" });
			context.Titulos.Add(new Titulo { TituloID = 4, Nome = "Editor", Codigo = "Editor" });
			
			#endregion

			#region Save

			context.SaveChanges();

			#endregion

		}
	}
}