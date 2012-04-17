namespace LiberMvc.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "liber.Usuarios",
            //    c => new
            //        {
            //            PessoaID = c.Int(nullable: false),
            //            FacebookID = c.Long(),
            //            Apelido = c.String(nullable: false),
            //            Senha = c.String(nullable: false, maxLength: 50),
            //            Email = c.String(nullable: false, maxLength: 250),
            //            Banido = c.Boolean(nullable: false),
            //            ReceberNewsletter = c.Boolean(nullable: false),
            //            CriadoEm = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PessoaID)
            //    .ForeignKey("liber.Pessoas", t => t.PessoaID)
            //    .Index(t => t.PessoaID);
            
            //CreateTable(
            //    "liber.Pessoas",
            //    c => new
            //        {
            //            PessoaID = c.Int(nullable: false, identity: true),
            //            Nome = c.String(nullable: false, maxLength: 250),
            //            DataNasc = c.DateTime(nullable: false),
            //            Naturalidade = c.String(nullable: false, maxLength: 50),
            //            NomePai = c.String(nullable: false, maxLength: 250),
            //            NomeMae = c.String(nullable: false, maxLength: 250),
            //            EstadoCivilID = c.Int(nullable: false),
            //            Profissao = c.String(nullable: false, maxLength: 100),
            //            GrauInstrucaoID = c.Int(nullable: false),
            //            Endereco_Logradouro = c.String(nullable: false, maxLength: 250),
            //            Endereco_Cidade = c.String(nullable: false, maxLength: 250),
            //            Endereco_Estado = c.String(nullable: false, maxLength: 2),
            //            Endereco_CEP = c.String(nullable: false, maxLength: 9),
            //            Telefone = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.PessoaID)
            //    .ForeignKey("liber.EstadoCivil", t => t.EstadoCivilID)
            //    .ForeignKey("liber.GrauInstrucao", t => t.GrauInstrucaoID)
            //    .Index(t => t.EstadoCivilID)
            //    .Index(t => t.GrauInstrucaoID);
            
            //CreateTable(
            //    "liber.EstadoCivil",
            //    c => new
            //        {
            //            EstadoCivilID = c.Int(nullable: false, identity: true),
            //            Descricao = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.EstadoCivilID);
            
            //CreateTable(
            //    "liber.GrauInstrucao",
            //    c => new
            //        {
            //            GrauInstrucaoID = c.Int(nullable: false, identity: true),
            //            Descricao = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.GrauInstrucaoID);
            
            //CreateTable(
            //    "liber.TitulosPessoas",
            //    c => new
            //        {
            //            PessoaID = c.Int(nullable: false),
            //            TituloID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.PessoaID, t.TituloID })
            //    .ForeignKey("liber.Titulos", t => t.TituloID)
            //    .ForeignKey("liber.Pessoas", t => t.PessoaID)
            //    .Index(t => t.TituloID)
            //    .Index(t => t.PessoaID);
            
            //CreateTable(
            //    "liber.Titulos",
            //    c => new
            //        {
            //            TituloID = c.Int(nullable: false, identity: true),
            //            Codigo = c.String(),
            //            Nome = c.String(),
            //        })
            //    .PrimaryKey(t => t.TituloID);
            
            //CreateTable(
            //    "liber.Filiados",
            //    c => new
            //        {
            //            PessoaID = c.Int(nullable: false),
            //            TituloEleitor = c.String(nullable: false, maxLength: 20),
            //            Zona = c.String(nullable: false, maxLength: 4),
            //            Secao = c.String(nullable: false, maxLength: 4),
            //            MunicipioUF = c.String(nullable: false, maxLength: 250),
            //            OutroPartido = c.Boolean(nullable: false),
            //            OutroPartidoQual = c.String(maxLength: 50),
            //            FiliadoEm = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PessoaID)
            //    .ForeignKey("liber.Pessoas", t => t.PessoaID)
            //    .Index(t => t.PessoaID);
            
            //CreateTable(
            //    "liber.Autores",
            //    c => new
            //        {
            //            AutorID = c.Int(nullable: false, identity: true),
            //            Nome = c.String(maxLength: 250),
            //            Descricao = c.String(maxLength: 1000),
            //            PessoaID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.AutorID)
            //    .ForeignKey("liber.Pessoas", t => t.PessoaID)
            //    .Index(t => t.PessoaID);
            
            //CreateTable(
            //    "liber.AutoresPostagens",
            //    c => new
            //        {
            //            AutorID = c.Int(nullable: false),
            //            PostagemID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.AutorID, t.PostagemID })
            //    .ForeignKey("liber.Autores", t => t.AutorID)
            //    .ForeignKey("liber.Postagens", t => t.PostagemID)
            //    .Index(t => t.AutorID)
            //    .Index(t => t.PostagemID);
            
            //CreateTable(
            //    "liber.Postagens",
            //    c => new
            //        {
            //            PostagemID = c.Int(nullable: false, identity: true),
            //            TipoPostagemID = c.Int(nullable: false),
            //            Titulo = c.String(nullable: false, maxLength: 250),
            //            Chamada = c.String(nullable: false, maxLength: 1000),
            //            Conteudo = c.String(nullable: false),
            //            Publicado = c.Boolean(nullable: false),
            //            PublicadoEm = c.DateTime(),
            //            CriadoEm = c.DateTime(),
            //            Fonte = c.String(maxLength: 500),
            //        })
            //    .PrimaryKey(t => t.PostagemID)
            //    .ForeignKey("liber.TiposPostagem", t => t.TipoPostagemID)
            //    .Index(t => t.TipoPostagemID);
            
            //CreateTable(
            //    "liber.TiposPostagem",
            //    c => new
            //        {
            //            TipoPostagemID = c.Int(nullable: false, identity: true),
            //            Descricao = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.TipoPostagemID);
            
            //CreateTable(
            //    "liber.Paginas",
            //    c => new
            //        {
            //            PaginaID = c.Int(nullable: false, identity: true),
            //            Titulo = c.String(nullable: false, maxLength: 250),
            //            Conteudo = c.String(nullable: false),
            //            Publicado = c.Boolean(nullable: false),
            //            CriadoEm = c.DateTime(),
            //            Link = c.String(),
            //        })
            //    .PrimaryKey(t => t.PaginaID);
            
            //CreateTable(
            //    "liber.Agendas",
            //    c => new
            //        {
            //            AgendaID = c.Int(nullable: false, identity: true),
            //            Titulo = c.String(maxLength: 200),
            //            DataInicio = c.DateTime(nullable: false),
            //            DataFim = c.DateTime(),
            //            Local = c.String(maxLength: 200),
            //            Conteudo = c.String(),
            //        })
            //    .PrimaryKey(t => t.AgendaID);
            
            //CreateTable(
            //    "liber.Contas",
            //    c => new
            //        {
            //            ContaID = c.Int(nullable: false, identity: true),
            //            Valor = c.Single(nullable: false),
            //            Descricao = c.String(maxLength: 200),
            //            Data = c.DateTime(nullable: false),
            //            Saldo = c.Single(nullable: false),
            //            CriadoEm = c.DateTime(nullable: false),
            //            PessoaID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ContaID)
            //    .ForeignKey("liber.Pessoas", t => t.PessoaID)
            //    .Index(t => t.PessoaID);
            
        }
        
        public override void Down()
        {
            //DropIndex("liber.Contas", new[] { "PessoaID" });
            //DropIndex("liber.Postagens", new[] { "TipoPostagemID" });
            //DropIndex("liber.AutoresPostagens", new[] { "PostagemID" });
            //DropIndex("liber.AutoresPostagens", new[] { "AutorID" });
            //DropIndex("liber.Autores", new[] { "PessoaID" });
            //DropIndex("liber.Filiados", new[] { "PessoaID" });
            //DropIndex("liber.TitulosPessoas", new[] { "PessoaID" });
            //DropIndex("liber.TitulosPessoas", new[] { "TituloID" });
            //DropIndex("liber.Pessoas", new[] { "GrauInstrucaoID" });
            //DropIndex("liber.Pessoas", new[] { "EstadoCivilID" });
            //DropIndex("liber.Usuarios", new[] { "PessoaID" });
            //DropForeignKey("liber.Contas", "PessoaID", "liber.Pessoas");
            //DropForeignKey("liber.Postagens", "TipoPostagemID", "liber.TiposPostagem");
            //DropForeignKey("liber.AutoresPostagens", "PostagemID", "liber.Postagens");
            //DropForeignKey("liber.AutoresPostagens", "AutorID", "liber.Autores");
            //DropForeignKey("liber.Autores", "PessoaID", "liber.Pessoas");
            //DropForeignKey("liber.Filiados", "PessoaID", "liber.Pessoas");
            //DropForeignKey("liber.TitulosPessoas", "PessoaID", "liber.Pessoas");
            //DropForeignKey("liber.TitulosPessoas", "TituloID", "liber.Titulos");
            //DropForeignKey("liber.Pessoas", "GrauInstrucaoID", "liber.GrauInstrucao");
            //DropForeignKey("liber.Pessoas", "EstadoCivilID", "liber.EstadoCivil");
            //DropForeignKey("liber.Usuarios", "PessoaID", "liber.Pessoas");
            //DropTable("liber.Contas");
            //DropTable("liber.Agendas");
            //DropTable("liber.Paginas");
            //DropTable("liber.TiposPostagem");
            //DropTable("liber.Postagens");
            //DropTable("liber.AutoresPostagens");
            //DropTable("liber.Autores");
            //DropTable("liber.Filiados");
            //DropTable("liber.Titulos");
            //DropTable("liber.TitulosPessoas");
            //DropTable("liber.GrauInstrucao");
            //DropTable("liber.EstadoCivil");
            //DropTable("liber.Pessoas");
            //DropTable("liber.Usuarios");
        }
    }
}
